using System.Data;
using FirebirdSql.Data.FirebirdClient;
using GestaoDeTarefas;


namespace GestaoDeTarefas
{

    public partial class Form1 : Form
    {
        public String Conexao = File.ReadAllText(Environment.CurrentDirectory + "\\Banco\\Firebird.conf");
        public FbConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            connection = new FbConnection(Conexao);
            FbCommand comando = new FbCommand("select * from tarefas", connection);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            connection.Open();
            data.Fill(dataset, "tarefas");
            
            dgvAtores.DataSource = dataset;
            dgvAtores.DataMember = "tarefas";
            connection.Close();
        }

        private void btnInserirDado_Click(object sender, EventArgs e) {
            Tarefa t = new Tarefa(1, "teste", "teeeeeste", DateTime.Now, Status.Andamento);
            connection = new FbConnection(Conexao);


            FbCommand comando = new FbCommand(QueryBuilder.DbInsert(t.TableName, t.DbCollumns, t.GetValues));
            //FbCommand comando = new FbCommand("INSERT INTO ATORES (ID,PRIMEIRO_NOME, ULTIMO_NOME, SEXO) " +
            //  "VALUES (24,'JENIFER', 'MATTES', 'F')", connection);
            connection.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show("Problema na Inser��o!" + E.Message);
                connection.Close();
                return;
            }
            connection.Close();
            MessageBox.Show("Inser��o efetuada com sucesso!");
        }

        private void btnExcluirDado_Click(object sender, EventArgs e)
        {
            connection = new FbConnection(Conexao);
            FbCommand comando = new FbCommand("DELETE FROM ATORES WHERE ID = 24", connection);
            connection.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show("Problema na Exclus�o!" + E.Message);
                connection.Close();
                return;
            }

            connection.Close();
            MessageBox.Show("Exclus�o efetuada com sucesso!");
        }

    }

}