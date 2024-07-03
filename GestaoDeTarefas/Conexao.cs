namespace GestaoDeTarefas {

    public class Conexao {

        public String Alias { get; set; }

        public String Servidor { get; set; }

        public Int32 Porta { get; set; }

        public String Ip { get; set; }

        public String Caminho { get; set; }

        public String UserName { get; set; }

        public String Password { get; set; }

        public Conexao(String alias, String servidor, Int32 porta, String ip, String caminho, String userName, String password) {
            Alias = alias;
            Servidor = servidor;
            Porta = porta;
            Ip = ip;
            Caminho = caminho;
            UserName = userName;
            Password = password;
        }

    }

}