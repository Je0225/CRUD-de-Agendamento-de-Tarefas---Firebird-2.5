using GestaoDeTarefas.Domain;

namespace GestaoDeTarefas.Services.Dtos.Mappers {
  public static class MapperTarefa {

    public static Tarefa MapParaEntity(TarefaInputDto tarefaDto, Int64 novoId = 0) {
      return new Tarefa(
        novoId > 0 ? novoId : tarefaDto.Id,
        tarefaDto.Titulo,
        tarefaDto.Descricao,
        tarefaDto.Status,
        MapperLista.MapParaEntity(tarefaDto.Lista)
      );
    }

    public static TarefaInputDto MapParaInputDto(Tarefa tarefa) {
      return new TarefaInputDto(
        tarefa.Titulo,
        tarefa.Descricao,
        tarefa.Status,
        MapperLista.MapParaDto(tarefa.Lista),
        tarefa.Id);
    }

    public static TarefaInputDto OutputParaInputDto(TarefaOutputDto outputDto) {
      return new TarefaInputDto(
        outputDto.Titulo,
        outputDto.Descricao,
        outputDto.Status,
        outputDto.Lista,
        outputDto.Id);
    }

    public static List<TarefaOutputDto> MapParaListaDeOutputDtos(List<Tarefa> tarefas) {
      List<TarefaOutputDto> dtos = new List<TarefaOutputDto>();
      foreach (Tarefa tarefa in tarefas) {
        dtos.Add(MapperTarefa.MapParaOutputDto(tarefa));
      }
      return dtos;
    }

    private static TarefaOutputDto MapParaOutputDto(Tarefa tarefa) {
      return new TarefaOutputDto(
        tarefa.Id,
        tarefa.Titulo,
        tarefa.Descricao,
        tarefa.Data.ToShortDateString(),
        tarefa.Status,
        MapperLista.MapParaDto(tarefa.Lista)
      );
    }

  }

}
