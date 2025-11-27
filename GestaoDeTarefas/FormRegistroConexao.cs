using GestaoDeTarefas.Services.Dtos;

namespace GestaoDeTarefas {
  public partial class FormRegistroConexao : FormBase {

    public ConexaoBancoDto? Conexao { get; private set; }

    private Int32 Porta => !tbPorta.Text.Trim().Equals("") ? Convert.ToInt32(tbPorta.Text) : 3050;

    private String Usuario => !tbUsuario.Text.Trim().Equals("") ? tbUsuario.Text : "SYSDBA";

    private String Senha => !tbSenha.Text.Trim().Equals("") ? tbSenha.Text : "masterkey";

    private String Ip => tbIpServidor.Text.Trim();

    private String Alias => tbAlias.Text.Trim();

    private String Caminho => tbCaminho.Text.Trim();

    public FormRegistroConexao(ConexaoBancoDto? conexao) {
      InitializeComponent();
      if (conexao == null) {
        tbPorta.Text = Porta.ToString();
        tbUsuario.Text = Usuario;
        tbSenha.Text = Senha;
        return;
      }
      Conexao = conexao;
      tbAlias.Text = Conexao.Alias;
      tbCaminho.Text = Conexao.Caminho;
      tbIpServidor.Text = Conexao.Ip;
      tbPorta.Text = Conexao.Porta.ToString();
      tbUsuario.Text = Conexao.Usuario;
      tbSenha.Text = Conexao.Senha;
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
      if (Ip.Trim().Equals("")) {
        MessageBox.Show(@"Informe o IP do servidor remoto!");
        return false;
      }
      return true;
    }

    private void Salvar() {
      if (!ValidaCampos()) {
        return;
      }
      if (Conexao != null) {
        Conexao.Alias = Alias;
        Conexao.Porta = Porta;
        Conexao.Ip = Ip;
        Conexao.Caminho = Caminho;
        Conexao.Usuario = Usuario;
        Conexao.Senha = Senha;
      } else {
        Conexao = new ConexaoBancoDto(Alias, Porta, Ip, Caminho, Usuario, Senha);
      }
      DialogResult = DialogResult.OK;
    }

    private void Cancelar() {
      DialogResult = DialogResult.Cancel;
    }

    private void TbPortaLeave() {
      tbPorta.Text = Porta.ToString();
    }

    private void TbUserNameLeave() {
      tbUsuario.Text = Usuario;
    }

    private void TbSenhaLeave() {
      tbSenha.Text = Senha;
    }

    private void TbPortaKeyPress(KeyPressEventArgs e) {
      e.Handled = !e.KeyChar.Equals(((Char)Keys.Back)) && !Char.IsDigit(e.KeyChar);
    }

    private void btnCancelar_Click(Object sender, EventArgs e) {
      Cancelar();
    }

    private void btnSalvar_Click(Object sender, EventArgs e) {
      Salvar();
    }

    private void tbPorta_Leave(Object sender, EventArgs e) {
      TbPortaLeave();
    }

    private void tbUsuarioLeave(Object sender, EventArgs e) {
      TbUserNameLeave();
    }

    private void tbSenha_Leave(Object sender, EventArgs e) {
      TbSenhaLeave();
    }

    private void tbPorta_KeyPress(Object sender, KeyPressEventArgs e) {
      TbPortaKeyPress(e);
    }

  }

}