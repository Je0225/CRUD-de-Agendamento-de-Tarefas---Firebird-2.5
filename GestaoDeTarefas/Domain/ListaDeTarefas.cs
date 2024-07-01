namespace GestaoDeTarefas.Domain {

    public class ListaDeTarefas {

        public Int64 Id { get; set; }

        public String Nome { get; set; }

        public static String TableName => "listas_tarefas";

        public static String[] TableColluns => new[] { "id", "nome" };

        public static String GeneratorName => "gen_id_listas_tarefas";

        public ListaDeTarefas(Int64 id, String nome) {
            Id = id;
            Nome = nome;
        }
    }
}