using GestaoDeTarefas.Domain;
using GestaoDeTarefas.Service;

namespace GestaoDeTarefas
{

    public partial class FormPrincipal : Form
    {

        private Boolean TemListaSelecionada => lvListasTarefas.SelectedItems.Count > 0;

        private ListaDeTarefas ListaSelecionada => (ListaDeTarefas)lvListasTarefas.SelectedItems[0].Tag;

        private Boolean TemTarefaSelecionada => lvTarefas.SelectedItems.Count > 0;

        private TarefasServices serviceTarefas { get; }

        private ListasDeTarefasServices serviceListas { get; }

        public FormPrincipal(TarefasServices serviceTarefas, ListasDeTarefasServices serviceListas)
        {
            InitializeComponent();
            this.serviceTarefas = serviceTarefas;
            this.serviceListas = serviceListas;
            PopulaListViewListas();
            if (TemListaSelecionada)
            {
                PopulaListViewTarefas(serviceTarefas.BuscaTarefasListaSelecionada(ListaSelecionada));
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!TemListaSelecionada)
            {
                MessageBox.Show(@"Selecione uma lista de tarefas para adicionar uma tarefa!");
                return;
            }
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa(serviceTarefas, ListaSelecionada, null);
            frmRegistroTarefa.ShowDialog();
            PopulaListViewTarefas(serviceTarefas.BuscaTarefasListaSelecionada(ListaSelecionada));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!TemTarefaSelecionada)
            {
                MessageBox.Show(@"Selecione uma tarefa da lista para excluir!");
                return;
            }
            DialogResult result = MessageBox.Show(@"Deseja excluir a tarefa permanentemente?", @"Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                MessageBox.Show(serviceTarefas.ExcluirTarefa((Tarefa)lvTarefas.SelectedItems[0].Tag));
                PopulaListViewTarefas(serviceTarefas.BuscaTarefasListaSelecionada(ListaSelecionada));
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!TemTarefaSelecionada)
            {
                MessageBox.Show(@"Selecione uma tarefa da lista para editar!");
                return;
            }
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa(serviceTarefas, ListaSelecionada, (Tarefa)lvTarefas.SelectedItems[0].Tag);
            frmRegistroTarefa.ShowDialog();
            PopulaListViewTarefas(serviceTarefas.BuscaTarefasListaSelecionada(ListaSelecionada));
        }

        private void btnAddLista_Click(object sender, EventArgs e)
        {
            FormRegistroLista frmRegistroLista = new FormRegistroLista(serviceListas);
            frmRegistroLista.ShowDialog();
            PopulaListViewListas();
        }

        private void btnExcluirLista_Click(object sender, EventArgs e)
        {
            if (!TemListaSelecionada)
            {
                MessageBox.Show(@"Selecione uma lista de tarefas da lista para excluir!");
                return;
            }
            DialogResult result = MessageBox.Show(@"Deseja excluir a lista permanentemente? Todas as tarefas desta lista também serão excluídas", @"Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                MessageBox.Show(serviceListas.Excluir(ListaSelecionada));
            }
            PopulaListViewListas();
        }

        private void btnEditaLista_Click(object sender, EventArgs e)
        {
            if (!TemListaSelecionada)
            {
                MessageBox.Show(@"Selecione uma lista para editar!");
                return;
            }
            FormRegistroLista frmRegistroLista = new FormRegistroLista(serviceListas, ListaSelecionada);
            frmRegistroLista.ShowDialog();
            PopulaListViewListas();
        }

        private void lvListasTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TemListaSelecionada)
            {
                PopulaListViewTarefas(serviceTarefas.BuscaTarefasListaSelecionada(ListaSelecionada));
            }
        }

        private void ListaTodasTarefas_Click(object sender, EventArgs e)
        {
            PopulaListViewTarefas(serviceTarefas.BuscaTodasAsTarefas());
        }

        private void PopulaListViewTarefas(List<Tarefa> lista)
        {
            lvTarefas.Items.Clear();
            if (lista.Count.Equals(0))
            {
                return;
            }
            foreach (Tarefa t in lista)
            {
                lvTarefas.Items.Add(new ListViewItem(new[] { t.Id.ToString(), t.Titulo, t.Descricao, t.Data.ToString("d"), t.Status, t.Lista.Nome }) { Tag = t });
            }
        }

        private void PopulaListViewListas()
        {
            lvListasTarefas.Items.Clear();
            List<ListaDeTarefas> listas = serviceListas.BuscaListas();
            if (listas.Count.Equals(0))
            {
                return;
            }
            foreach (ListaDeTarefas lista in listas)
            {
                lvListasTarefas.Items.Add(new ListViewItem(new[] { lista.Id.ToString(), lista.Nome }) { Tag = lista });
            }
        }

    }

}