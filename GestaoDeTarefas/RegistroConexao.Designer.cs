namespace GestaoDeTarefas
{
    partial class RegistroConexao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAlias = new Label();
            lblCaminho = new Label();
            lblUserName = new Label();
            lblSenha = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            tbAlias = new TextBox();
            tbUserName = new TextBox();
            tbSenha = new TextBox();
            tbCaminho = new TextBox();
            rbRemote = new RadioButton();
            rbLocaHost = new RadioButton();
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
            lblAlias.Location = new Point(12, 18);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(32, 15);
            lblAlias.TabIndex = 0;
            lblAlias.Text = "Alias";
            // 
            // lblCaminho
            // 
            lblCaminho.AutoSize = true;
            lblCaminho.Location = new Point(11, 152);
            lblCaminho.Name = "lblCaminho";
            lblCaminho.Size = new Size(56, 15);
            lblCaminho.TabIndex = 3;
            lblCaminho.Text = "Caminho";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(11, 182);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(65, 15);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "User Name";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(11, 214);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            lblSenha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(229, 240);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(310, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbAlias
            // 
            tbAlias.Location = new Point(87, 18);
            tbAlias.Name = "tbAlias";
            tbAlias.Size = new Size(299, 23);
            tbAlias.TabIndex = 8;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(86, 179);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(299, 23);
            tbUserName.TabIndex = 9;
            tbUserName.Leave += tbUserName_Leave;
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(86, 211);
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.Size = new Size(299, 23);
            tbSenha.TabIndex = 10;
            tbSenha.UseSystemPasswordChar = true;
            tbSenha.Leave += tbSenha_Leave;
            // 
            // tbCaminho
            // 
            tbCaminho.Location = new Point(86, 149);
            tbCaminho.Name = "tbCaminho";
            tbCaminho.Size = new Size(299, 23);
            tbCaminho.TabIndex = 11;
            // 
            // rbRemote
            // 
            rbRemote.AutoSize = true;
            rbRemote.Location = new Point(74, 14);
            rbRemote.Name = "rbRemote";
            rbRemote.Size = new Size(104, 19);
            rbRemote.TabIndex = 12;
            rbRemote.TabStop = true;
            rbRemote.Tag = "";
            rbRemote.Text = "Remote/TCP IP";
            rbRemote.UseVisualStyleBackColor = true;
            // 
            // rbLocaHost
            // 
            rbLocaHost.AutoSize = true;
            rbLocaHost.Location = new Point(198, 14);
            rbLocaHost.Name = "rbLocaHost";
            rbLocaHost.Size = new Size(81, 19);
            rbLocaHost.TabIndex = 13;
            rbLocaHost.TabStop = true;
            rbLocaHost.Tag = "\"Local Host\"";
            rbLocaHost.Text = "Local Host";
            rbLocaHost.UseVisualStyleBackColor = true;
            rbLocaHost.CheckedChanged += rbLocaHost_CheckedChanged;
            // 
            // gbServidor
            // 
            gbServidor.Controls.Add(tbPorta);
            gbServidor.Controls.Add(lblPorta);
            gbServidor.Controls.Add(tbIpServidor);
            gbServidor.Controls.Add(lblIP);
            gbServidor.Controls.Add(rbLocaHost);
            gbServidor.Controls.Add(rbRemote);
            gbServidor.Location = new Point(12, 42);
            gbServidor.Name = "gbServidor";
            gbServidor.Size = new Size(374, 101);
            gbServidor.TabIndex = 19;
            gbServidor.TabStop = false;
            gbServidor.Text = "Servidor";
            // 
            // tbPorta
            // 
            tbPorta.Location = new Point(74, 68);
            tbPorta.Name = "tbPorta";
            tbPorta.Size = new Size(88, 23);
            tbPorta.TabIndex = 20;
            tbPorta.KeyPress += tbPorta_KeyPress;
            tbPorta.Leave += tbPorta_Leave;
            // 
            // lblPorta
            // 
            lblPorta.AutoSize = true;
            lblPorta.Location = new Point(33, 71);
            lblPorta.Name = "lblPorta";
            lblPorta.Size = new Size(35, 15);
            lblPorta.TabIndex = 19;
            lblPorta.Text = "Porta";
            // 
            // tbIpServidor
            // 
            tbIpServidor.Location = new Point(74, 39);
            tbIpServidor.Name = "tbIpServidor";
            tbIpServidor.Size = new Size(269, 23);
            tbIpServidor.TabIndex = 16;
            // 
            // lblIP
            // 
            lblIP.AutoSize = true;
            lblIP.Location = new Point(51, 42);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(17, 15);
            lblIP.TabIndex = 15;
            lblIP.Text = "IP";
            // 
            // RegistroConexao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 281);
            Controls.Add(gbServidor);
            Controls.Add(tbCaminho);
            Controls.Add(tbSenha);
            Controls.Add(tbUserName);
            Controls.Add(tbAlias);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblSenha);
            Controls.Add(lblUserName);
            Controls.Add(lblCaminho);
            Controls.Add(lblAlias);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistroConexao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Conexao";
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
        private TextBox tbUserName;
        private TextBox tbSenha;
        private TextBox tbCaminho;
        private RadioButton rbRemote;
        private RadioButton rbLocaHost;
        private GroupBox gbServidor;
        private TextBox tbIpServidor;
        private Label lblIP;
        private TextBox tbPorta;
        private Label lblPorta;
    }
}