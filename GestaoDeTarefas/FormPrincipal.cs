using System.Data;
using static GestaoDeTarefas.DbMapeamento;

namespace GestaoDeTarefas {

    public partial class FormPrincipal: Form {

        private readonly DbComandos transacoesTarefas = new(tabelaTarefas, colunasTarefas, GENERATOR_TAREFAS);

        public FormPrincipal() {
            InitializeComponent();
            MontaColunasListView(lvTarefas, colunasTarefas);
            PopulaListView(lvTarefas, colunasTarefas, tabelaTarefas);
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa();
            frmRegistroTarefa.ShowDialog();
            PopulaListView(lvTarefas, colunasTarefas, tabelaTarefas);
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (lvTarefas.SelectedItems.Count.Equals(0)) {
                MessageBox.Show(@"Selecione uma tarefa da lista para excluir!");
                return;
            }
            DialogResult result = MessageBox.Show(@"Deseja excluir a tarefa permanentemente?", @"Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) {
                MessageBox.Show(transacoesTarefas.DbDelete((Int32)lvTarefas.SelectedItems[0].Tag));
                PopulaListView(lvTarefas, colunasTarefas, tabelaTarefas);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (lvTarefas.SelectedItems.Count.Equals(0)) {
                MessageBox.Show(@"Selecione uma tarefa da lista para editar!");
                return;
            }
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa((Int32)lvTarefas.SelectedItems[0].Tag);
            frmRegistroTarefa.ShowDialog();
            PopulaListView(lvTarefas, colunasTarefas, tabelaTarefas);
        }

        private void MontaColunasListView(ListView lv, String[] collumns) {
            for (int i = 0; i < collumns.Length; i++) {
                lv.Columns.Add(new ColumnHeader { DisplayIndex = i, Text = collumns[i] });
            }
            PopulaListView(lvTarefas, colunasTarefas, tabelaTarefas);
        }

        private void PopulaListView(ListView lv, String[] collumns, String tableName) {
            lv.Items.Clear();
            DataSet? data = transacoesTarefas.DbGenericSelect();
            if (data is null) {
                return;
            }
            String[] linha = new String[collumns.Length];
            for (int i = 0; i < data.Tables[0].Rows.Count; i++) {
                for (int j = 0; j < collumns.Length; j++) {
                    linha[j] = data.Tables[0].Rows[i].Field<Object>(j).ToString();
                }
                lv.Items.Add(new ListViewItem(linha) { Tag = data.Tables[0].Rows[i].Field<int>(0) });
            }
        }
    }
}