using System.Data;
using static GestaoDeTarefas.StatusTarefas;
using static GestaoDeTarefas.DbMapeamento;
using static GestaoDeTarefas.ListViewSources;

namespace GestaoDeTarefas
{

    public partial class FormRegistroTarefa : Form {

        private readonly DbComandos transacoesTarefas = new DbComandos(TabelaTarefas, ColunasTarefas, GeneratorTarefas);
        private readonly DbComandos transacoesListas = new DbComandos(TabelaListasTarefas, ColunasListasTarefas, GeneratorListasTarefas);
        private Tarefa? tarefa { get; set; }

        private ListaDeTarefas listaSelecionada { get; set; }

        public FormRegistroTarefa(Tarefa? tarefa = null) {
            InitializeComponent();
            this.tarefa = tarefa;
            cbSituacao.Items.AddRange(Status);
            MontaColunasListView(lvlistasTarefas, ColunasListasTarefas);
            PopulaListView(lvlistasTarefas);
            if (this.tarefa == null) {
                return;
            }
            tbTitulo.Text = this.tarefa.Titulo;
            tbDescricao.Text = this.tarefa.Descricao;
            cbSituacao.Text = this.tarefa.Status;
            listaSelecionada = this.tarefa.Lista;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            // to do:validação dos campos
            Tarefa tarefa;
            String mensagem;
            if (this.tarefa == null) {
                tarefa = new Tarefa(transacoesTarefas.DbSelectGeneratorId(), tbTitulo.Text, tbDescricao.Text, DateTime.Now, (String)cbSituacao.SelectedItem, listaSelecionada);
                mensagem = transacoesTarefas.DbInsert(tarefa);
            }
            else {
                tarefa = new Tarefa(this.tarefa.Id, tbTitulo.Text, tbDescricao.Text, DateTime.Now, (String)cbSituacao.SelectedItem, listaSelecionada);
                mensagem = transacoesTarefas.DbUpdate(tarefa);
            }
            MessageBox.Show(mensagem);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            listaSelecionada = (ListaDeTarefas)lvlistasTarefas.SelectedItems[0].Tag;
        }
    }

}