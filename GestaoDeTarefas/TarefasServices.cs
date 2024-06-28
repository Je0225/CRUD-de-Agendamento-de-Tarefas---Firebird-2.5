namespace GestaoDeTarefas {

    public class TarefasServices {

        private ITarefaRepository repository { get;}

        public TarefasServices(ITarefaRepository repository) {
            this.repository = repository;
        }

        public String CriarTarefa(CriarTarefaInput dados) {
            Int64 id = repository.GetNextId();
            Tarefa tarefa = new Tarefa(id, dados.Titulo, dados.Descricao, dados.Status, dados.lista);
            return repository.Insert(tarefa);
        }

        public String ExcluirTarefa(Tarefa tarefa) {
            return repository.Delete(tarefa);
        }

        public String EditarTarefa(Tarefa tarefa) {
            return repository.Update(tarefa);
        }

        public List<Tarefa> BuscaTodasAsTarefas() {
            return repository.SelectAll();
        }

        public List<Tarefa> BuscaTarefasListaSelecionada(ListaDeTarefas lista) {
            return repository.BuscaTarefasDaLista(lista.Id);
        }
    }
}
