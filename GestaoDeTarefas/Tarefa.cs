using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas
{
    internal class Tarefa
    {
        public Int32 Id { get; set; }

        public String Titulo { get; set; }

        public String Descricao { get; set; }

        public DateTime Data { get; set; }

        public Enum Status { get; set; }
    }
}
