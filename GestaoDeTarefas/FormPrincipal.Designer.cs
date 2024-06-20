namespace GestaoDeTarefas
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelSuperior = new Panel();
            panelInferior = new Panel();
            panelEsquerda = new Panel();
            panelDireita = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox2 = new GroupBox();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            listView1 = new ListView();
            clmId = new ColumnHeader();
            clmTitulo = new ColumnHeader();
            clmDescricao = new ColumnHeader();
            clmData = new ColumnHeader();
            clmSituacao = new ColumnHeader();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1050, 32);
            panelSuperior.TabIndex = 0;
            // 
            // panelInferior
            // 
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 502);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1050, 65);
            panelInferior.TabIndex = 1;
            // 
            // panelEsquerda
            // 
            panelEsquerda.Dock = DockStyle.Right;
            panelEsquerda.Location = new Point(998, 32);
            panelEsquerda.Name = "panelEsquerda";
            panelEsquerda.Size = new Size(52, 470);
            panelEsquerda.TabIndex = 2;
            // 
            // panelDireita
            // 
            panelDireita.Dock = DockStyle.Left;
            panelDireita.Location = new Point(0, 32);
            panelDireita.Name = "panelDireita";
            panelDireita.Size = new Size(52, 470);
            panelDireita.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(btnAdicionar);
            groupBox2.Controls.Add(listView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(52, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(946, 470);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(23, 195);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(23, 122);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(23, 53);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clmId, clmTitulo, clmDescricao, clmData, clmSituacao });
            listView1.Location = new Point(160, 53);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(687, 342);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // clmId
            // 
            clmId.Text = "Id";
            // 
            // clmTitulo
            // 
            clmTitulo.Text = "Titulo";
            clmTitulo.Width = 120;
            // 
            // clmDescricao
            // 
            clmDescricao.Text = "Descrição";
            clmDescricao.Width = 300;
            // 
            // clmData
            // 
            clmData.Text = "Data de Criação";
            clmData.Width = 100;
            // 
            // clmSituacao
            // 
            clmSituacao.Text = "Situação";
            clmSituacao.Width = 100;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 567);
            Controls.Add(groupBox2);
            Controls.Add(panelDireita);
            Controls.Add(panelEsquerda);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            Text = "Gestão de Tarefas";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelInferior;
        private Panel panelEsquerda;
        private Panel panelDireita;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox2;
        private ListView listView1;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnAdicionar;
        private ColumnHeader clmId;
        private ColumnHeader clmTitulo;
        private ColumnHeader clmDescricao;
        private ColumnHeader clmData;
        private ColumnHeader clmSituacao;
    }
}