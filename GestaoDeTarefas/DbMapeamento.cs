using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas {
    public static class DbMapeamento {

        public static readonly String tabelaTarefas = "tarefas";
        public static readonly String[] colunasTarefas = new[] { "id", "titulo", "descricao", "data", "status" };
        public const String GENERATOR_TAREFAS = "gen_id_tarefas";

    }
}
