namespace GestaoDeTarefas {

    public partial class FormSelecionaConexao : Form {
        //ler do arquivo
        //criar a lista
        //escrever no arquivo
        public FormSelecionaConexao() {
            InitializeComponent();
            ConfFirebird.PopulaLista();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            RegistroConexao frmRegistroConexao = new RegistroConexao();
            frmRegistroConexao.ShowDialog();
            if (frmRegistroConexao.DialogResult == DialogResult.OK) {
                LeArquivoConexoes();
                PopulaListBox();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {

        }

        private void btnEditar_Click(object sender, EventArgs e) {
            RegistroConexao frmRegistroConexao = new RegistroConexao();
            frmRegistroConexao.ShowDialog();
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {

        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void LeArquivoConexoes() {

        }

        private void PopulaListBox() {
            if (ConfFirebird.Conexoes.Count > 0) {
                foreach (Conexao c in ConfFirebird.Conexoes) {
                    lbxConexoes.Items.Add(c);
                }
            }
        }

    }

}