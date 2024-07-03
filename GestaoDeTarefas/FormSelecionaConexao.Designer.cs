namespace GestaoDeTarefas
{
    partial class FormSelecionaConexao
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
            btnAdd.Location = new Point(294, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(294, 41);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(294, 70);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(294, 179);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(213, 179);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lvConexoes
            // 
            lvConexoes.Columns.AddRange(new ColumnHeader[] { Nome });
            lvConexoes.Location = new Point(12, 12);
            lvConexoes.MultiSelect = false;
            lvConexoes.Name = "lvConexoes";
            lvConexoes.Size = new Size(266, 147);
            lvConexoes.TabIndex = 6;
            lvConexoes.UseCompatibleStateImageBehavior = false;
            lvConexoes.View = View.List;
            // 
            // Nome
            // 
            Nome.Width = 200;
            // 
            // FormSelecionaConexao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 214);
            Controls.Add(lvConexoes);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSelecionaConexao";
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