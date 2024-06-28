using FirebirdSql.Data.FirebirdClient;

namespace GestaoDeTarefas {

    public partial class FormPrincipal: Form {

        private Boolean TemListaSelecionada => lvListasTarefas.SelectedItems.Count > 0;

        private ListaDeTarefas ListaSelecionada => (ListaDeTarefas)lvListasTarefas.SelectedItems[0].Tag;

        private TarefasServices service { get; }

        public FormPrincipal() {
            lvListasTarefas.Tag = typeof(ListaDeTarefas);
            lvTarefas.Tag = typeof(Tarefa);
            InitializeComponent();
            service = new TarefasServices(new TarefaRepositoryFirebird(ConexaoFirebird.conexao));
            PopulaLVListas();
            if (TemListaSelecionada) {
                PopulaListViewTarefas();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            if (!TemListaSelecionada) {
                MessageBox.Show(@"Selecione uma lista de tarefas para adicionar uma tarefa!");
                return;
            }
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa(ListaSelecionada, null);
            frmRegistroTarefa.ShowDialog();
            PopulaListViewTarefas();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (TemListaSelecionada) {
                MessageBox.Show(@"Selecione uma tarefa da lista para excluir!");
                return;
            }
            DialogResult result = MessageBox.Show(@"Deseja excluir a tarefa permanentemente?", @"Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) {
                MessageBox.Show(service.ExcluirTarefa((Tarefa)lvTarefas.SelectedItems[0].Tag));
                PopulaListViewTarefas();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (lvTarefas.SelectedItems.Count.Equals(0)) {
                MessageBox.Show(@"Selecione uma tarefa da lista para editar!");
                return;
            }
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa(ListaSelecionada, (Tarefa)lvTarefas.SelectedItems[0].Tag);
            frmRegistroTarefa.ShowDialog();
            PopulaListViewTarefas();
        }

        private void btnAddLista_Click(object sender, EventArgs e) {
            FormRegistroLista frmRegistroLista = new FormRegistroLista();
            frmRegistroLista.ShowDialog();
            PopulaLVListas();
        }

        private void btnExcluirLista_Click(object sender, EventArgs e) {
            if (lvListasTarefas.SelectedItems.Count.Equals(0)) {
                MessageBox.Show(@"Selecione uma lista de tarefas da lista para excluir!");
                return;
            }
            DialogResult result = MessageBox.Show(@"Deseja excluir a lista permanentemente? Todas as tarefas desta lista também serão excluídas", @"Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) {
                //MessageBox.Show(TransacoesListas.DbDelete((Model)lvListasTarefas.SelectedItems[0].Tag));
                //PopulaListView(lvListasTarefas, TransacoesListas, TransacoesTarefas);
                //PopulaListView(lvTarefas, TransacoesListas, TransacoesTarefas);
            }
            PopulaLVListas();
            PopulaListViewTarefas();
        }

        private void btnEditaLista_Click(object sender, EventArgs e) {
            if (lvListasTarefas.SelectedItems.Count.Equals(0)) {
                MessageBox.Show(@"Selecione uma lista para editar!");
                return;
            }
            FormRegistroLista frmRegistroLista = new FormRegistroLista(ListaSelecionada);
            frmRegistroLista.ShowDialog();
            PopulaLVListas();
            PopulaListViewTarefas();
        }

        private void lvListasTarefas_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvListasTarefas.SelectedItems.Count > 0) {
                PopulaListViewTarefas();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            PopulaListViewTarefas();
        }

        private void PopulaListViewTarefas() {
            //passar como parametro a lista
            lvListasTarefas.Items.Clear();
            List<Tarefa> tarefas = service.BuscaTarefasListaSelecionada(ListaSelecionada);
            if (lvListasTarefas.Tag == typeof(Tarefa) && tarefas != null) {
                foreach (Tarefa t in tarefas) {
                    lvListasTarefas.Items.Add(new ListViewItem(new[] { t.Id.ToString(), t.Titulo, t.Descricao, t.Data.ToString("d"), t.Status, t.Lista.Nome }) { Tag = t });
                }
            }
        }

        private void PopulaLVListas() {

        }
    }
}