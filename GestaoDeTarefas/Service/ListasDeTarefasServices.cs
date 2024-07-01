using GestaoDeTarefas.Domain;
using GestaoDeTarefas.Repository;

namespace GestaoDeTarefas.Service {

    public class ListasDeTarefasServices {

        private IListaTarefasRepository repository { get; }

        public ListasDeTarefasServices(IListaTarefasRepository repository) {
            this.repository = repository;
        }

        public String Inserir(CriarListaInputDto dados) {
            Int64 id = repository.GetNextId();
            ListaDeTarefas lista = new ListaDeTarefas(id, dados.Nome);
            return repository.Insert(lista);
        }

        public String Excluir(ListaDeTarefas lista) {
            return repository.Delete(lista);
        }

        public String Alterar(ListaDeTarefas lista) {
            return repository.Update(lista);
        }

        public List<ListaDeTarefas> BuscaListas() {
            return repository.SelectAll();
        }

    }

}