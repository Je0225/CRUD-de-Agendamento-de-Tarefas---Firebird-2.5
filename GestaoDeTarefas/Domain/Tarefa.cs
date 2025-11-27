namespace GestaoDeTarefas.Domain {

  public class Tarefa {

    public Int64 Id { get; }

    public String Titulo { get; set; }

    public String Descricao { get; set; }

    public DateTime Data { get; }

    public String Status { get; set; }

    public ListaDeTarefas Lista { get; }

    public Tarefa(Int64 id, String titulo, String descricao, String status, ListaDeTarefas lista) {
      Id = id;
      Titulo = titulo;
      Descricao = descricao;
      Data = DateTime.Now;
      Status = status;
      Lista = lista;
    }

  }

}