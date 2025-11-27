namespace GestaoDeTarefas.Services.Modelos {

  public class ConexaoBanco {

    public Int32 Porta { get; }

    public String Alias { get; }

    public String Ip { get; }

    public String Caminho { get; }

    public String Usuario { get; }

    public String Senha { get; }

    public ConexaoBanco(String alias, Int32 porta, String ip, String caminho, String usuario, String senha) {
      Alias = alias;
      Porta = porta;
      Ip = ip;
      Caminho = caminho;
      Usuario = usuario.ToUpper();
      Senha = senha;
    }

  }

}