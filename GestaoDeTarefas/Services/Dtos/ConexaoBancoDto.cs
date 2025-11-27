namespace GestaoDeTarefas.Services.Dtos {
  public class ConexaoBancoDto {

    public Int32 Porta { get; set; }

    public String Alias { get; set; }

    public String Ip { get; set; }

    public String Caminho { get; set; }

    public String Usuario { get; set; }

    public String Senha { get; set; }

    public ConexaoBancoDto(String alias, Int32 porta, String ip, String caminho, String usuario, String senha) {
      Alias = alias;
      Porta = porta;
      Ip = ip;
      Caminho = caminho;
      Usuario = usuario.ToUpper();
      Senha = senha;
    }

    public override string ToString() {
      return $"Alias={Alias};" +
        $"DataSource={Ip}; " +
        $"Port={Porta}; " +
        $"DataBase={Caminho}; " +
        $"Username={Usuario}; " +
        $"Password={Senha}";
    }

  }
}
