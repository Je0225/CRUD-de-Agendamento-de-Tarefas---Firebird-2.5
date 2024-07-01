using GestaoDeTarefas.Domain;

namespace GestaoDeTarefas.Repository {

    public interface IListaTarefasRepository {

        String Insert(ListaDeTarefas lista);

        String Delete(ListaDeTarefas lista);

        String Update(ListaDeTarefas lista);

        List<ListaDeTarefas> SelectAll();

        Int64 GetNextId();

    }

}