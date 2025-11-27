using GestaoDeTarefas.Services.Dtos;

namespace GestaoDeTarefas.Ferramentas {

  public class FirebirdParser {

    private String caminhoBanco { get; } = Environment.CurrentDirectory + "\\Banco\\Firebird.conf";

    public void EscreveDadosArquivoConf(FirebirdConfDto confDto) {
      String registros = "[Config]\n" +
        $"DefaultConnect={confDto.ConexaoPadrao.Alias}\n" +
        $"Edit={confDto.Edit}\n\n";

      foreach (ConexaoBancoDto cn in confDto.Conexoes) {
        String strConexao = $"[{cn.Alias}]\n" +
          $"DataSource={cn.Ip}\n" +
          $"Port={cn.Porta}\n" +
          $"Database={cn.Caminho}\n" +
          $"Username={cn.Usuario}\n" +
          $"Password={cn.Senha}\n\n";
        registros += strConexao;
      }
      File.WriteAllText(caminhoBanco, registros);
    }

    public FirebirdConfDto LeDadosArquivoConf() {
      String[] arraylinhas = File.ReadAllLines(caminhoBanco);
      List<Dictionary<String, string>> databases = new List<Dictionary<string, string>>();
      List<Dictionary<string, string>> config = new List<Dictionary<string, string>>();
      Dictionary<string, string> registro = null;

      foreach (string linha in arraylinhas) {
        string l = linha.ToLower().Trim();
        string[] pedacos;
        if (l.Contains('#') || l.Equals("")) {
          continue;
        }
        if (l.Contains('=')) {
          pedacos = l.Split("=");
          registro[pedacos[0]] = pedacos[1];
        } else if (l.StartsWith("[")) {
          registro = new Dictionary<string, string>();
          if (l.Contains("[config]")) {
            config.Add(registro);
          } else {
            databases.Add(registro);
          }
          l = l.Substring(1, l.Length - 2);
          registro.Add("alias", l);
        }
      }
      ConexaoBancoDto conexaoPadrao = null;
      int edit = 0;
      List<ConexaoBancoDto> conexoes = new List<ConexaoBancoDto>();
      foreach (Dictionary<string, string> dictionary in databases) {
        ConexaoBancoDto conexaoBanco = new ConexaoBancoDto(
          dictionary["alias"],
          Convert.ToInt32(dictionary["port"]),
          dictionary["datasource"],
          dictionary["database"],
          dictionary["username"],
          dictionary["password"]
        );
        if (conexaoBanco.Alias == config[0]["defaultconnect"]) {
          conexaoPadrao = conexaoBanco;
          edit = Convert.ToInt32(config[0]["edit"]);
        }
        conexoes.Add(conexaoBanco);
      }
      return new FirebirdConfDto(conexaoPadrao!, edit, conexoes);
    }

  }
}
