namespace GestaoDeTarefas.Services.Dtos {

  public class ListaDeTarefasDto {

    public Int64 Id { get; }

    public String Nome { get; set; }

    public ListaDeTarefasDto(String nome, Int64 id = 0) {
      Nome = nome;
      Id = id;
    }

  }

}