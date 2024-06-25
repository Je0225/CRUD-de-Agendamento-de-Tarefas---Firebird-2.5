using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace GestaoDeTarefas {

    public record DbComandos: ConstrutorDeQueries{

        private  String strConexao { get; set; }

        private FbConnection conexao { get; set; }

        private String TableName { get; set; }

        private String[] DbCollumns {get; set; }

        private String GeneratorName { get; set; }

        public DbComandos(String tableName, String[] dbCollumns, String generatorName) {
            strConexao = File.ReadAllText(Environment.CurrentDirectory + "\\Banco\\Firebird.conf"); //to do: read more than one string connection
            conexao = new FbConnection(strConexao);
            TableName = tableName;
            DbCollumns = dbCollumns;
            GeneratorName = generatorName;
        }

        private DataSet? MontaDataSet(FbCommand comando, String msgExcecao) {
            try {
                FbDataAdapter data = new FbDataAdapter(comando);
                DataSet dataSet = new DataSet();
                conexao.Open();
                data.Fill(dataSet, TableName);
                conexao.Close();
                return dataSet;
            } catch(Exception e) {
                MessageBox.Show(msgExcecao + e.Message);
                return null;
            }
        }

        private String ExecutaAlteracao(FbCommand comando, String msgExito, String msgExcessao) {
            conexao.Open();
            try {
                comando.ExecuteNonQuery();
            } catch(Exception e) {
                conexao.Close();
                return msgExito + e.Message;
            }
            conexao.Close();
            return msgExcessao;
        }

        public DataSet? DbGenericSelect() {
            FbCommand comando = new FbCommand(QuerySelect(TableName), conexao);
            return MontaDataSet(comando, "Firebird - Erro ao buscar dados\n\n");
        }

        public DataSet? DbSelectWhere(Int64 objectId) {
            FbCommand comando = new FbCommand(QuerySelect(TableName, true, objectId), conexao);
            return MontaDataSet(comando, "Firebird - Erro na busca do dado\n\n");
        }

        public DataSet? ExecutaSql(String sql) {
            FbCommand comando = new FbCommand(sql, conexao);
            return MontaDataSet(comando, "Firebird - Erro ao buscar dados\n\n");
        }

        public String DbUpdate(Model objeto) {
            FbCommand comando = new FbCommand(QueryUpdate(TableName, DbCollumns, objeto.GetValues, objeto.Id), conexao);
            return ExecutaAlteracao(comando, "Firebird - Problema na Atualização/Update de Dados!\n\n", "Dado alterado com sucesso!");
        }

        public String DbInsert(Model objeto) {
            FbCommand comando = new FbCommand(QueryInsert(TableName, DbCollumns, objeto.GetValues), conexao);
            return ExecutaAlteracao(comando, "Firebird - Problema na Inserção de Dados!\n\n", "Dado adicionado com sucesso!");
        }

        public String DbDelete(Model objeto) {
            FbCommand comando = new FbCommand(QueryDelete(TableName, objeto.Id), conexao);
            return ExecutaAlteracao(comando, "Firebird - Problema na Exclusão de Dados!\n\n", "Dado excluido com sucesso!");
        }

        public Int64 DbSelectGeneratorId() {
            FbCommand comando = new FbCommand(QuerySelectGeneratorId(GeneratorName), conexao);
            DataSet? dataSet = MontaDataSet(comando, "Firebird - Erro na busca do ID\n\n");
            return dataSet != null ? (Int64)dataSet.Tables[0].Rows[0].Field<Object>(0) : -1;
        }
    }
}