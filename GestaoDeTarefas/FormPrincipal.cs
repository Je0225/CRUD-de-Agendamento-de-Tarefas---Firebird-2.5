using static GestaoDeTarefas.DbMapeamento;
using static GestaoDeTarefas.ListViewSources;

namespace GestaoDeTarefas {

    public partial class FormPrincipal: Form {

        private readonly DbComandos transacoesTarefas = new(TabelaTarefas, ColunasTarefas, GeneratorTarefas);
        private readonly DbComandos transacoesListas = new(TabelaListasTarefas, ColunasListasTarefas, GeneratorListasTarefas);

        public FormPrincipal() {
            InitializeComponent();
            MontaColunasListView(lvTarefas, ColunasTarefas);
            PopulaListView(lvTarefas);
            MontaColunasListView(lvListasTarefas, ColunasListasTarefas);
            PopulaListView(lvListasTarefas);
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa();
            frmRegistroTarefa.ShowDialog();
            PopulaListView(lvTarefas);
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (lvTarefas.SelectedItems.Count.Equals(0)) {
                MessageBox.Show(@"Selecione uma tarefa da lista para excluir!");
                return;
            }
            DialogResult result = MessageBox.Show(@"Deseja excluir a tarefa permanentemente?", @"Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) {
                MessageBox.Show(transacoesTarefas.DbDelete((Model)lvTarefas.SelectedItems[0].Tag));
                PopulaListView(lvTarefas);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (lvTarefas.SelectedItems.Count.Equals(0)) {
                MessageBox.Show(@"Selecione uma tarefa da lista para editar!");
                return;
            }
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa((Tarefa)lvTarefas.SelectedItems[0].Tag);
            frmRegistroTarefa.ShowDialog();
            PopulaListView(lvTarefas);
        }

        private void btnAddLista_Click(object sender, EventArgs e) {
            FormRegistroLista frmRegistroLista = new FormRegistroLista();
            frmRegistroLista.ShowDialog();
            PopulaListView(lvListasTarefas);
            PopulaListView(lvTarefas);
        }

        private void btnExcluirLista_Click(object sender, EventArgs e) {
            if (lvListasTarefas.SelectedItems.Count.Equals(0)) {
                MessageBox.Show(@"Selecione uma lista de tarefas da lista para excluir!");
                return;
            }
            DialogResult result = MessageBox.Show(@"Deseja excluir a lista permanentemente? Todas as tarefas desta lista também serão excluídas", @"Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) {
                MessageBox.Show(transacoesListas.DbDelete((Model)lvListasTarefas.SelectedItems[0].Tag));
                PopulaListView(lvListasTarefas);
                PopulaListView(lvTarefas);
            }
        }

        private void btnEditaLista_Click(object sender, EventArgs e) {
            FormRegistroLista frmRegistroLista = new FormRegistroLista((ListaDeTarefas)lvListasTarefas.SelectedItems[0].Tag);
            frmRegistroLista.ShowDialog();
            PopulaListView(lvListasTarefas);
            PopulaListView(lvTarefas);

        }

        private void lvListasTarefas_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvListasTarefas.SelectedItems.Count > 0) {
                ListaDeTarefas l = (ListaDeTarefas)lvListasTarefas.SelectedItems[0].Tag;
                TarefasDaListaSelecionada(lvTarefas, l);
            }
        }

    }

}