namespace GestaoDeTarefas {
  partial class FormPrincipal {
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
      panel8 = new Panel();
      btnEditaLista = new Button();
      btnExcluirLista = new Button();
      btnAddLista = new Button();
      panel3 = new Panel();
      btnListaTodasTarefas = new Button();
      btnEditarTarefa = new Button();
      btnAdicionarTarefa = new Button();
      btnExcluirTarefa = new Button();
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
      panelSuperior.Size = new Size(636, 12);
      panelSuperior.TabIndex = 2;
      // 
      // panelInferior
      // 
      panelInferior.Dock = DockStyle.Bottom;
      panelInferior.Location = new Point(0, 411);
      panelInferior.Name = "panelInferior";
      panelInferior.Size = new Size(636, 36);
      panelInferior.TabIndex = 0;
      // 
      // contextMenuStrip1
      // 
      contextMenuStrip1.Name = "contextMenuStrip1";
      contextMenuStrip1.Size = new Size(61, 4);
      // 
      // panel1
      // 
      panel1.Dock = DockStyle.Right;
      panel1.Location = new Point(612, 12);
      panel1.Name = "panel1";
      panel1.Size = new Size(24, 399);
      panel1.TabIndex = 5;
      // 
      // panel6
      // 
      panel6.Dock = DockStyle.Left;
      panel6.Location = new Point(0, 12);
      panel6.Name = "panel6";
      panel6.Size = new Size(21, 399);
      panel6.TabIndex = 3;
      // 
      // bgListasDeTarefas
      // 
      bgListasDeTarefas.Controls.Add(lvListasTarefas);
      bgListasDeTarefas.Controls.Add(panel8);
      bgListasDeTarefas.Dock = DockStyle.Top;
      bgListasDeTarefas.FlatStyle = FlatStyle.System;
      bgListasDeTarefas.Location = new Point(21, 12);
      bgListasDeTarefas.Name = "bgListasDeTarefas";
      bgListasDeTarefas.Size = new Size(591, 187);
      bgListasDeTarefas.TabIndex = 1;
      bgListasDeTarefas.TabStop = false;
      bgListasDeTarefas.Text = "Listas De tarefas";
      // 
      // lvListasTarefas
      // 
      lvListasTarefas.Columns.AddRange(new ColumnHeader[] { colId, clmNome });
      lvListasTarefas.Dock = DockStyle.Fill;
      lvListasTarefas.FullRowSelect = true;
      lvListasTarefas.Location = new Point(129, 19);
      lvListasTarefas.MultiSelect = false;
      lvListasTarefas.Name = "lvListasTarefas";
      lvListasTarefas.Size = new Size(459, 165);
      lvListasTarefas.TabIndex = 0;
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
      // panel8
      // 
      panel8.Controls.Add(btnEditaLista);
      panel8.Controls.Add(btnExcluirLista);
      panel8.Controls.Add(btnAddLista);
      panel8.Dock = DockStyle.Left;
      panel8.Location = new Point(3, 19);
      panel8.Name = "panel8";
      panel8.Size = new Size(126, 165);
      panel8.TabIndex = 3;
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
      // panel3
      // 
      panel3.Controls.Add(btnListaTodasTarefas);
      panel3.Controls.Add(btnEditarTarefa);
      panel3.Controls.Add(btnAdicionarTarefa);
      panel3.Controls.Add(btnExcluirTarefa);
      panel3.Dock = DockStyle.Left;
      panel3.Location = new Point(3, 19);
      panel3.Name = "panel3";
      panel3.Size = new Size(126, 190);
      panel3.TabIndex = 1;
      // 
      // btnListaTodasTarefas
      // 
      btnListaTodasTarefas.Location = new Point(12, 100);
      btnListaTodasTarefas.Name = "btnListaTodasTarefas";
      btnListaTodasTarefas.Size = new Size(109, 25);
      btnListaTodasTarefas.TabIndex = 3;
      btnListaTodasTarefas.Text = "Todas as Tarefas";
      btnListaTodasTarefas.UseVisualStyleBackColor = true;
      btnListaTodasTarefas.Click += ListaTodasTarefas_Click;
      // 
      // btnEditarTarefa
      // 
      btnEditarTarefa.Location = new Point(44, 71);
      btnEditarTarefa.Name = "btnEditarTarefa";
      btnEditarTarefa.Size = new Size(75, 23);
      btnEditarTarefa.TabIndex = 2;
      btnEditarTarefa.Text = "Editar";
      btnEditarTarefa.UseVisualStyleBackColor = true;
      btnEditarTarefa.Click += btnEditar_Click;
      // 
      // btnAdicionarTarefa
      // 
      btnAdicionarTarefa.Location = new Point(44, 13);
      btnAdicionarTarefa.Name = "btnAdicionarTarefa";
      btnAdicionarTarefa.Size = new Size(75, 23);
      btnAdicionarTarefa.TabIndex = 0;
      btnAdicionarTarefa.Text = "Adicionar";
      btnAdicionarTarefa.UseVisualStyleBackColor = true;
      btnAdicionarTarefa.Click += btnAdicionar_Click;
      // 
      // btnExcluirTarefa
      // 
      btnExcluirTarefa.Location = new Point(44, 42);
      btnExcluirTarefa.Name = "btnExcluirTarefa";
      btnExcluirTarefa.Size = new Size(75, 23);
      btnExcluirTarefa.TabIndex = 1;
      btnExcluirTarefa.Text = "Excluir";
      btnExcluirTarefa.UseVisualStyleBackColor = true;
      btnExcluirTarefa.Click += btnExcluir_Click;
      // 
      // lvTarefas
      // 
      lvTarefas.Columns.AddRange(new ColumnHeader[] { clmId, clmTitulo, clmDescricao, clmData, clmStatus, clmLista });
      lvTarefas.Dock = DockStyle.Fill;
      lvTarefas.ForeColor = SystemColors.InfoText;
      lvTarefas.FullRowSelect = true;
      lvTarefas.Location = new Point(129, 19);
      lvTarefas.Name = "lvTarefas";
      lvTarefas.Size = new Size(459, 190);
      lvTarefas.TabIndex = 0;
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
      gbTarefas.Controls.Add(panel3);
      gbTarefas.Dock = DockStyle.Fill;
      gbTarefas.FlatStyle = FlatStyle.System;
      gbTarefas.Location = new Point(21, 199);
      gbTarefas.Name = "gbTarefas";
      gbTarefas.Size = new Size(591, 212);
      gbTarefas.TabIndex = 4;
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
      StartPosition = FormStartPosition.CenterScreen;
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
    private Panel panel8;
    private Button btnEditaLista;
    private Button btnExcluirLista;
    private Button btnAddLista;
    private ListView lvListasTarefas;
    private ColumnHeader colId;
    private ColumnHeader clmNome;
    private Panel panel3;
    private Button btnListaTodasTarefas;
    private Button btnEditarTarefa;
    private Button btnAdicionarTarefa;
    private Button btnExcluirTarefa;
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