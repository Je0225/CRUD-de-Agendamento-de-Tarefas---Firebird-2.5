namespace GestaoDeTarefas {

    public partial class RegistroConexao: Form {

        private String Servidor {
            get {
                if (rbRemote.Checked) {
                    return rbRemote.Text;
                }
                return rbLocaHost.Text;
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
                if (Servidor.Equals(rbLocaHost.Name)) {
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

        public RegistroConexao() {
            InitializeComponent();
            rbLocaHost.Checked = true;
            tbPorta.Text = "3050";
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
            Conexao conexao = new Conexao(Alias, Servidor, Porta, Ip, Caminho, UserName, Password);
            ConfFirebird.Conexoes.Add(conexao);
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

        public void EscritaArquivo() {
            String c = Environment.CurrentDirectory + "\\Banco\\Firebird.conf";
            String registros = "";
            String strConexao = "[@ALIAS]\n" +
                "DataSource=@IP\n" +
                "port=@PORT\n" +
                "DataBase=@CAMINHO\n" +
                "username=@USERNAME\n" +
                "password=@PASSWORD\n\n\n";

            foreach (Conexao cn in ConfFirebird.Conexoes) {
                strConexao = strConexao.Replace("@ALIAS", cn.Alias);
                strConexao = strConexao.Replace("@IP", cn.Ip);
                strConexao = strConexao.Replace("@PORT", cn.Porta.ToString());
                strConexao = strConexao.Replace("@CAMINHO", cn.Caminho);
                strConexao = strConexao.Replace("@USERNAME", cn.UserName);
                strConexao = strConexao.Replace("@PASSWORD", cn.Password);
                registros += strConexao;
            }
            File.WriteAllText(c, registros);
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