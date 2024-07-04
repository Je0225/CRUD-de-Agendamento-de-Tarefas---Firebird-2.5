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
            List<Dictionary<String, String>> Dicionarios = new List<Dictionary<String, String>>();
            Dictionary<String, String> registro = new Dictionary<String, String>();

            for (int i = 0; i < arraylinhas.Length; i++) { 
                String linha = arraylinhas[i].ToLower();
                String[] pedacos;
                if (linha.Contains('=')) { 
                    pedacos = linha.Split("=");
                    registro.Add(pedacos[0], pedacos[1]);
                } else if (linha.Contains("[")) {
                    if (i > 0) {
                        Dicionarios.Add(registro);
                        registro = new Dictionary<String, String>();
                        linha = linha.Substring(1, linha.Length - 2);
                        registro.Add("alias", linha);
                    }
                }
            }
            foreach (Dictionary<String, String> dictionary in Dicionarios) {
                Conexao conexao = new Conexao(
                    dictionary["alias"],
                    dictionary["server"],
                    Convert.ToInt32(dictionary["port"]),
                    dictionary["datasource"],
                    dictionary["database"],
                    dictionary["username"],
                    dictionary["password"]
                );
                Conexoes.Add(conexao);
            }
            //foreach (Conexao conexao in Conexoes.Where(n => n.Alias == registroConfig["DefaultConnect"])) {
              //  Config = new Config(conexao, Convert.ToInt32(registroConfig["Edit"]));
            //}



        }

        public void ExcluirConexao(Conexao conexao) {
            Conexoes.Remove(conexao);
            SalvaConfiguracoes();
        }

    }

}