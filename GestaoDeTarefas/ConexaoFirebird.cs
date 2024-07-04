using FirebirdSql.Data.FirebirdClient;

namespace GestaoDeTarefas.Repository {

    public static class ConexaoFirebird {

        private static FbConnection conexao;

        public static FbConnection getConnetion(Conexao conexao) {
            if (ConexaoFirebird.conexao == null) {
                ConexaoFirebird.conexao = new FbConnection(GetStringConexao(conexao));
            }
            return ConexaoFirebird.conexao;
        }

        private static String GetStringConexao(Conexao conexao) {
            String strConexao = $"Alias={conexao.Alias};" +
                $"DataSource{conexao.Ip}; " +
                $"Port={conexao.Porta}; " +
                $"DataBase={conexao.Caminho}; " +
                $"Username={conexao.UserName}; " +
                $"Password={conexao.Password}";
            return strConexao;
        }

    }

}