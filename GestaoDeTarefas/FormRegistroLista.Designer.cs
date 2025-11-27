namespace GestaoDeTarefas {
  partial class FormRegistroLista {
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
      tbNome = new TextBox();
      btnSalvar = new Button();
      btnCancelar = new Button();
      lblNome = new Label();
      SuspendLayout();
      // 
      // tbNome
      // 
      tbNome.Location = new Point(51, 12);
      tbNome.Name = "tbNome";
      tbNome.Size = new Size(396, 23);
      tbNome.TabIndex = 0;
      tbNome.KeyDown += tbNome_KeyDown;
      // 
      // btnSalvar
      // 
      btnSalvar.Location = new Point(291, 42);
      btnSalvar.Name = "btnSalvar";
      btnSalvar.Size = new Size(75, 23);
      btnSalvar.TabIndex = 1;
      btnSalvar.Text = "Salvar";
      btnSalvar.UseVisualStyleBackColor = true;
      btnSalvar.Click += btnSalvar_Click;
      // 
      // btnCancelar
      // 
      btnCancelar.Location = new Point(372, 42);
      btnCancelar.Name = "btnCancelar";
      btnCancelar.Size = new Size(75, 23);
      btnCancelar.TabIndex = 2;
      btnCancelar.Text = "Cancelar";
      btnCancelar.UseVisualStyleBackColor = true;
      btnCancelar.Click += btnCancelar_Click;
      // 
      // lblNome
      // 
      lblNome.AutoSize = true;
      lblNome.Location = new Point(8, 15);
      lblNome.Name = "lblNome";
      lblNome.Size = new Size(40, 15);
      lblNome.TabIndex = 3;
      lblNome.Text = "Nome";
      // 
      // FormRegistroLista
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = btnCancelar;
      ClientSize = new Size(456, 73);
      Controls.Add(lblNome);
      Controls.Add(btnCancelar);
      Controls.Add(btnSalvar);
      Controls.Add(tbNome);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormRegistroLista";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Detalhes da Lista";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private TextBox tbNome;
    private Button btnSalvar;
    private Button btnCancelar;
    private Label lblNome;
  }
}