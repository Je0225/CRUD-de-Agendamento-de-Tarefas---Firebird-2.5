using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas
{
    public interface ITarefaRepository {

        String Insert(Tarefa tarefa);

        String Delete(Tarefa tarefa);

        String Update(Tarefa tarefa);

        List<Tarefa> SelectAll();

        Int64 GetNextId();

        List<Tarefa> BuscaTarefasDaLista(Int64 id);
    }
}
