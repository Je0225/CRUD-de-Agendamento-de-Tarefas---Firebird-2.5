namespace GestaoDeTarefas {

    public class ConfFirebird {

        public List<Conexao> Conexoes = new List<Conexao>();

        private String CaminhoBanco => Environment.CurrentDirectory + "\\Banco\\Firebird.conf";

        public void EscritaArquivo() {
            String registros = "";

            foreach (Conexao cn in Conexoes) {
                String strConexao = "[@ALIAS]\n" +
                    "Server=@SERVIDOR\n" +
                    "DataSource=@IP\n" +
                    "port=@PORT\n" +
                    "DataBase=@CAMINHO\n" +
                    "username=@USERNAME\n" +
                    "password=@PASSWORD\n\n";

                strConexao = strConexao.Replace("@ALIAS", cn.Alias);
                strConexao = strConexao.Replace("@SERVIDOR", cn.Servidor);
                strConexao = strConexao.Replace("@IP", cn.Ip);
                strConexao = strConexao.Replace("@PORT", cn.Porta.ToString());
                strConexao = strConexao.Replace("@CAMINHO", cn.Caminho);
                strConexao = strConexao.Replace("@USERNAME", cn.UserName);
                strConexao = strConexao.Replace("@PASSWORD", cn.Password);
                registros = registros + strConexao;
            }
            File.WriteAllText(CaminhoBanco, registros);
        }

        public void AtualizaListaConexoes() {
            Conexoes.Clear();
            String[] texto = File.ReadAllLines(CaminhoBanco);
            List<String> q = new List<String>();
            Int32 qtdPropriedades = 7;

            foreach (String linha in texto) {
                String l = linha;
                Int32 index = linha.IndexOf('=') + 1;
                if (linha.Contains('=')) {
                    l = linha.Remove(0, index);
                } else if (linha.Contains("[")) {
                    l = linha.Substring(1, linha.Length - 2);
                }
                q.Add(l);
            }
            while (q.Count > 0) {
                Boolean criarNovaConexao = true;
                q.Remove("");
                while (criarNovaConexao) {
                    Conexao conexao = new Conexao(q[0], q[1], Convert.ToInt32(q[3]), q[2], q[4], q[5], q[6]);
                    q.RemoveRange(0, qtdPropriedades);
                    Conexoes.Add(conexao);
                    criarNovaConexao = false;
                }
            }
        }

        public void ExcluirConexao(Conexao conexao) {
            Conexoes.Remove(conexao);
            EscritaArquivo();
        }

        public String MontaStringConexao(Conexao conexao) {
            String strConexao = "[@ALIAS]; DataSource=@IP; Port=@PORT; DataBase=@CAMINHO; Username=@USERNAME; Password=@PASSWORD";
            strConexao = strConexao.Replace("[@ALIAS]", conexao.Alias);
            strConexao = strConexao.Replace("@IP", conexao.Ip);
            strConexao = strConexao.Replace("@PORT", conexao.Porta.ToString());
            strConexao = strConexao.Replace("@CAMINHO", conexao.Caminho);
            strConexao = strConexao.Replace("@USERNAME", conexao.UserName);
            strConexao = strConexao.Replace("@PASSWORD", conexao.Password);
            return strConexao;
        }

    }

}