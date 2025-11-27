namespace GestaoDeTarefas.Services.Dtos {

  public class TarefaOutputDto {

    public Int64 Id { get; }

    public String Titulo { get; }

    public String Descricao { get; }

    public String Data { get; }

    public String Status { get; }

    public ListaDeTarefasDto Lista { get; }

    public TarefaOutputDto(Int64 id, String titulo, String descricao, String data, String status, ListaDeTarefasDto lista) {
      Id = id;
      Titulo = titulo;
      Descricao = descricao;
      Data = data;
      Status = status;
      Lista = lista;
    }

  }
}
