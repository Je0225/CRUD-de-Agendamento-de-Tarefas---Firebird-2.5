using GestaoDeTarefas.Domain;

namespace GestaoDeTarefas.Service {

    public class CriarTarefaInputDto {

        public String Titulo { get; set; }

        public String Descricao { get; set; }

        public String Status { get; set; }

        public ListaDeTarefas lista { get; set; }

    }

}