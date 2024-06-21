using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace GestaoDeTarefas {

    public static class FirebirdActions {

        private static readonly String strConexao = File.ReadAllText(Environment.CurrentDirectory + "\\Banco\\Firebird.conf");

        public static DataSet? DbGenericSelect(String tableName) {
            FbConnection conexao = new FbConnection(strConexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbSelect(tableName), conexao);
            try {
                FbDataAdapter data = new FbDataAdapter(comando);
                DataSet dataSet = new DataSet();
                conexao.Open();
                data.Fill(dataSet, tableName);
                FbDataReader dataReader = comando.ExecuteReader();
                conexao.Close();
                return dataSet;
            } catch(Exception e) {
                MessageBox.Show("Firebird - Erro ao buscar dados\n\n" + e.Message);
                return null;
            }
        }

        public static DataSet DbSelectWhere(String tableName, Int32 objectId) {
            FbDataReader dados;
            FbConnection conexao = new FbConnection(strConexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbSelect(tableName, true, objectId.ToString()), conexao);
            try {
                FbDataAdapter data = new FbDataAdapter(comando);
                DataSet dataSet = new DataSet();
                conexao.Open();
                data.Fill(dataSet, tableName);
                conexao.Close();
                return dataSet;
            } catch(Exception e) {
                MessageBox.Show("Firebird - Erro na busca do dado\n\n" + e.Message);
                return null;
            }
        }

        public static String DbUpdate(Model objeto) {
            FbConnection conexao = new FbConnection(strConexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbUpdate(objeto.TableName, objeto.DbCollumns, objeto.GetValues, objeto.Id), conexao);
            conexao.Open();
            try {
                comando.ExecuteNonQuery();
            } catch(Exception e) {
                conexao.Close();
                return "Firebird - Problema na Atualização/Update de Dados!\n\n" + e.Message;
            }
            conexao.Close();
            return "Dado alterado com sucesso!";
        }

        public static String DbInsert(Model objeto) {
            FbConnection conexao = new FbConnection(strConexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbInsert(objeto.TableName, objeto.DbCollumns, objeto.GetValues), conexao);
            conexao.Open();
            try {
                comando.ExecuteNonQuery();
            } catch(Exception e) {
                conexao.Close();
                return "Firebird - Problema na Inserção de Dados!\n\n" + e.Message;
            }
            conexao.Close();
            return "Dado adicionado com sucesso!";
        }

        public static String DbDelete(String tableName, Int32 objectId) {
            FbConnection conexao = new FbConnection(strConexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbDelete(tableName, objectId.ToString()), conexao);
            conexao.Open();
            try {
                comando.ExecuteNonQuery();
            } catch(Exception e) {
                conexao.Close();
                return "Firebird - Problema na Exclusão de Dados!\n\n" + e.Message;
            }
            conexao.Close();
            return ("Dado excluido com sucesso!");
        }

    }

}