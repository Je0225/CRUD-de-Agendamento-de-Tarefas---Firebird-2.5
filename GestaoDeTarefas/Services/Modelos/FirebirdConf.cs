namespace GestaoDeTarefas.Services.Modelos {

  public class FirebirdConf {

    public Int32 Edit { get; }

    public ConexaoBanco ConexaoPadrao { get; }

    public List<ConexaoBanco> Conexoes { get; }

    public FirebirdConf(ConexaoBanco conexaoPadrao, Int32 edit, List<ConexaoBanco> conexoes) {
      ConexaoPadrao = conexaoPadrao;
      Edit = edit;
      Conexoes = conexoes;
    }
  }
}
