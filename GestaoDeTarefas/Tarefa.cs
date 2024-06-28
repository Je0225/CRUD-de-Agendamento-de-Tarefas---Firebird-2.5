using System.Globalization;

namespace GestaoDeTarefas {

    public class Tarefa{

        public Int64 Id { get; set; }

        public String Titulo { get; set; }

        public String Descricao { get; set; }

        public DateTime Data { get; set; }

        public String Status { get; set; }

        public ListaDeTarefas Lista { get; set; }

        public Tarefa(Int64 id, string titulo, string descricao, String status, ListaDeTarefas lista) {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Data = DateTime.Now;
            Status = status;
            Lista = lista;
        }
    }
}