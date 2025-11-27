using GestaoDeTarefas.Ferramentas;
using GestaoDeTarefas.Services.Dtos;
using GestaoDeTarefas.Services.Modelos;

namespace GestaoDeTarefas.Services {

  public class FirebirdConfServices {

    private readonly FirebirdParser fbParser;

    private FirebirdConf Conf { get; }

    public FirebirdConfServices(FirebirdParser fbParser) {
      this.fbParser = fbParser;
      Conf = CarregaDadosArquivo();
    }

    public List<ConexaoBancoDto> GetConexoes() {
      return FirebirdConfParaDto().Conexoes;
    }

    public Int32 GetEdit() {
      return Conf.Edit;
    }

    public ConexaoBancoDto GetConexaoPadrao() {
      return ConexaoBancoParaDto(Conf.ConexaoPadrao);
    }

    public void Adicionar(ConexaoBancoDto conexaoDto) {
      ConexaoBanco conexao = ConexaoBancoDtoParaModelo(conexaoDto);
      Conf.Conexoes.Add(conexao);
      FirebirdConfDto confDto = FirebirdConfParaDto();
      fbParser.EscreveDadosArquivoConf(confDto);
    }

    public void Editar(ConexaoBancoDto conexaoNovaDto, String aliasConexaoAntiga) {
      ConexaoBanco conexaoNova = ConexaoBancoDtoParaModelo(conexaoNovaDto);

      ConexaoBanco conexao = Conf!.Conexoes.First(c => c.Alias == aliasConexaoAntiga);
      Conf.Conexoes[Conf.Conexoes.IndexOf(conexao)] = conexaoNova;

      FirebirdConfDto confDto = FirebirdConfParaDto();
      fbParser.EscreveDadosArquivoConf(confDto);
    }

    public void Excluir(ConexaoBancoDto conexaoDto) {
      ConexaoBanco conexao = ConexaoBancoDtoParaModelo(conexaoDto);

      ConexaoBanco c = Conf!.Conexoes.First(c => c.Alias == conexao.Alias);
      Conf!.Conexoes.Remove(c);

      FirebirdConfDto confDto = FirebirdConfParaDto();
      fbParser.EscreveDadosArquivoConf(confDto);
    }

    private FirebirdConf CarregaDadosArquivo() {
      FirebirdConfDto result = fbParser.LeDadosArquivoConf();
      return FirebirdConfDtoParaModelo(result);
    }

    private ConexaoBancoDto ConexaoBancoParaDto(ConexaoBanco conexao) {
      return new ConexaoBancoDto(
        conexao.Alias,
        conexao.Porta,
        conexao.Ip,
        conexao.Caminho,
        conexao.Usuario,
        conexao.Senha
      );
    }

    private ConexaoBanco ConexaoBancoDtoParaModelo(ConexaoBancoDto conexaoDto) {
      return new ConexaoBanco(
        conexaoDto.Alias,
        conexaoDto.Porta,
        conexaoDto.Ip,
        conexaoDto.Caminho,
        conexaoDto.Usuario,
        conexaoDto.Senha
      );
    }

    private FirebirdConfDto FirebirdConfParaDto() {
      List<ConexaoBancoDto> conexoesDto = new List<ConexaoBancoDto>();
      foreach (ConexaoBanco conexao in Conf.Conexoes) {
        conexoesDto.Add(ConexaoBancoParaDto(conexao));
      }
      return new FirebirdConfDto(ConexaoBancoParaDto(Conf.ConexaoPadrao), Conf.Edit, conexoesDto);
    }

    private FirebirdConf FirebirdConfDtoParaModelo(FirebirdConfDto confDto) {
      List<ConexaoBanco> conexoes = new List<ConexaoBanco>();
      foreach (ConexaoBancoDto conexao in confDto.Conexoes) {
        conexoes.Add(ConexaoBancoDtoParaModelo(conexao));
      }
      return new FirebirdConf(ConexaoBancoDtoParaModelo(confDto.ConexaoPadrao), confDto.Edit, conexoes);
    }
  }

}
