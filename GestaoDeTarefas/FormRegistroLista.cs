using GestaoDeTarefas.Services.Dtos;

namespace GestaoDeTarefas {
  public partial class FormRegistroLista : FormBase {

    private String Nome {
      get => tbNome.Text.Trim();
      init => tbNome.Text = value.Trim();
    }

    private ListaDeTarefasDto? Lista { get; set; }

    public FormRegistroLista(ListaDeTarefasDto? lista = null) {
      InitializeComponent();
      Lista = lista;
      if (Lista != null) {
        Nome = Lista.Nome;
      }
    }

    private void Salvar() {
      if (Nome.Equals("")) {
        MessageBox.Show(@"Informe o nome da lista!");
        return;
      }
      if (Lista == null) {
        Lista = new ListaDeTarefasDto(Nome);
      } else {
        Lista.Nome = Nome;
      }
      DialogResult = DialogResult.OK;
    }

    private void Cancelar() {
      DialogResult = DialogResult.Cancel;
    }

    private void FocaNoBotaoSalvar(KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        btnSalvar.Focus();
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e) {
      Salvar();
    }

    private void btnCancelar_Click(object sender, EventArgs e) {
      Cancelar();
    }

    private void tbNome_KeyDown(object sender, KeyEventArgs e) {
      FocaNoBotaoSalvar(e);
    }
  }

}