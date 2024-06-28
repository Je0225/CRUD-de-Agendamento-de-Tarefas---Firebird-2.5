using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas
{
    internal interface IListaTarefasRepository {
        String Insert(ListaDeTarefas lista);

        String Delete(ListaDeTarefas lista);

        String Update(ListaDeTarefas lista);

        List<ListaDeTarefas> SelectAll();

        Int64 GetNextId();
    }
}
