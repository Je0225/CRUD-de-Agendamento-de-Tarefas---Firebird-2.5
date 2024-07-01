using GestaoDeTarefas.Domain;
using GestaoDeTarefas.Service;

namespace GestaoDeTarefas {

    public partial class FormRegistroLista: Form {

        private ListasDeTarefasServices services { get;}

        private ListaDeTarefas? Lista { get;}

        public FormRegistroLista(ListasDeTarefasServices services ,ListaDeTarefas? lista = null) {
            InitializeComponent();
            this.services = services;
            Lista = lista;
            if (Lista == null) {
                return;
            }
            tbNome.Text = Lista.Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (tbNome.Text.Trim().Equals("")) {
                MessageBox.Show(@"Informe o nome da lista!");
                return;
            }
            String mensagem;
            if (Lista == null) {
                mensagem = services.Inserir(new CriarListaInputDto { Nome = tbNome.Text });
            } else {
                Lista.Nome = tbNome.Text;
                mensagem = services.Alterar(Lista);
            }
            MessageBox.Show(mensagem);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

    }

}