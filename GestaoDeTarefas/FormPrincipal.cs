using GestaoDeTarefas.Services;
using GestaoDeTarefas.Services.Dtos;
using GestaoDeTarefas.Services.Dtos.Mappers;

namespace GestaoDeTarefas {

  public partial class FormPrincipal : FormBase {

    private TarefaServices serviceTarefa { get; }

    private ListaDeTarefasServices serviceLista { get; }

    private Boolean TemTarefaSelecionada => lvTarefas.SelectedItems.Count > 0;

    private Boolean TemListaSelecionada => lvListasTarefas.SelectedItems.Count > 0;

    private ListaDeTarefasDto ListaSelecionada => (ListaDeTarefasDto)lvListasTarefas.SelectedItems[0].Tag;

    private TarefaOutputDto TarefaSelecionada => (TarefaOutputDto)lvTarefas.SelectedItems[0].Tag;

    public FormPrincipal(TarefaServices serviceTarefa, ListaDeTarefasServices serviceLista) {
      InitializeComponent();
      this.serviceTarefa = serviceTarefa;
      this.serviceLista = serviceLista;
      PopulaListViewListas();
      if (TemListaSelecionada) {
        PopulaListViewTarefas(serviceTarefa.BuscaTarefasListaSelecionada(ListaSelecionada));
      }
    }

    private void AdicionarTarefa() {
      if (!TemListaSelecionada) {
        MessageBox.Show(@"Selecione uma lista para adicionar uma tarefa!");
        return;
      }
      FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa(ListaSelecionada);
      frmRegistroTarefa.ShowDialog();
      if (frmRegistroTarefa.DialogResult != DialogResult.OK) {
        return;
      }
      String result = serviceTarefa.CriaTarefa(frmRegistroTarefa.Tarefa!);
      MessageBox.Show(result);
      PopulaListViewTarefas(serviceTarefa.BuscaTarefasListaSelecionada(ListaSelecionada));
    }

    private void EditarTarefa() {
      if (!TemTarefaSelecionada) {
        MessageBox.Show(@"Selecione uma tarefa da lista para editar!");
        return;
      }
      TarefaInputDto tarefaDto = MapperTarefa.OutputParaInputDto(TarefaSelecionada);
      FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa(tarefaDto);
      frmRegistroTarefa.ShowDialog();
      if (frmRegistroTarefa.DialogResult != DialogResult.OK) {
        return;
      }
      String result = serviceTarefa.Editar(frmRegistroTarefa.Tarefa!);
      MessageBox.Show(result);
      PopulaListViewTarefas(serviceTarefa.BuscaTarefasListaSelecionada(ListaSelecionada));
    }

    private void ExcluirTarefa() {
      if (!TemTarefaSelecionada) {
        MessageBox.Show(@"Selecione uma tarefa da lista para excluir!");
        return;
      }
      DialogResult result = MessageBox.Show(
        @"Deseja excluir a tarefa permanentemente?",
        @"Aviso!",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1
        );
      if (result != DialogResult.OK) {
        return;
      }
      TarefaInputDto tarefaDto = MapperTarefa.OutputParaInputDto(TarefaSelecionada);
      MessageBox.Show(serviceTarefa.Excluir(tarefaDto));
      PopulaListViewTarefas(serviceTarefa.BuscaTarefasListaSelecionada(ListaSelecionada));
    }

    private void AdicionarLista() {
      FormRegistroLista frmRegistroLista = new FormRegistroLista();
      frmRegistroLista.ShowDialog();
      PopulaListViewListas();
    }

    private void ExcluirLista() {
      if (!TemListaSelecionada) {
        MessageBox.Show(@"Selecione uma lista de tarefas da lista para excluir!");
        return;
      }
      DialogResult result = MessageBox.Show(
        @"Deseja excluir a lista permanentemente? Todas as tarefas desta lista também serão excluídas", 
        @"Aviso!", 
        MessageBoxButtons.OKCancel, 
        MessageBoxIcon.Warning, 
        MessageBoxDefaultButton.Button1
        );
      if (result == DialogResult.OK) {
        MessageBox.Show(serviceLista.Excluir(ListaSelecionada));
      }
      PopulaListViewListas();
    }

    private void EditarLista() {
      if (!TemListaSelecionada) {
        MessageBox.Show(@"Selecione uma lista para editar!");
        return;
      }
      FormRegistroLista frmRegistroLista = new FormRegistroLista(ListaSelecionada);
      frmRegistroLista.ShowDialog();
      PopulaListViewListas();
    }

    private void PopulaLvComTarefasDaListaSelecionada() {
      if (TemListaSelecionada) {
        PopulaListViewTarefas(serviceTarefa.BuscaTarefasListaSelecionada(ListaSelecionada));
      }
    }

    private void PopulaListViewTarefas(List<TarefaOutputDto> dtos) {
      lvTarefas.Items.Clear();
      foreach (TarefaOutputDto tarefa in dtos) {
        ListViewItem item = new(new[] {
          tarefa.Id.ToString(),
          tarefa.Titulo,
          tarefa.Descricao,
          tarefa.Data,
          tarefa.Status,
          tarefa.Lista.Nome
        }) {
          Tag = tarefa
        };
        if (tarefa.Status == "Concluido") {
          item.BackColor = Color.PaleGreen;
        } else if (tarefa.Status == "Pendente") {
          item.BackColor = Color.LightCoral;
        }
        lvTarefas.Items.Add(item);
      }
    }

    private void PopulaListViewListas() {
      lvListasTarefas.Items.Clear();
      List<ListaDeTarefasDto> listas = serviceLista.GetAll();
      foreach (ListaDeTarefasDto lista in listas) {
        lvListasTarefas.Items.Add(new ListViewItem(new[] { lista.Id.ToString(), lista.Nome }) { Tag = lista });
      }
    }

    private void btnAdicionar_Click(Object sender, EventArgs e) {
      AdicionarTarefa();
    }

    private void btnExcluir_Click(Object sender, EventArgs e) {
      ExcluirTarefa();
    }

    private void btnEditar_Click(Object sender, EventArgs e) {
      EditarTarefa();
    }

    private void btnAddLista_Click(Object sender, EventArgs e) {
      AdicionarLista();
    }

    private void btnExcluirLista_Click(Object sender, EventArgs e) {
      ExcluirLista();
    }

    private void btnEditaLista_Click(Object sender, EventArgs e) {
      EditarLista();
    }

    private void lvListasTarefas_SelectedIndexChanged(Object sender, EventArgs e) {
      PopulaLvComTarefasDaListaSelecionada();
    }

    private void ListaTodasTarefas_Click(Object sender, EventArgs e) {
      PopulaListViewTarefas(serviceTarefa.GetAll());
    }

  }

}