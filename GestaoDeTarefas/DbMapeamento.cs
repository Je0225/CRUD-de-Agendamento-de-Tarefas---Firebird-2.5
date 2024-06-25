using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas {
    public static class DbMapeamento {

        // TAREFAS
        public static readonly String TabelaTarefas = "tarefas";
        public static readonly String[] ColunasTarefas = new[] { "id", "titulo", "descricao", "data", "status", "lista"};
        public static readonly String GeneratorTarefas = "gen_id_tarefas";

        // LISTAS_TAREFAS
        public static readonly String TabelaListasTarefas = "listas_tarefas";
        public static readonly String[] ColunasListasTarefas = new[] { "id", "nome" };
        public static readonly String GeneratorListasTarefas = "gen_id_listas_tarefas";
    }
}
