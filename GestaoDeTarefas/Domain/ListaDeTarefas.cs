namespace GestaoDeTarefas.Domain {

  public class ListaDeTarefas {

    public Int64 Id { get; }

    public String Nome { get; set; }

    public ListaDeTarefas(Int64 id, String nome) {
      Id = id;
      Nome = nome;
    }
  }
}