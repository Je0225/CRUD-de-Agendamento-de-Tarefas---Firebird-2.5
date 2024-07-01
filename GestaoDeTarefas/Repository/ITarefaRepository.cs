using GestaoDeTarefas.Domain;

namespace GestaoDeTarefas.Repository {

    public interface ITarefaRepository {

        String Insert(Tarefa tarefa);

        String Delete(Tarefa tarefa);

        String Update(Tarefa tarefa);

        List<Tarefa> SelectAll();

        Int64 GetNextId();

        List<Tarefa> BuscaTarefasDaLista(Int64 id);

    }

}