namespace GestaoDeTarefas {
  partial class FormSelecionaConexaoPadrao {
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
      btnAdd = new Button();
      btnExcluir = new Button();
      btnEditar = new Button();
      btnCancelar = new Button();
      btnConfirmar = new Button();
      lvConexoes = new ListView();
      Nome = new ColumnHeader();
      SuspendLayout();
      // 
      // btnAdd
      // 
      btnAdd.Location = new Point(284, 12);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size(75, 23);
      btnAdd.TabIndex = 2;
      btnAdd.Text = "Adicionar";
      btnAdd.UseVisualStyleBackColor = true;
      btnAdd.Click += btnAdd_Click;
      // 
      // btnExcluir
      // 
      btnExcluir.Location = new Point(284, 41);
      btnExcluir.Name = "btnExcluir";
      btnExcluir.Size = new Size(75, 23);
      btnExcluir.TabIndex = 3;
      btnExcluir.Text = "Excluir";
      btnExcluir.UseVisualStyleBackColor = true;
      btnExcluir.Click += btnExcluir_Click;
      // 
      // btnEditar
      // 
      btnEditar.Location = new Point(284, 70);
      btnEditar.Name = "btnEditar";
      btnEditar.Size = new Size(75, 23);
      btnEditar.TabIndex = 4;
      btnEditar.Text = "Editar";
      btnEditar.UseVisualStyleBackColor = true;
      btnEditar.Click += btnEditar_Click;
      // 
      // btnCancelar
      // 
      btnCancelar.Location = new Point(284, 166);
      btnCancelar.Name = "btnCancelar";
      btnCancelar.Size = new Size(75, 23);
      btnCancelar.TabIndex = 1;
      btnCancelar.Text = "Cancelar";
      btnCancelar.UseVisualStyleBackColor = true;
      btnCancelar.Click += btnCancelar_Click;
      // 
      // btnConfirmar
      // 
      btnConfirmar.Location = new Point(203, 166);
      btnConfirmar.Name = "btnConfirmar";
      btnConfirmar.Size = new Size(75, 23);
      btnConfirmar.TabIndex = 0;
      btnConfirmar.Text = "Confirmar";
      btnConfirmar.UseVisualStyleBackColor = true;
      btnConfirmar.Click += btnConfirmar_Click;
      // 
      // lvConexoes
      // 
      lvConexoes.Columns.AddRange(new ColumnHeader[] { Nome });
      lvConexoes.FullRowSelect = true;
      lvConexoes.Location = new Point(12, 12);
      lvConexoes.MultiSelect = false;
      lvConexoes.Name = "lvConexoes";
      lvConexoes.Size = new Size(266, 147);
      lvConexoes.TabIndex = 5;
      lvConexoes.UseCompatibleStateImageBehavior = false;
      lvConexoes.View = View.List;
      lvConexoes.SelectedIndexChanged += lvConexoes_SelectedIndexChanged;
      // 
      // Nome
      // 
      Nome.Width = 200;
      // 
      // FormSelecionaConexaoPadrao
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = btnCancelar;
      ClientSize = new Size(367, 194);
      Controls.Add(lvConexoes);
      Controls.Add(btnConfirmar);
      Controls.Add(btnCancelar);
      Controls.Add(btnEditar);
      Controls.Add(btnExcluir);
      Controls.Add(btnAdd);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormSelecionaConexaoPadrao";
      StartPosition = FormStartPosition.CenterScreen;
      Text = " Banco de Dados";
      ResumeLayout(false);
    }

    #endregion
    private Button btnAdd;
    private Button btnExcluir;
    private Button btnEditar;
    private Button btnCancelar;
    private Button btnConfirmar;
    private ListView lvConexoes;
    private ColumnHeader Nome;
  }
}