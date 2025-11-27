using GestaoDeTarefas.Services.Dtos;

namespace GestaoDeTarefas {

  public partial class FormRegistroTarefa : FormBase {

    private String Titulo {
      get => tbTitulo.Text.Trim();
      init => tbTitulo.Text = value.Trim();
    }

    private String Descricao {
      get => tbDescricao.Text.Trim();
      init => tbDescricao.Text = value.Trim();
    }

    private String Status {
      get => cbSituacao.SelectedItem == null ? "" : (String)cbSituacao.SelectedItem; 
      init => cbSituacao.SelectedItem = value.Trim();
    }

    private ListaDeTarefasDto? ListaSelecionada { get; }

    public TarefaInputDto? Tarefa { get; private set; }

    public FormRegistroTarefa(ListaDeTarefasDto listaSelecionada) {
      InitializeComponent();
      PopulaComboBox();
      ListaSelecionada = listaSelecionada;
    }

    public FormRegistroTarefa(TarefaInputDto? tarefa) {
      InitializeComponent();
      PopulaComboBox();
      Tarefa = tarefa;
      if (Tarefa == null) {
        return;
      }
      Titulo = Tarefa.Titulo;
      Descricao = Tarefa.Descricao;
      Status = Tarefa.Status;
    }

    private void PopulaComboBox() {
      cbSituacao.Items.AddRange(new Object[] { "Pendente", "Andamento", "Concluido" });
    }

    private Boolean ValidaCampos() {
      if (Descricao.Equals("")) {
        MessageBox.Show(@"Informe uma Descrição!");
        return false;
      }
      if (Titulo.Equals("")) {
        MessageBox.Show(@"Informe um título!");
        return false;
      }
      if (Status.Equals("")) {
        MessageBox.Show(@"Informe o Status da Tarefa!");
        return false;
      }
      return true;
    }

    private void Salvar() {
      if (!ValidaCampos()) {
        return;
      }
      if (Tarefa == null) {
        Tarefa = new TarefaInputDto(
          Titulo,
          Descricao,
          Status,
          ListaSelecionada!
        );
      } else {
        Tarefa.Titulo = Titulo;
        Tarefa.Descricao = Descricao;
        Tarefa.Status = Status;
      }
      DialogResult = DialogResult.OK;
    }

    private void Cancelar() {
      DialogResult = DialogResult.Cancel;
    }

    private void btnSalvar_Click(object sender, EventArgs e) {
      Salvar();
    }

    private void btnCancelar_Click(object sender, EventArgs e) {
      Cancelar();
    }

  }

}