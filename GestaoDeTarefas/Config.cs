using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas
{

    public class Config {

        public Conexao DefaultConect { get; set; }

        public Int32 Edit { get; set; }

        public Config(Conexao defaultConect, Int32 edit) {
            DefaultConect = defaultConect;
            Edit = edit;
        }
    }
}
