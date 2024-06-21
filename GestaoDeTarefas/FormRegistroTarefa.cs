using System.Data;
using FirebirdSql.Data.FirebirdClient;
using System.Globalization;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace GestaoDeTarefas {

    public partial class FormRegistroTarefa: Form {

        private Int32 ObjectId { get; set; }

        public FormRegistroTarefa(Int32 objectId = -1) {
            InitializeComponent();
            cbSituacao.Items.Add(Status.Andamento);
            cbSituacao.Items.Add(Status.Pendente);
            cbSituacao.Items.Add(Status.concluido);
            ObjectId = objectId;
            if (ObjectId.Equals(-1)) {
                return; 
            }
            DataSet? dados = FirebirdActions.DbSelectWhere(DbTableCollumns.tableTarefas, ObjectId);
            if (dados == null) {
                Close();
            } else {
               tbTitulo.Text = dados.Tables[0].Rows[0].Field<Object>(1).ToString();
               tbDescricao.Text = dados.Tables[0].Rows[0].Field<Object>(2).ToString();
                cbSituacao.Text = dados.Tables[0].Rows[0].Field<Object>(4).ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            Model tarefa = new Tarefa(3, tbTitulo.Text, tbDescricao.Text, DateTime.Now, (Status)cbSituacao.SelectedItem);
            String mensagem = "";
            if (ObjectId.Equals(-1)) {
                mensagem = FirebirdActions.DbInsert(tarefa);
            } else {
                mensagem = FirebirdActions.DbUpdate(tarefa);
            }
            MessageBox.Show(mensagem);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }

}