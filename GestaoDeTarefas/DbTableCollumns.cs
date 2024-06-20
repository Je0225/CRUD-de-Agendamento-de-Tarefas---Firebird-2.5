using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas
{
    public static class DbTableCollumns {

        public static readonly String tableTarefas = "tarefas";
        public static readonly String[] collumnsTarefas = new[] { "id", "titulo", "descricao", "data", "status" };
    }
}
