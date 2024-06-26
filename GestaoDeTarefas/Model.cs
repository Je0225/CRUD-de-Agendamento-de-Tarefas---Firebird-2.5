using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas
{
    public abstract class Model{

        public Int64 Id { get; set; }

        public abstract String[] GetValues { get; set; }

        //public static String TableName { get; set; }

        //public static String[] TableColluns { get; set; }

       // public static String GeneratorName { get; set; }
    }
}
