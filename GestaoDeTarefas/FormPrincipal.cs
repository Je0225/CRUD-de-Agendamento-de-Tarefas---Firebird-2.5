using System.Data;

namespace GestaoDeTarefas {

    public partial class FormPrincipal: Form {

        public FormPrincipal() {
            InitializeComponent();
            MontaColunasListView(listView1, DbTableCollumns.collumnsTarefas, DbTableCollumns.tableTarefas);
            PopulaListView(listView1, DbTableCollumns.collumnsTarefas, DbTableCollumns.tableTarefas);
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa();
            frmRegistroTarefa.ShowDialog();
            PopulaListView(listView1, DbTableCollumns.collumnsTarefas, DbTableCollumns.tableTarefas); // firebird geradores
            // criar gerador - chamar gerador - a cada chamada é incrementado uma unidade
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Deseja excluir permanentemente essa(s) tarefa(s)?", "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) {
                FirebirdActions.DbDelete(DbTableCollumns.tableTarefas, (Int32)listView1.SelectedItems[0].Tag);
            }
            PopulaListView(listView1, DbTableCollumns.collumnsTarefas, DbTableCollumns.tableTarefas);
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa((Int32)listView1.SelectedItems[0].Tag);
            frmRegistroTarefa.ShowDialog();
            PopulaListView(listView1, DbTableCollumns.collumnsTarefas, DbTableCollumns.tableTarefas);
        }

        private void MontaColunasListView(ListView lv, String[] collumns, String tableName) {
            for (int i = 0; i < collumns.Length; i++) {
                lv.Columns.Add(new ColumnHeader { DisplayIndex = i, Text = collumns[i] });
            }
            PopulaListView(listView1, DbTableCollumns.collumnsTarefas, DbTableCollumns.tableTarefas);
        }

        private void PopulaListView(ListView lv, String[] collumns, String tableName) {
            lv.Items.Clear();
            DataSet? data = FirebirdActions.DbGenericSelect(tableName);
            if (data is not null) {
                String[] row = new String[collumns.Length];
                for (int i = 0; i < data.Tables[0].Rows.Count; i++) {
                    for (int j = 0; j < collumns.Length; j++) {
                        row[j] = data.Tables[0].Rows[i].Field<Object>(j).ToString();
                    }
                    lv.Items.Add(new ListViewItem(row) { Tag = data.Tables[0].Rows[i].Field<int>(0) });
                }
            }
        }
    }

}