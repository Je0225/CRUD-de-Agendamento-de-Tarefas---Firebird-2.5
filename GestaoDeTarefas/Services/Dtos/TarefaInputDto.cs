namespace GestaoDeTarefas.Services.Dtos {

  public class TarefaInputDto {

    public Int64 Id { get; }

    public String Titulo { get; set; }

    public String Descricao { get; set; }

    public String Status { get; set; }

    public ListaDeTarefasDto Lista { get; }

    public TarefaInputDto(String titulo, String descricao, String status, ListaDeTarefasDto lista, Int64 id = 0) {
      Titulo = titulo;
      Descricao = descricao;
      Status = status;
      Lista = lista;
      Id = id;
    }

  }

}