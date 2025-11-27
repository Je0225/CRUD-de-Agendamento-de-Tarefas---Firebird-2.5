using GestaoDeTarefas.Domain;

namespace GestaoDeTarefas.Repository.Contratos {

  public interface ITarefaRepositorio {

    Int64 GetNextId();

    String Adicionar(Tarefa tarefa);

    String Excluir(Tarefa tarefa);

    String Editar(Tarefa tarefa);

    List<Tarefa> SelectAll();

    List<Tarefa> BuscaTarefasDaLista(Int64 id);

  }

}