using static GestaoDeTarefas.RecursosListView;

namespace GestaoDeTarefas
{

    public partial class FormPrincipal : Form
    {

        private DbComandos TransacoesTarefas { get; set; }
        private DbComandos TransacoesListas { get; set; }

        public FormPrincipal()
        {
            TransacoesTarefas = new DbComandos(Tarefa.TableName, Tarefa.TableColluns, Tarefa.GeneratorName);
            TransacoesListas = new DbComandos(ListaDeTarefas.TableName, ListaDeTarefas.TableColluns, ListaDeTarefas.GeneratorName);
            InitializeComponent();
            MontaColunasListView(lvTarefas, Tarefa.TableColluns);
            PopulaListView(lvTarefas, TransacoesListas, TransacoesTarefas);
            MontaColunasListView(lvListasTarefas, ListaDeTarefas.TableColluns);
            PopulaListView(lvListasTarefas, TransacoesListas, TransacoesTarefas);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa(null);
            frmRegistroTarefa.ShowDialog();
            PopulaListView(lvTarefas, TransacoesListas, TransacoesTarefas);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvTarefas.SelectedItems.Count.Equals(0))
            {
                MessageBox.Show(@"Selecione uma tarefa da lista para excluir!");
                return;
            }
            DialogResult result = MessageBox.Show(@"Deseja excluir a tarefa permanentemente?", @"Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                MessageBox.Show(TransacoesTarefas.DbDelete((Model)lvTarefas.SelectedItems[0].Tag));
                PopulaListView(lvTarefas, TransacoesListas, TransacoesTarefas);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvTarefas.SelectedItems.Count.Equals(0))
            {
                MessageBox.Show(@"Selecione uma tarefa da lista para editar!");
                return;
            }
            FormRegistroTarefa frmRegistroTarefa = new FormRegistroTarefa((Tarefa)lvTarefas.SelectedItems[0].Tag);
            frmRegistroTarefa.ShowDialog();
            PopulaListView(lvTarefas, TransacoesListas, TransacoesTarefas);
        }

        private void btnAddLista_Click(object sender, EventArgs e)
        {
            FormRegistroLista frmRegistroLista = new FormRegistroLista();
            frmRegistroLista.ShowDialog();
            PopulaListView(lvListasTarefas, TransacoesListas, TransacoesTarefas);
            PopulaListView(lvTarefas, TransacoesListas, TransacoesTarefas);
        }

        private void btnExcluirLista_Click(object sender, EventArgs e)
        {
            if (lvListasTarefas.SelectedItems.Count.Equals(0))
            {
                MessageBox.Show(@"Selecione uma lista de tarefas da lista para excluir!");
                return;
            }
            DialogResult result = MessageBox.Show(@"Deseja excluir a lista permanentemente? Todas as tarefas desta lista também serão excluídas", @"Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                MessageBox.Show(TransacoesListas.DbDelete((Model)lvListasTarefas.SelectedItems[0].Tag));
                PopulaListView(lvListasTarefas, TransacoesListas, TransacoesTarefas);
                PopulaListView(lvTarefas, TransacoesListas, TransacoesTarefas);
            }
        }

        private void btnEditaLista_Click(object sender, EventArgs e)
        {
            if (lvListasTarefas.SelectedItems.Count.Equals(0))
            {
                MessageBox.Show(@"Selecione uma lista para editar!");
                return;
            }
            FormRegistroLista frmRegistroLista = new FormRegistroLista((ListaDeTarefas)lvListasTarefas.SelectedItems[0].Tag);
            frmRegistroLista.ShowDialog();
            PopulaListView(lvListasTarefas, TransacoesListas, TransacoesTarefas);
            PopulaListView(lvTarefas, TransacoesListas, TransacoesTarefas);
        }

        private void lvListasTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvListasTarefas.SelectedItems.Count > 0)
            {
                ListaDeTarefas l = (ListaDeTarefas)lvListasTarefas.SelectedItems[0].Tag;
                TarefasDaListaSelecionada(lvTarefas, l, TransacoesListas);
            }
        }
    }
}