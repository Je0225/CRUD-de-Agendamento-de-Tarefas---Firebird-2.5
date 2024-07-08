namespace GestaoDeTarefas {

    public class ConfFirebird {

        public List<Conexao> Conexoes = new List<Conexao>();

        public Config Config { get; set; }

        private String CaminhoBanco => Environment.CurrentDirectory + "\\Banco\\Firebird.conf";

        public void SalvaConfiguracoes() {
            String registros = "";
            foreach (Conexao cn in Conexoes) {
                String strConexao = $"[{cn.Alias}]\n" +
                    $"Server={cn.Servidor}\n" +
                    $"DataSource={cn.Ip}\n" +
                    $"Port={cn.Porta}\n" +
                    $"Database={cn.Caminho}\n" +
                    $"Username={cn.UserName}\n" +
                    $"Password={cn.Password}\n\n";
                registros += strConexao;
            }
            File.WriteAllText(CaminhoBanco, registros);
        }

        public void AtualizaListaConexoes() {
            Conexoes.Clear();
            String[] arraylinhas = File.ReadAllLines(CaminhoBanco);
            List<Dictionary<String, String>> databases = new List<Dictionary<String, String>>();
            List<Dictionary<String, String>> config = new List<Dictionary<String, String>>();
            Dictionary<String, String> registro = null;

            foreach (String linha in arraylinhas) {
                String l = linha.ToLower().Trim();
                String[] pedacos;
                if (l.Contains('=')) {
                    pedacos = l.Split("=");
                    registro[pedacos[0]] = pedacos[1];
                } else if (l.StartsWith("[")) {
                    registro = new Dictionary<String, String>();
                    if (l.Contains("[config]")) {
                        config.Add(registro);
                    } else {
                        databases.Add(registro);
                    }
                    l = l.Substring(1, l.Length - 2);
                    registro.Add("alias", l); 
                }
            }

            foreach (Dictionary<String, String> dictionary in databases) {
                Conexao conexao = new Conexao(
                    dictionary["alias"],
                    dictionary["server"],
                    Convert.ToInt32(dictionary["port"]),
                    dictionary["datasource"],
                    dictionary["database"],
                    dictionary["username"],
                    dictionary["password"]
                );
                if (conexao.Alias == config[0]["defaultconnect"]) {
                    Config = new Config(
                        conexao,
                        Convert.ToInt32(config[0]["edit"])
                    );
                }
                Conexoes.Add(conexao);
            }
        }

        public void ExcluirConexao(Conexao conexao) {
            Conexoes.Remove(conexao);
            SalvaConfiguracoes();
        }
    }

}