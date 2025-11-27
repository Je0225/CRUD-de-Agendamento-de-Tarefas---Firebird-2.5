using GestaoDeTarefas.Domain;
using GestaoDeTarefas.Repository.Contratos;
using GestaoDeTarefas.Services.Dtos;
using GestaoDeTarefas.Services.Dtos.Mappers;

namespace GestaoDeTarefas.Services {

  public class TarefaServices {

    private ITarefaRepositorio repositorio { get; }

    public TarefaServices(ITarefaRepositorio repositorio) {
      this.repositorio = repositorio;
    }

    public String CriaTarefa(TarefaInputDto dados) {
      Int64 id = repositorio.GetNextId();
      Tarefa tarefa = MapperTarefa.MapParaEntity(dados, id);
      return repositorio.Adicionar(tarefa);
    }

    public String Excluir(TarefaInputDto dados) {
      Tarefa tarefa = MapperTarefa.MapParaEntity(dados);
      return repositorio.Excluir(tarefa);
    }

    public String Editar(TarefaInputDto dados) {
      Tarefa tarefa = MapperTarefa.MapParaEntity(dados);
      return repositorio.Editar(tarefa);
    }

    public List<TarefaOutputDto> GetAll() {
      List<Tarefa> tarefas = repositorio.SelectAll();
      return MapperTarefa.MapParaListaDeOutputDtos(tarefas);
    }

    public List<TarefaOutputDto> BuscaTarefasListaSelecionada(ListaDeTarefasDto lista) {
      List<Tarefa> tarefas = repositorio.BuscaTarefasDaLista(lista.Id);
      return MapperTarefa.MapParaListaDeOutputDtos(tarefas);
    }

  }

}