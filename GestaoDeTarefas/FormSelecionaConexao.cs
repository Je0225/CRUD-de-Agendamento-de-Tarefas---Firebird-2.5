namespace GestaoDeTarefas {

    public partial class FormSelecionaConexao: Form {

        public Conexao? ConexaoSelecionada => (Conexao)lvConexoes.SelectedItems[0].Tag;

        public Config Config => FileFirebird.Config;

        private ConfFirebird FileFirebird { get; set; }

        public FormSelecionaConexao() {
            InitializeComponent();
            FileFirebird = new ConfFirebird();
            PopulaListView();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            RegistroConexao frmRegistroConexao = new RegistroConexao(null, FileFirebird);
            frmRegistroConexao.ShowDialog();
            if (frmRegistroConexao.DialogResult == DialogResult.OK) {
                PopulaListView();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (ConexaoSelecionada != null) {
                FileFirebird.ExcluirConexao(ConexaoSelecionada);
                PopulaListView();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (ConexaoSelecionada == null) {
                return;
            }
            RegistroConexao frmRegistroConexao = new RegistroConexao(ConexaoSelecionada, FileFirebird);
            frmRegistroConexao.ShowDialog();
            if (frmRegistroConexao.DialogResult == DialogResult.OK) {
                PopulaListView();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {
            if (ConexaoSelecionada == null) {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PopulaListView() {
            lvConexoes.Items.Clear();
            FileFirebird.AtualizaListaConexoes();
            if (FileFirebird.Conexoes.Count > 0) {
                foreach (Conexao c in FileFirebird.Conexoes) {
                    lvConexoes.Items.Add(new ListViewItem(new[] { c.Alias }) { Tag = c });
                }
            }
        }

    }

}