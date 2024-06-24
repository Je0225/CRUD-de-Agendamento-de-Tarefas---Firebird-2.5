using System.Data;
using FirebirdSql.Data.FirebirdClient;
using System.Globalization;
using System.Linq.Expressions;
using System.Windows.Forms;
using static GestaoDeTarefas.StatusTarefas;
using static GestaoDeTarefas.DbMapeamento;

namespace GestaoDeTarefas {

    public partial class FormRegistroTarefa: Form{

        private readonly DbComandos transacoes = new DbComandos(tabelaTarefas, colunasTarefas, GENERATOR_TAREFAS);
        private Int64 ObjectId { get; set; }

        public FormRegistroTarefa(Int64 objectId = -1) {
            InitializeComponent();
            ObjectId = objectId;
            cbSituacao.Items.AddRange(Status);
            if (ObjectId.Equals(-1)) {
                return; 
            }
            DataSet? dados = transacoes.DbSelectWhere(ObjectId);
            tbTitulo.Text = dados.Tables[0].Rows[0].Field<Object>(1)?.ToString();
            tbDescricao.Text = dados.Tables[0].Rows[0].Field<Object>(2)?.ToString();
            cbSituacao.Text = dados.Tables[0].Rows[0].Field<Object>(4)?.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            // to do:validação dos campos
            Tarefa tarefa;
            String mensagem;
            if (ObjectId.Equals(-1)) {
                ObjectId = transacoes.DbSelectGeneratorId();
                tarefa = new Tarefa(ObjectId, tbTitulo.Text, tbDescricao.Text, DateTime.Now, (String)cbSituacao.SelectedItem);
                mensagem = transacoes.DbInsert(tarefa);
            } else {
                tarefa = new Tarefa(ObjectId, tbTitulo.Text, tbDescricao.Text, DateTime.Now, (String)cbSituacao.SelectedItem);
                mensagem = transacoes.DbUpdate(tarefa);
            }
            MessageBox.Show(mensagem);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }

}