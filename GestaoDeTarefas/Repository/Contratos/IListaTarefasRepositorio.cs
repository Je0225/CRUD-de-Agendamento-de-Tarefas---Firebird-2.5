using GestaoDeTarefas.Domain;

namespace GestaoDeTarefas.Repository.Contratos {

  public interface IListaTarefasRepositorio {

    Int64 GetNextId();

    String Adicionar(ListaDeTarefas lista);

    String Excluir(ListaDeTarefas lista);

    String Editar(ListaDeTarefas lista);

    List<ListaDeTarefas> SelectAll();

  }

}