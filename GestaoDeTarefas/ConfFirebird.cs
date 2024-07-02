namespace GestaoDeTarefas {

    public static class ConfFirebird {

        public static List<Conexao> Conexoes = new List<Conexao>();

        public static String CaminhoBanco => Environment.CurrentDirectory + "\\Banco\\Firebird.conf";

        public static void EscritaArquivo() {
            String registros = "";
            String strConexao = "[@ALIAS]\n" +
                "DataSource=@IP;\n" +
                "port=@PORT;\n" +
                "DataBase=@CAMINHO;\n" +
                "username=@USERNAME;\n" +
                "password=@PASSWORD;\n\n\n";

            foreach (Conexao cn in Conexoes) {
                strConexao = strConexao.Replace("@ALIAS", cn.Alias);
                strConexao = strConexao.Replace("@IP", cn.Ip);
                strConexao = strConexao.Replace("@PORT", cn.Porta.ToString());
                strConexao = strConexao.Replace("@CAMINHO", cn.Caminho);
                strConexao = strConexao.Replace("@USERNAME", cn.UserName);
                strConexao = strConexao.Replace("@PASSWORD", cn.Password);
                registros += strConexao;
            }
            File.WriteAllText(CaminhoBanco, registros);
        }

        public static void PopulaLista() {
            String texto = File.ReadAllText(CaminhoBanco);
            String[] registros = texto.Split("[", StringSplitOptions.RemoveEmptyEntries);
            Conexao conexao;
            foreach (String registro in registros) {
                String[] linhas = registro.Split(";");
            }
        }

    }

}