using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas {
    public class ListaDeTarefas : Model{

        public String Nome { get; set; }

        public sealed override String[] GetValues { get; set; }

        public new static String TableName => "listas_tarefas";

        public new static String[] TableColluns => new[] { "id", "nome" };

        public new static String GeneratorName => "gen_id_listas_tarefas";

        public ListaDeTarefas(Int64 id, String nome) {
            Id = id;
            Nome = nome;
            GetValues = new[] { id.ToString(), $"'{Nome}'" };
        }
    }
}
