using System.Security.Permissions;
using static GestaoDeTarefas.StatusTarefas;
using static GestaoDeTarefas.RecursosListView;

namespace GestaoDeTarefas
{

    public partial class FormRegistroTarefa : Form
    {

        private DbComandos transacoesTarefas { get; set; }

        private DbComandos transacoesListas { get; set; }

        private Tarefa? Tarefa { get; set; }

        private ListaDeTarefas? listaSelecionada { get; set; }

        public FormRegistroTarefa(Tarefa? tarefa)
        {
            InitializeComponent();
            Tarefa = tarefa;
            transacoesTarefas = new DbComandos(Tarefa.TableName, Tarefa.TableColluns, Tarefa.GeneratorName);
            transacoesListas = new DbComandos(ListaDeTarefas.TableName, ListaDeTarefas.TableColluns, ListaDeTarefas.GeneratorName);
            listaSelecionada = null;
            cbSituacao.Items.AddRange(status);
            MontaColunasListView(lvlistasTarefas, Tarefa.TableColluns);
            PopulaListView(lvlistasTarefas, transacoesListas, transacoesTarefas);
            if (Tarefa == null)
            {
                return;
            }
            tbTitulo.Text = Tarefa.Titulo;
            tbDescricao.Text = Tarefa.Descricao;
            cbSituacao.Text = Tarefa.Status;
            listaSelecionada = Tarefa.Lista;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
            {
                DialogResult = DialogResult.Continue;
                return;
            }
            Tarefa tarefa;
            String mensagem;
            if (Tarefa == null)
            {
                Int64 id = transacoesTarefas.DbSelectGeneratorId();
                if (id.Equals(-1))
                {
                    DialogResult = DialogResult.Abort;
                    return;
                }
                tarefa = new Tarefa(id, tbTitulo.Text, tbDescricao.Text, DateTime.Now, (String)cbSituacao.SelectedItem, listaSelecionada);
                mensagem = transacoesTarefas.DbInsert(tarefa);
            }
            else
            {
                tarefa = new Tarefa(Tarefa.Id, tbTitulo.Text, tbDescricao.Text, DateTime.Now, (String)cbSituacao.SelectedItem, listaSelecionada);
                mensagem = transacoesTarefas.DbUpdate(tarefa);
            }
            MessageBox.Show(mensagem);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            listaSelecionada = (ListaDeTarefas)lvlistasTarefas.SelectedItems[0].Tag;
        }

        private Boolean ValidaCampos()
        {
            if (listaSelecionada == null)
            {
                MessageBox.Show(@"Selecione uma lista antes de salvar!");
                return false;
            }
            if (tbDescricao.Text.Trim().Equals(""))
            {
                MessageBox.Show(@"Informe uma Descrição!");
                return false;
            }
            if (tbTitulo.Text.Trim().Equals(""))
            {
                MessageBox.Show(@"Informe um título!");
                return false;
            }
            if (cbSituacao.SelectedItem == null)
            {
                MessageBox.Show(@"Informe o Status da Tarefa!");
                return false;
            }
            return true;
        }
    }

}