using FirebirdSql.Data.Client;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Drawing;

namespace GestaoDeTarefas
{
    public partial class Form1 : Form
    {
        public String Conexao = File.ReadAllText(Environment.CurrentDirectory + "\\Banco\\Firebird.conf");
        //public String Conexao = @"DataSource=localhost; Database=C:\\Users\\User\\Desktop\\DIO_sql_Firebird\\FILMES.FDB; username= SYSDBA; password = masterkey";
        public FbConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            connection = new FbConnection(Conexao);
            FbCommand comando = new FbCommand("select * from atores", connection);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            connection.Open();
            data.Fill(dataset, "ATORES");

            dgvAtores.DataSource = dataset;
            dgvAtores.DataMember = "ATORES";
            connection.Close();
        }

        private void btnInserirDado_Click(object sender, EventArgs e)
        {
            connection = new FbConnection(Conexao);
            FbCommand comando = new FbCommand("INSERT INTO EMPLOYEE (EMP_NO, FIRST_NAME, LAST_NAME, SALARY) " +
                "VALUES (160, 'THIAGO', 'CAVALHEIRO', 1000000)", connection);
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

        private void btnAtualizarDB_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirDado_Click(object sender, EventArgs e)
        {

        }
    }
}