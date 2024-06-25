using static GestaoDeTarefas.DbMapeamento;
namespace GestaoDeTarefas {

    public partial class FormRegistroLista: Form {

        private readonly DbComandos transacoesLista = new DbComandos(TabelaListasTarefas, ColunasListasTarefas, GeneratorListasTarefas);

        private ListaDeTarefas? Lista { get; set; }

        public FormRegistroLista(ListaDeTarefas? lista = null) {
            InitializeComponent();
            Lista = lista;
            if (Lista == null) {
                return;
            }
            tbNome.Text = Lista.Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            // validar campos
            String mensagem;
            if (Lista == null) {
                ListaDeTarefas lista = new ListaDeTarefas(transacoesLista.DbSelectGeneratorId(), tbNome.Text);
                mensagem = transacoesLista.DbInsert(lista);
            } else {
                ListaDeTarefas lista = new ListaDeTarefas(Lista.Id, tbNome.Text);
                mensagem = transacoesLista.DbUpdate(lista);
            }
            MessageBox.Show(mensagem);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}