namespace GestaoDeTarefas
{
    partial class FormRegistroTarefa
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            tbTitulo = new TextBox();
            tbDescricao = new TextBox();
            lblSituacao = new Label();
            lblDescricao = new Label();
            lblTitulo = new Label();
            cbSituacao = new ComboBox();
            lvlistasTarefas = new ListView();
            groupBox1 = new GroupBox();
            btnSelecionar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(400, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(297, 310);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(97, 23);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(95, 30);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(386, 23);
            tbTitulo.TabIndex = 2;
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(94, 61);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(387, 23);
            tbDescricao.TabIndex = 3;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(30, 252);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 5;
            lblSituacao.Text = "Situação";
            lblSituacao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(30, 61);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 6;
            lblDescricao.Text = "Descrição";
            lblDescricao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Título";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbSituacao
            // 
            cbSituacao.FormattingEnabled = true;
            cbSituacao.Location = new Point(94, 252);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(162, 23);
            cbSituacao.TabIndex = 8;
            // 
            // lvlistasTarefas
            // 
            lvlistasTarefas.FullRowSelect = true;
            lvlistasTarefas.Location = new Point(65, 22);
            lvlistasTarefas.MultiSelect = false;
            lvlistasTarefas.Name = "lvlistasTarefas";
            lvlistasTarefas.Size = new Size(380, 97);
            lvlistasTarefas.TabIndex = 9;
            lvlistasTarefas.Tag = "ListaDeTarefas";
            lvlistasTarefas.UseCompatibleStateImageBehavior = false;
            lvlistasTarefas.View = View.Details;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSelecionar);
            groupBox1.Controls.Add(lvlistasTarefas);
            groupBox1.Location = new Point(30, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 156);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listas de Tarefas";
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(370, 125);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(75, 23);
            btnSelecionar.TabIndex = 10;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // FormRegistroTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 345);
            Controls.Add(groupBox1);
            Controls.Add(cbSituacao);
            Controls.Add(lblTitulo);
            Controls.Add(lblDescricao);
            Controls.Add(lblSituacao);
            Controls.Add(tbDescricao);
            Controls.Add(tbTitulo);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistroTarefa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro da Tarefa";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox tbTitulo;
        private TextBox tbDescricao;
        private Label lblSituacao;
        private Label lblDescricao;
        private Label lblTitulo;
        private ComboBox cbSituacao;
        private ListView lvlistasTarefas;
        private GroupBox groupBox1;
        private Button btnSelecionar;
    }
}