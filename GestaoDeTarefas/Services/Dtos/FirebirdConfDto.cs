namespace GestaoDeTarefas.Services.Dtos {

  public class FirebirdConfDto {

    public Int32 Edit { get; }

    public ConexaoBancoDto ConexaoPadrao { get; }

    public List<ConexaoBancoDto> Conexoes { get; }

    public FirebirdConfDto(ConexaoBancoDto conexaoPadrao, Int32 edit, List<ConexaoBancoDto> conexoes) {
      ConexaoPadrao = conexaoPadrao;
      Edit = edit;
      Conexoes = conexoes;
    }

  }
}
