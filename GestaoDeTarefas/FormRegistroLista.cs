namespace GestaoDeTarefas
{

    public partial class FormRegistroLista : Form
    {

        private DbComandos transacoesLista { get; set; }

        private ListaDeTarefas? Lista { get; set; }

        public FormRegistroLista(ListaDeTarefas? lista = null)
        {
            InitializeComponent();
            transacoesLista = new DbComandos(ListaDeTarefas.TableName, ListaDeTarefas.TableColluns, ListaDeTarefas.GeneratorName);
            Lista = lista;
            if (Lista == null)
            {
                return;
            }
            tbNome.Text = Lista.Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text.Trim().Equals(""))
            {
                MessageBox.Show(@"Informe o nome da lista!");
                DialogResult = DialogResult.Abort;
                return;
            }
            String mensagem;
            if (Lista == null)
            {
                Int64 id = transacoesLista.DbSelectGeneratorId();
                if (id.Equals(-1))
                {
                    DialogResult = DialogResult.Abort;
                    return;
                }
                ListaDeTarefas lista = new ListaDeTarefas(id, tbNome.Text);
                mensagem = transacoesLista.DbInsert(lista);
            }
            else
            {
                ListaDeTarefas lista = new ListaDeTarefas(Lista.Id, tbNome.Text);
                mensagem = transacoesLista.DbUpdate(lista);
            }
            MessageBox.Show(mensagem);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}