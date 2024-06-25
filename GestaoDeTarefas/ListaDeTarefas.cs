using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas {
    public class ListaDeTarefas : Model{

        public String Nome { get; set; }

        public override String[] GetValues { get; set; }

        public ListaDeTarefas(Int64 id, String nome) {
            Id = id;
            Nome = nome;
            GetValues = new[] { id.ToString(), $"'{Nome}'" };
        }
    }
}
