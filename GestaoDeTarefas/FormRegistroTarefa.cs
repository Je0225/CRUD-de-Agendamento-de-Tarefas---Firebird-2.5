using static GestaoDeTarefas.StatusTarefas;

namespace GestaoDeTarefas {

    public partial class FormRegistroTarefa: Form {

        private ListaDeTarefas ListaSelecionada { get; set; }

        private Tarefa? Tarefa { get; set; }

        private TarefasServices services { get; set; }

        public FormRegistroTarefa(ListaDeTarefas listaSelecionada, Tarefa? tarefa) {
            InitializeComponent();
            services = new TarefasServices(new TarefaRepositoryFirebird(ConexaoFirebird.conexao));
            Tarefa = tarefa;
            ListaSelecionada = listaSelecionada;
            listaSelecionada = null;
            cbSituacao.Items.AddRange(status);
            if (Tarefa == null) {
                return;
            }
            tbTitulo.Text = Tarefa.Titulo;
            tbDescricao.Text = Tarefa.Descricao;
            cbSituacao.Text = Tarefa.Status;
            listaSelecionada = Tarefa.Lista;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (!ValidaCampos()) {
                return;
            }
            String mensagem;
            if (Tarefa == null) {
                mensagem = services.CriarTarefa(new CriarTarefaInput {
                    Titulo = tbTitulo.Text,
                    Descricao = tbDescricao.Text,
                    Status = (String)cbSituacao.SelectedItem,
                    lista = ListaSelecionada
                });
            } else {
                mensagem = services.EditarTarefa(Tarefa);
            }
            MessageBox.Show(mensagem);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private Boolean ValidaCampos() {
            if (tbDescricao.Text.Trim().Equals("")) {
                MessageBox.Show(@"Informe uma Descrição!");
                return false;
            }
            if (tbTitulo.Text.Trim().Equals("")) {
                MessageBox.Show(@"Informe um título!");
                return false;
            }
            if (cbSituacao.SelectedItem == null) {
                MessageBox.Show(@"Informe o Status da Tarefa!");
                return false;
            }
            return true;
        }

    }

}