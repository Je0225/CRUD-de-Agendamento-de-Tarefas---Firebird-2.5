﻿namespace GestaoDeTarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTestarConexao = new Button();
            dgvAtores = new DataGridView();
            btnInserirDado = new Button();
            btnAtualizarDB = new Button();
            btnExcluirDado = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            SuspendLayout();
            // 
            // btnTestarConexao
            // 
            btnTestarConexao.Location = new Point(12, 24);
            btnTestarConexao.Name = "btnTestarConexao";
            btnTestarConexao.Size = new Size(124, 23);
            btnTestarConexao.TabIndex = 0;
            btnTestarConexao.Text = "Testar Conexão";
            btnTestarConexao.UseVisualStyleBackColor = true;
            btnTestarConexao.Click += btnTestarConexao_Click;
            // 
            // dgvAtores
            // 
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Location = new Point(12, 73);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.RowTemplate.Height = 25;
            dgvAtores.Size = new Size(711, 365);
            dgvAtores.TabIndex = 1;
            // 
            // btnInserirDado
            // 
            btnInserirDado.Location = new Point(154, 24);
            btnInserirDado.Name = "btnInserirDado";
            btnInserirDado.Size = new Size(106, 23);
            btnInserirDado.TabIndex = 2;
            btnInserirDado.Text = "Inserir Dado";
            btnInserirDado.UseVisualStyleBackColor = true;
            btnInserirDado.Click += btnInserirDado_Click;
            // 
            // btnAtualizarDB
            // 
            btnAtualizarDB.Location = new Point(280, 24);
            btnAtualizarDB.Name = "btnAtualizarDB";
            btnAtualizarDB.Size = new Size(95, 23);
            btnAtualizarDB.TabIndex = 3;
            btnAtualizarDB.Text = "Atualizar DB";
            btnAtualizarDB.UseVisualStyleBackColor = true;
            btnAtualizarDB.Click += btnAtualizarDB_Click;
            // 
            // btnExcluirDado
            // 
            btnExcluirDado.Location = new Point(396, 24);
            btnExcluirDado.Name = "btnExcluirDado";
            btnExcluirDado.Size = new Size(97, 23);
            btnExcluirDado.TabIndex = 4;
            btnExcluirDado.Text = "Excluir Dado";
            btnExcluirDado.UseVisualStyleBackColor = true;
            btnExcluirDado.Click += btnExcluirDado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluirDado);
            Controls.Add(btnAtualizarDB);
            Controls.Add(btnInserirDado);
            Controls.Add(dgvAtores);
            Controls.Add(btnTestarConexao);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTestarConexao;
        private DataGridView dgvAtores;
        private Button btnInserirDado;
        private Button btnAtualizarDB;
        private Button btnExcluirDado;
    }
}