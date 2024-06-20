using FirebirdSql.Data.FirebirdClient;
using System.Globalization;
using System.Linq.Expressions;

namespace GestaoDeTarefas {

    public partial class FormRegistroTarefa: Form {

        private Model Tarefa { get; set; }

        public FormRegistroTarefa(Model? tarefa) {
            InitializeComponent();
            cbSituacao.Items.Add(Status.Andamento);
            cbSituacao.Items.Add(Status.Pendente);
            cbSituacao.Items.Add(Status.concluido);
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            Tarefa = new Tarefa(3, tbTitulo.Text, tbDescricao.Text, DateTime.Now, (Status)cbSituacao.SelectedItem );
            String mensagem = FirebirdActions.DbInsert(Tarefa);
            DialogResult = DialogResult.OK;
            MessageBox.Show(mensagem);
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }

}