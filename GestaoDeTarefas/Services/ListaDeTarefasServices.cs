using GestaoDeTarefas.Domain;
using GestaoDeTarefas.Repository.Contratos;
using GestaoDeTarefas.Services.Dtos;
using GestaoDeTarefas.Services.Dtos.Mappers;

namespace GestaoDeTarefas.Services {

  public class ListaDeTarefasServices {

    private IListaTarefasRepositorio repositorio { get; }

    public ListaDeTarefasServices(IListaTarefasRepositorio repositorio) {
      this.repositorio = repositorio;
    }

    public String CriaLista(ListaDeTarefasDto listaDto) {
      Int64 id = repositorio.GetNextId();
      ListaDeTarefas lista = MapperLista.MapParaEntity(listaDto, id);
      return repositorio.Adicionar(lista);
    }

    public String Excluir(ListaDeTarefasDto listaDto) {
      ListaDeTarefas lista = MapperLista.MapParaEntity(listaDto);
      return repositorio.Excluir(lista);
    }

    public String Alterar(ListaDeTarefasDto listaDto) {
      ListaDeTarefas lista = MapperLista.MapParaEntity(listaDto);
      return repositorio.Editar(lista);
    }

    public List<ListaDeTarefasDto> GetAll() {
      List<ListaDeTarefas> listas = repositorio.SelectAll();
      return MapperLista.MapParaListaDeOutputDtos(listas);
    }

  }

}