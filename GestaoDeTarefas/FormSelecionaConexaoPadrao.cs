using GestaoDeTarefas.Services;
using GestaoDeTarefas.Services.Dtos;

namespace GestaoDeTarefas {

  public partial class FormSelecionaConexaoPadrao : FormBase {

    private readonly FirebirdConfServices fbServices;

    public ConexaoBancoDto? ConexaoSelecionada => lvConexoes.SelectedItems.Count > 0 ?
      (ConexaoBancoDto?)lvConexoes.SelectedItems[0].Tag : null;

    public FormSelecionaConexaoPadrao(FirebirdConfServices services) {
      InitializeComponent();
      fbServices = services;
      PopulaListView();
      AlteraAcessibilidadeBotoes();
    }

    private void Adicionar() {
      FormRegistroConexao formRegistroConexao = new FormRegistroConexao(null);
      formRegistroConexao.ShowDialog();
      if (formRegistroConexao.DialogResult != DialogResult.OK) {
        return;
      }
      fbServices.Adicionar(formRegistroConexao.Conexao!);
      PopulaListView();
    }

    private void Excluir() {
      fbServices.Excluir(ConexaoSelecionada!);
      PopulaListView();
    }

    private void Editar() {
      String alias = ConexaoSelecionada!.Alias;
      FormRegistroConexao frmFormRegistroConexao = new FormRegistroConexao(ConexaoSelecionada);
      frmFormRegistroConexao.ShowDialog();
      if (frmFormRegistroConexao.DialogResult != DialogResult.OK) {
        return;
      }
      fbServices.Editar(ConexaoSelecionada, alias);
      PopulaListView();
    }

    private void PopulaListView() {
      lvConexoes.Items.Clear();
      foreach (ConexaoBancoDto c in fbServices.GetConexoes()) {
        ListViewItem lvItem = lvConexoes.Items.Add(new ListViewItem(new[] { c.Alias }) { Tag = c });
        if (c == fbServices.GetConexaoPadrao()) {
          lvItem.Selected = true;
        }
      }
    }

    private void Confirmar() {
      DialogResult = DialogResult.OK;
      Close();
    }

    private void Cancelar() {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    private void AlteraAcessibilidadeBotoes() {
      Boolean temItemSelecionado = lvConexoes.SelectedItems.Count > 0;
      btnEditar.Enabled = temItemSelecionado;
      btnExcluir.Enabled = temItemSelecionado;
      btnConfirmar.Enabled = temItemSelecionado;
    }

    private void btnAdd_Click(Object sender, EventArgs e) {
      Adicionar();
    }

    private void btnExcluir_Click(Object sender, EventArgs e) {
      Excluir();
    }

    private void btnEditar_Click(Object sender, EventArgs e) {
      Editar();
    }

    private void btnConfirmar_Click(Object sender, EventArgs e) {
      Confirmar();
    }

    private void btnCancelar_Click(Object sender, EventArgs e) {
      Cancelar();
    }

    private void lvConexoes_SelectedIndexChanged(Object sender, EventArgs e) {
      AlteraAcessibilidadeBotoes();
    }
  }

}