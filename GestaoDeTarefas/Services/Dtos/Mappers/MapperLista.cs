using GestaoDeTarefas.Domain;

namespace GestaoDeTarefas.Services.Dtos.Mappers {
  public static class MapperLista {

    public static ListaDeTarefas MapParaEntity(ListaDeTarefasDto listaDeTarefasDto, Int64 novoId = 0) {
      return new ListaDeTarefas(
        novoId > 0 ? novoId : listaDeTarefasDto.Id,
        listaDeTarefasDto.Nome
      );
    }

    public static ListaDeTarefasDto MapParaDto(ListaDeTarefas lista) {
      return new ListaDeTarefasDto( lista.Nome, lista.Id);
    }

    public static List<ListaDeTarefasDto> MapParaListaDeOutputDtos(List<ListaDeTarefas> listas) {
      List<ListaDeTarefasDto> dtos = new List<ListaDeTarefasDto>();
      foreach (ListaDeTarefas lista in listas) {
        dtos.Add(MapperLista.MapParaDto(lista));
      }
      return dtos;
    }

  }
}
