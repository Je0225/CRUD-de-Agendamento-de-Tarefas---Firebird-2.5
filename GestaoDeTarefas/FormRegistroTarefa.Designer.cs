namespace GestaoDeTarefas {
  partial class FormRegistroTarefa {
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
      btnCancelar = new Button();
      btnSalvar = new Button();
      tbTitulo = new TextBox();
      tbDescricao = new TextBox();
      lblSituacao = new Label();
      lblDescricao = new Label();
      lblTitulo = new Label();
      cbSituacao = new ComboBox();
      SuspendLayout();
      // 
      // btnCancelar
      // 
      btnCancelar.Location = new Point(350, 97);
      btnCancelar.Name = "btnCancelar";
      btnCancelar.Size = new Size(97, 23);
      btnCancelar.TabIndex = 4;
      btnCancelar.Text = "Cancelar";
      btnCancelar.UseVisualStyleBackColor = true;
      btnCancelar.Click += btnCancelar_Click;
      // 
      // btnSalvar
      // 
      btnSalvar.Location = new Point(247, 97);
      btnSalvar.Name = "btnSalvar";
      btnSalvar.Size = new Size(97, 23);
      btnSalvar.TabIndex = 3;
      btnSalvar.Text = "Salvar";
      btnSalvar.UseVisualStyleBackColor = true;
      btnSalvar.Click += btnSalvar_Click;
      // 
      // tbTitulo
      // 
      tbTitulo.Location = new Point(67, 12);
      tbTitulo.Name = "tbTitulo";
      tbTitulo.Size = new Size(380, 23);
      tbTitulo.TabIndex = 0;
      // 
      // tbDescricao
      // 
      tbDescricao.Location = new Point(66, 41);
      tbDescricao.Name = "tbDescricao";
      tbDescricao.Size = new Size(381, 23);
      tbDescricao.TabIndex = 1;
      // 
      // lblSituacao
      // 
      lblSituacao.AutoSize = true;
      lblSituacao.Location = new Point(11, 74);
      lblSituacao.Name = "lblSituacao";
      lblSituacao.Size = new Size(52, 15);
      lblSituacao.TabIndex = 7;
      lblSituacao.Text = "Situação";
      lblSituacao.TextAlign = ContentAlignment.MiddleRight;
      // 
      // lblDescricao
      // 
      lblDescricao.AutoSize = true;
      lblDescricao.Location = new Point(5, 43);
      lblDescricao.Name = "lblDescricao";
      lblDescricao.Size = new Size(58, 15);
      lblDescricao.TabIndex = 6;
      lblDescricao.Text = "Descrição";
      lblDescricao.TextAlign = ContentAlignment.MiddleRight;
      // 
      // lblTitulo
      // 
      lblTitulo.AutoSize = true;
      lblTitulo.Location = new Point(27, 15);
      lblTitulo.Name = "lblTitulo";
      lblTitulo.Size = new Size(37, 15);
      lblTitulo.TabIndex = 5;
      lblTitulo.Text = "Título";
      lblTitulo.TextAlign = ContentAlignment.MiddleRight;
      // 
      // cbSituacao
      // 
      cbSituacao.FormattingEnabled = true;
      cbSituacao.Location = new Point(66, 71);
      cbSituacao.Name = "cbSituacao";
      cbSituacao.Size = new Size(162, 23);
      cbSituacao.TabIndex = 2;
      // 
      // FormRegistroTarefa
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = btnCancelar;
      ClientSize = new Size(462, 130);
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
  }
}