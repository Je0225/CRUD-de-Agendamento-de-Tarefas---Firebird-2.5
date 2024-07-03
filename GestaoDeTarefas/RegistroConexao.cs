namespace GestaoDeTarefas {

    public partial class RegistroConexao: Form {

        private ConfFirebird FileFirebird { get; set; }

        private String Servidor {
            get {
                if (rbRemote.Checked) {
                    return (String)rbRemote.Tag;
                }
                return (String)rbLocaHost.Tag;
            }
        }

        private Int32 Porta {
            get {
                if (!tbPorta.Text.Trim().Equals("")) {
                    return Convert.ToInt32(tbPorta.Text);
                }
                return 3050;
            }
        }

        private String Ip {
            get {
                if (Servidor.Equals(rbLocaHost.Tag)) {
                    return "localhost";
                }
                return tbIpServidor.Text;
            }
        }

        private String UserName {
            get {
                if (!tbUserName.Text.Trim().Equals("")) {
                    return tbUserName.Text;
                }
                return "SYSDBA";
            }
        }

        private String Password {
            get {
                if (!tbSenha.Text.Trim().Equals("")) {
                    return tbSenha.Text;
                }
                return "masterkey";
            }
        }

        private String Alias => tbAlias.Text;

        private String Caminho => tbCaminho.Text;

        private Conexao? Conexao { get; set; }

        public RegistroConexao(Conexao? conexao, ConfFirebird fileFirebird) {
            InitializeComponent();
            FileFirebird = fileFirebird;
            Conexao = conexao;
            if (Conexao != null) {
                tbAlias.Text = Conexao.Alias;
                if (Conexao.Servidor.Equals("localhost")) {
                    rbLocaHost.Checked = true;
                } else {
                    rbRemote.Checked = true;
                }
                tbCaminho.Text = Conexao.Caminho;
                tbIpServidor.Text = Conexao.Ip;
                tbPorta.Text = Conexao.Porta.ToString();
                tbUserName.Text = Conexao.UserName;
                tbSenha.Text = Conexao.Password;
                return;
            }
            rbLocaHost.Checked = true;
            tbPorta.Text = @"3050";
            tbUserName.Text = UserName;
            tbSenha.Text = Password;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (!ValidaCampos()) {
                return;
            }
            if (Conexao != null) {
                if (FileFirebird.Conexoes.Contains(Conexao)) {
                    Int32 index = FileFirebird.Conexoes.IndexOf(Conexao);
                    FileFirebird.Conexoes[index].Alias = Alias;
                    FileFirebird.Conexoes[index].Porta = Porta;
                    FileFirebird.Conexoes[index].Servidor = Servidor;
                    FileFirebird.Conexoes[index].Ip = Ip;
                    FileFirebird.Conexoes[index].Caminho = Caminho;
                    FileFirebird.Conexoes[index].UserName = UserName;
                    FileFirebird.Conexoes[index].Password = Password;
                }
            } else {
                Conexao conexao = new Conexao(Alias, Servidor, Porta, Ip, Caminho, UserName, Password);
                FileFirebird.Conexoes.Add(conexao);
            }
            FileFirebird.EscritaArquivo();
            DialogResult = DialogResult.OK;
        }

        private Boolean ValidaCampos() {
            if (Caminho.Trim().Equals("")) {
                MessageBox.Show(@"Informe o caminho do banco de dados!");
                return false;
            }
            if (Alias.Trim().Equals("")) {
                MessageBox.Show(@"Informe o apelido do banco de dados!");
                return false;
            }
            if (Servidor.Equals(rbRemote.Text) && Ip.Trim().Equals("")) {
                MessageBox.Show(@"Informe o IP do servidor remoto!");
                return false;
            }
            return true;
        }

        private void tbPorta_Leave(object sender, EventArgs e) {
            if (tbPorta.Text.Trim().Equals("")) {
                tbPorta.Text = Porta.ToString();
            }
        }

        private void tbUserName_Leave(object sender, EventArgs e) {
            if (tbUserName.Text.Trim().Equals("")) {
                tbUserName.Text = UserName;
            }
        }

        private void tbSenha_Leave(object sender, EventArgs e) {
            if (tbSenha.Text.Trim().Equals("")) {
                tbSenha.Text = Password;
            }
        }

        private void rbLocaHost_CheckedChanged(object sender, EventArgs e) {
            tbIpServidor.Enabled = !rbLocaHost.Checked;
        }

        private void tbPorta_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

    }

}