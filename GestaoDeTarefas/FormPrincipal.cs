using System.Data;

namespace GestaoDeTarefas {

    public partial class FormPrincipal: Form {

        public FormPrincipal() {
            InitializeComponent();
            PopulaListView(listView1, DbTableCollumns.collumnsTarefas, DbTableCollumns.tableTarefas);
        }

        private void PopulaListView(ListView lv, String[] collumns, String tableName) {
            DataSet? data = FirebirdActions.DbGenericSelect(tableName);
            for (int i = 0; i < collumns.Length; i++) {
                lv.Columns.Add(new ColumnHeader { DisplayIndex = i, Text = collumns[i] });
            }
            if (data is not null) {
                for (int i = 0; i < data.Tables[0].Rows.Count; i++) {
                    for(int j = 1; j < collumns.Length; j++) {
                        lv.Items.Add(new ListViewItem(new[] { data.Tables[0].Rows[i].Field<String>(j) })); //Arrumar 
                    }
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa(null);
            frmRegistroTarefa.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Deseja excluir permanentemente essa(s) tarefa(s)?", "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) {
                //FirebirdActions.DbDelete(listView1.SelectedItems[0].Tag as Model);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa(listView1.SelectedItems[0].Tag as Model);
            frmRegistroTarefa.ShowDialog();
        }

    }

}