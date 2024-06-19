using System.Data;
using FirebirdSql.Data.FirebirdClient;
using GestaoDeTarefas;


namespace GestaoDeTarefas
{

    public partial class Form1 : Form
    {
        public String Conexao = File.ReadAllText(Environment.CurrentDirectory + "\\Banco\\Firebird.conf");
        public FbConnection connection;
        Tarefa t = new Tarefa(2, "teste", "teeeeeste", DateTime.Now, Status.Andamento);

        public Form1() {
            InitializeComponent();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e) {
            connection = new FbConnection(Conexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbSelect(t.TableName), connection);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            connection.Open();
            data.Fill(dataset, "tarefas");

            dgvAtores.DataSource = dataset;
            dgvAtores.DataMember = "tarefas";
            connection.Close();
        }

        private void btnInserirDado_Click(object sender, EventArgs e) {
            connection = new FbConnection(Conexao);

            FbCommand comando = new FbCommand(QueryBuilder.DbInsert(t.TableName, t.DbCollumns, t.GetValues), connection);
            connection.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show("Problema na Inserção!" + E.Message);
                connection.Close();
                return;
            }
            connection.Close();
            MessageBox.Show("Inserção efetuada com sucesso!");
        }

        private void btnExcluirDado_Click(object sender, EventArgs e) {
            connection = new FbConnection(Conexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbDelete(t.TableName, t.Id.ToString()), connection);
            connection.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show("Problema na Exclusão!" + E.Message);
                connection.Close();
                return;
            }
            connection.Close();
            MessageBox.Show("Exclusão efetuada com sucesso!");
        }

        private void btnSelectWhere_Click(object sender, EventArgs e) {
            connection = new FbConnection(Conexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbSelect(t.TableName, true, t.Id.ToString()), connection);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            connection.Open();
            data.Fill(dataset, "tarefas");

            dgvAtores.DataSource = dataset;
            dgvAtores.DataMember = "tarefas";
            connection.Close();
        }
    }

}