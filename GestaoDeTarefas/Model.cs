using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas
{
    public abstract class Model {

        public Int32 Id { get; set; }

        public abstract String TableName { get; set; }

        public abstract String[] GetValues { get; set; }

        public abstract String[] DbCollumns { get; set; }
    }
}
