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
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            panel6 = new Panel();
            bgListasDeTarefas = new GroupBox();
            lvListasTarefas = new ListView();
            colId = new ColumnHeader();
            clmNome = new ColumnHeader();
            panel10 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            btnEditaLista = new Button();
            btnExcluirLista = new Button();
            btnAddLista = new Button();
            panel7 = new Panel();
            panel3 = new Panel();
            btnListaTodasTarefas = new Button();
            btnEditarTarefa = new Button();
            btnAdicionarTarefa = new Button();
            btnExcluirTarefa = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            lvTarefas = new ListView();
            clmId = new ColumnHeader();
            clmTitulo = new ColumnHeader();
            clmDescricao = new ColumnHeader();
            clmData = new ColumnHeader();
            clmStatus = new ColumnHeader();
            clmLista = new ColumnHeader();
            gbTarefas = new GroupBox();
            bgListasDeTarefas.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            gbTarefas.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(636, 18);
            panelSuperior.TabIndex = 0;
            // 
            // panelInferior
            // 
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 405);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(636, 42);
            panelInferior.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(606, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 387);
            panel1.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 18);
            panel6.Name = "panel6";
            panel6.Size = new Size(27, 387);
            panel6.TabIndex = 0;
            // 
            // bgListasDeTarefas
            // 
            bgListasDeTarefas.Controls.Add(lvListasTarefas);
            bgListasDeTarefas.Controls.Add(panel10);
            bgListasDeTarefas.Controls.Add(panel9);
            bgListasDeTarefas.Controls.Add(panel8);
            bgListasDeTarefas.Controls.Add(panel7);
            bgListasDeTarefas.Dock = DockStyle.Top;
            bgListasDeTarefas.FlatStyle = FlatStyle.System;
            bgListasDeTarefas.Location = new Point(27, 18);
            bgListasDeTarefas.Name = "bgListasDeTarefas";
            bgListasDeTarefas.Size = new Size(579, 187);
            bgListasDeTarefas.TabIndex = 11;
            bgListasDeTarefas.TabStop = false;
            bgListasDeTarefas.Text = "Listas De tarefas";
            // 
            // lvListasTarefas
            // 
            lvListasTarefas.Columns.AddRange(new ColumnHeader[] { colId, clmNome });
            lvListasTarefas.Dock = DockStyle.Fill;
            lvListasTarefas.FullRowSelect = true;
            lvListasTarefas.Location = new Point(135, 31);
            lvListasTarefas.MultiSelect = false;
            lvListasTarefas.Name = "lvListasTarefas";
            lvListasTarefas.Size = new Size(431, 141);
            lvListasTarefas.TabIndex = 4;
            lvListasTarefas.Tag = "";
            lvListasTarefas.UseCompatibleStateImageBehavior = false;
            lvListasTarefas.View = View.Details;
            lvListasTarefas.SelectedIndexChanged += lvListasTarefas_SelectedIndexChanged;
            // 
            // colId
            // 
            colId.Text = "Id";
            // 
            // clmNome
            // 
            clmNome.Text = "Nome";
            clmNome.Width = 200;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(135, 19);
            panel10.Name = "panel10";
            panel10.Size = new Size(431, 12);
            panel10.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(135, 172);
            panel9.Name = "panel9";
            panel9.Size = new Size(431, 12);
            panel9.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnEditaLista);
            panel8.Controls.Add(btnExcluirLista);
            panel8.Controls.Add(btnAddLista);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(3, 19);
            panel8.Name = "panel8";
            panel8.Size = new Size(132, 165);
            panel8.TabIndex = 1;
            // 
            // btnEditaLista
            // 
            btnEditaLista.Location = new Point(44, 71);
            btnEditaLista.Name = "btnEditaLista";
            btnEditaLista.Size = new Size(75, 23);
            btnEditaLista.TabIndex = 2;
            btnEditaLista.Text = "Editar";
            btnEditaLista.UseVisualStyleBackColor = true;
            btnEditaLista.Click += btnEditaLista_Click;
            // 
            // btnExcluirLista
            // 
            btnExcluirLista.Location = new Point(44, 42);
            btnExcluirLista.Name = "btnExcluirLista";
            btnExcluirLista.Size = new Size(75, 23);
            btnExcluirLista.TabIndex = 1;
            btnExcluirLista.Text = "Excluir";
            btnExcluirLista.UseVisualStyleBackColor = true;
            btnExcluirLista.Click += btnExcluirLista_Click;
            // 
            // btnAddLista
            // 
            btnAddLista.Location = new Point(44, 13);
            btnAddLista.Name = "btnAddLista";
            btnAddLista.Size = new Size(75, 23);
            btnAddLista.TabIndex = 0;
            btnAddLista.Text = "Adicionar";
            btnAddLista.UseVisualStyleBackColor = true;
            btnAddLista.Click += btnAddLista_Click;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(566, 19);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 165);
            panel7.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnListaTodasTarefas);
            panel3.Controls.Add(btnEditarTarefa);
            panel3.Controls.Add(btnAdicionarTarefa);
            panel3.Controls.Add(btnExcluirTarefa);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(3, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(132, 178);
            panel3.TabIndex = 11;
            // 
            // btnListaTodasTarefas
            // 
            btnListaTodasTarefas.Location = new Point(12, 100);
            btnListaTodasTarefas.Name = "btnListaTodasTarefas";
            btnListaTodasTarefas.Size = new Size(109, 25);
            btnListaTodasTarefas.TabIndex = 9;
            btnListaTodasTarefas.Text = "Todas as Tarefas";
            btnListaTodasTarefas.UseVisualStyleBackColor = true;
            btnListaTodasTarefas.Click += ListaTodasTarefas_Click;
            // 
            // btnEditarTarefa
            // 
            btnEditarTarefa.Location = new Point(44, 71);
            btnEditarTarefa.Name = "btnEditarTarefa";
            btnEditarTarefa.Size = new Size(75, 23);
            btnEditarTarefa.TabIndex = 8;
            btnEditarTarefa.Text = "Editar";
            btnEditarTarefa.UseVisualStyleBackColor = true;
            btnEditarTarefa.Click += btnEditar_Click;
            // 
            // btnAdicionarTarefa
            // 
            btnAdicionarTarefa.Location = new Point(44, 13);
            btnAdicionarTarefa.Name = "btnAdicionarTarefa";
            btnAdicionarTarefa.Size = new Size(75, 23);
            btnAdicionarTarefa.TabIndex = 6;
            btnAdicionarTarefa.Text = "Adicionar";
            btnAdicionarTarefa.UseVisualStyleBackColor = true;
            btnAdicionarTarefa.Click += btnAdicionar_Click;
            // 
            // btnExcluirTarefa
            // 
            btnExcluirTarefa.Location = new Point(44, 42);
            btnExcluirTarefa.Name = "btnExcluirTarefa";
            btnExcluirTarefa.Size = new Size(75, 23);
            btnExcluirTarefa.TabIndex = 7;
            btnExcluirTarefa.Text = "Excluir";
            btnExcluirTarefa.UseVisualStyleBackColor = true;
            btnExcluirTarefa.Click += btnExcluir_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(135, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 12);
            panel4.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(135, 187);
            panel5.Name = "panel5";
            panel5.Size = new Size(441, 10);
            panel5.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(566, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 156);
            panel2.TabIndex = 14;
            // 
            // lvTarefas
            // 
            lvTarefas.Columns.AddRange(new ColumnHeader[] { clmId, clmTitulo, clmDescricao, clmData, clmStatus, clmLista });
            lvTarefas.Dock = DockStyle.Fill;
            lvTarefas.ForeColor = SystemColors.InfoText;
            lvTarefas.FullRowSelect = true;
            lvTarefas.Location = new Point(135, 31);
            lvTarefas.Name = "lvTarefas";
            lvTarefas.Size = new Size(431, 156);
            lvTarefas.TabIndex = 15;
            lvTarefas.Tag = "";
            lvTarefas.UseCompatibleStateImageBehavior = false;
            lvTarefas.View = View.Details;
            // 
            // clmId
            // 
            clmId.Text = "Id";
            // 
            // clmTitulo
            // 
            clmTitulo.Text = "Título";
            clmTitulo.Width = 150;
            // 
            // clmDescricao
            // 
            clmDescricao.Text = "Descrição ";
            clmDescricao.Width = 200;
            // 
            // clmData
            // 
            clmData.Text = "Data de Criação";
            clmData.Width = 80;
            // 
            // clmStatus
            // 
            clmStatus.Text = "Status";
            clmStatus.Width = 80;
            // 
            // clmLista
            // 
            clmLista.Text = "Lista";
            clmLista.Width = 100;
            // 
            // gbTarefas
            // 
            gbTarefas.Controls.Add(lvTarefas);
            gbTarefas.Controls.Add(panel2);
            gbTarefas.Controls.Add(panel5);
            gbTarefas.Controls.Add(panel4);
            gbTarefas.Controls.Add(panel3);
            gbTarefas.Dock = DockStyle.Fill;
            gbTarefas.FlatStyle = FlatStyle.System;
            gbTarefas.Location = new Point(27, 205);
            gbTarefas.Name = "gbTarefas";
            gbTarefas.Size = new Size(579, 200);
            gbTarefas.TabIndex = 12;
            gbTarefas.TabStop = false;
            gbTarefas.Text = "Tarefas";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 447);
            Controls.Add(gbTarefas);
            Controls.Add(bgListasDeTarefas);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            Text = "Gestão de Tarefas";
            bgListasDeTarefas.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            gbTarefas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelInferior;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Panel panel6;
        private GroupBox bgListasDeTarefas;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Button btnEditaLista;
        private Button btnExcluirLista;
        private Button btnAddLista;
        private Panel panel7;
        private ListView lvListasTarefas;
        private ColumnHeader colId;
        private ColumnHeader clmNome;
        private Panel panel3;
        private Button btnListaTodasTarefas;
        private Button btnEditarTarefa;
        private Button btnAdicionarTarefa;
        private Button btnExcluirTarefa;
        private Panel panel4;
        private Panel panel5;
        private Panel panel2;
        private ListView lvTarefas;
        private ColumnHeader clmId;
        private ColumnHeader clmTitulo;
        private ColumnHeader clmDescricao;
        private ColumnHeader clmData;
        private ColumnHeader clmStatus;
        private ColumnHeader clmLista;
        private GroupBox gbTarefas;
    }
}