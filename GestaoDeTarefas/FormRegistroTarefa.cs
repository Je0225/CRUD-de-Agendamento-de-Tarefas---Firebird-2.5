using GestaoDeTarefas.Domain;
using GestaoDeTarefas.Service;

namespace GestaoDeTarefas
{

    public partial class FormRegistroTarefa : Form
    {

        private ListaDeTarefas ListaSelecionada { get; set; }

        private Tarefa? Tarefa { get; set; }

        private TarefasServices services { get; set; }

        public FormRegistroTarefa(TarefasServices services, ListaDeTarefas listaSelecionada, Tarefa? tarefa)
        {
            InitializeComponent();
            this.services = services;
            Tarefa = tarefa;
            ListaSelecionada = listaSelecionada;
            cbSituacao.Items.AddRange(new[] { "Pendente", "Andamento", "Concluido" });
            if (Tarefa == null)
            {
                return;
            }
            tbTitulo.Text = Tarefa.Titulo;
            tbDescricao.Text = Tarefa.Descricao;
            cbSituacao.Text = Tarefa.Status;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
            {
                return;
            }
            String mensagem;
            if (Tarefa == null)
            {
                mensagem = services.CriarTarefa(new CriarTarefaInputDto
                {
                    Titulo = tbTitulo.Text,
                    Descricao = tbDescricao.Text,
                    Status = (String)cbSituacao.SelectedItem,
                    lista = ListaSelecionada
                });
            }
            else
            {
                Tarefa.Titulo = tbTitulo.Text;
                Tarefa.Descricao = tbDescricao.Text;
                Tarefa.Status = cbSituacao.SelectedItem.ToString();
                mensagem = services.EditarTarefa(Tarefa);
            }
            MessageBox.Show(mensagem);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Boolean ValidaCampos()
        {
            if (tbDescricao.Text.Trim().Equals(""))
            {
                MessageBox.Show(@"Informe uma Descrição!");
                return false;
            }
            if (tbTitulo.Text.Trim().Equals(""))
            {
                MessageBox.Show(@"Informe um título!");
                return false;
            }
            if (cbSituacao.SelectedItem == null)
            {
                MessageBox.Show(@"Informe o Status da Tarefa!");
                return false;
            }
            return true;
        }
    }

}