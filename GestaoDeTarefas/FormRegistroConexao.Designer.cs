namespace GestaoDeTarefas {
  partial class FormRegistroConexao {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      lblAlias = new Label();
      lblCaminho = new Label();
      lblUserName = new Label();
      lblSenha = new Label();
      btnSalvar = new Button();
      btnCancelar = new Button();
      tbAlias = new TextBox();
      tbUsuario = new TextBox();
      tbSenha = new TextBox();
      tbCaminho = new TextBox();
      gbServidor = new GroupBox();
      tbPorta = new TextBox();
      lblPorta = new Label();
      tbIpServidor = new TextBox();
      lblIP = new Label();
      gbServidor.SuspendLayout();
      SuspendLayout();
      // 
      // lblAlias
      // 
      lblAlias.AutoSize = true;
      lblAlias.Location = new Point(43, 16);
      lblAlias.Name = "lblAlias";
      lblAlias.Size = new Size(32, 15);
      lblAlias.TabIndex = 6;
      lblAlias.Text = "Alias";
      // 
      // lblCaminho
      // 
      lblCaminho.AutoSize = true;
      lblCaminho.Location = new Point(18, 133);
      lblCaminho.Name = "lblCaminho";
      lblCaminho.Size = new Size(56, 15);
      lblCaminho.TabIndex = 8;
      lblCaminho.Text = "Caminho";
      // 
      // lblUserName
      // 
      lblUserName.AutoSize = true;
      lblUserName.Location = new Point(9, 163);
      lblUserName.Name = "lblUserName";
      lblUserName.Size = new Size(65, 15);
      lblUserName.TabIndex = 9;
      lblUserName.Text = "User Name";
      // 
      // lblSenha
      // 
      lblSenha.AutoSize = true;
      lblSenha.Location = new Point(35, 195);
      lblSenha.Name = "lblSenha";
      lblSenha.Size = new Size(39, 15);
      lblSenha.TabIndex = 10;
      lblSenha.Text = "Senha";
      lblSenha.TextAlign = ContentAlignment.MiddleRight;
      // 
      // btnSalvar
      // 
      btnSalvar.Location = new Point(220, 221);
      btnSalvar.Name = "btnSalvar";
      btnSalvar.Size = new Size(75, 23);
      btnSalvar.TabIndex = 5;
      btnSalvar.Text = "Salvar";
      btnSalvar.UseVisualStyleBackColor = true;
      btnSalvar.Click += btnSalvar_Click;
      // 
      // btnCancelar
      // 
      btnCancelar.Location = new Point(301, 221);
      btnCancelar.Name = "btnCancelar";
      btnCancelar.Size = new Size(75, 23);
      btnCancelar.TabIndex = 6;
      btnCancelar.Text = "Cancelar";
      btnCancelar.UseVisualStyleBackColor = true;
      btnCancelar.Click += btnCancelar_Click;
      // 
      // tbAlias
      // 
      tbAlias.Location = new Point(78, 13);
      tbAlias.Name = "tbAlias";
      tbAlias.Size = new Size(299, 23);
      tbAlias.TabIndex = 0;
      // 
      // tbUsuario
      // 
      tbUsuario.Location = new Point(77, 160);
      tbUsuario.Name = "tbUsuario";
      tbUsuario.Size = new Size(299, 23);
      tbUsuario.TabIndex = 3;
      tbUsuario.Leave += tbUsuarioLeave;
      // 
      // tbSenha
      // 
      tbSenha.Location = new Point(77, 192);
      tbSenha.Name = "tbSenha";
      tbSenha.PasswordChar = '*';
      tbSenha.Size = new Size(299, 23);
      tbSenha.TabIndex = 4;
      tbSenha.UseSystemPasswordChar = true;
      tbSenha.Leave += tbSenha_Leave;
      // 
      // tbCaminho
      // 
      tbCaminho.Location = new Point(77, 130);
      tbCaminho.Name = "tbCaminho";
      tbCaminho.Size = new Size(299, 23);
      tbCaminho.TabIndex = 2;
      // 
      // gbServidor
      // 
      gbServidor.Controls.Add(tbPorta);
      gbServidor.Controls.Add(lblPorta);
      gbServidor.Controls.Add(tbIpServidor);
      gbServidor.Controls.Add(lblIP);
      gbServidor.Location = new Point(15, 37);
      gbServidor.Name = "gbServidor";
      gbServidor.Size = new Size(362, 85);
      gbServidor.TabIndex = 1;
      gbServidor.TabStop = false;
      gbServidor.Text = "Servidor";
      // 
      // tbPorta
      // 
      tbPorta.Location = new Point(63, 51);
      tbPorta.Name = "tbPorta";
      tbPorta.Size = new Size(88, 23);
      tbPorta.TabIndex = 2;
      tbPorta.KeyPress += tbPorta_KeyPress;
      tbPorta.Leave += tbPorta_Leave;
      // 
      // lblPorta
      // 
      lblPorta.AutoSize = true;
      lblPorta.Location = new Point(25, 54);
      lblPorta.Name = "lblPorta";
      lblPorta.Size = new Size(35, 15);
      lblPorta.TabIndex = 3;
      lblPorta.Text = "Porta";
      // 
      // tbIpServidor
      // 
      tbIpServidor.Location = new Point(63, 22);
      tbIpServidor.Name = "tbIpServidor";
      tbIpServidor.Size = new Size(263, 23);
      tbIpServidor.TabIndex = 1;
      // 
      // lblIP
      // 
      lblIP.AutoSize = true;
      lblIP.Location = new Point(43, 25);
      lblIP.Name = "lblIP";
      lblIP.Size = new Size(17, 15);
      lblIP.TabIndex = 2;
      lblIP.Text = "IP";
      // 
      // FormRegistroConexao
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = btnCancelar;
      ClientSize = new Size(392, 254);
      Controls.Add(gbServidor);
      Controls.Add(tbCaminho);
      Controls.Add(tbSenha);
      Controls.Add(tbUsuario);
      Controls.Add(tbAlias);
      Controls.Add(btnCancelar);
      Controls.Add(btnSalvar);
      Controls.Add(lblSenha);
      Controls.Add(lblUserName);
      Controls.Add(lblCaminho);
      Controls.Add(lblAlias);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormRegistroConexao";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Detalhes da Conexao";
      gbServidor.ResumeLayout(false);
      gbServidor.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblAlias;
    private Label lblServidor;
    private Label lblCaminho;
    private Label lblUserName;
    private Label lblSenha;
    private Button btnSalvar;
    private Button btnCancelar;
    private TextBox tbAlias;
    private TextBox tbUsuario;
    private TextBox tbSenha;
    private TextBox tbCaminho;
    private GroupBox gbServidor;
    private TextBox tbIpServidor;
    private Label lblIP;
    private TextBox tbPorta;
    private Label lblPorta;
  }
}