using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas
{
    internal class ListasDeTarefasServices {

        private ListaRepositoryFirebird repository => new();

        public String Inserir(CriarListaInput dados) {
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
