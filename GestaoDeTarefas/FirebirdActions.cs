
using System.Data;
using System.Runtime.Serialization;
using FirebirdSql.Data.FirebirdClient;

namespace GestaoDeTarefas
{
    public static class FirebirdActions {

        private static readonly String strConexao = File.ReadAllText(Environment.CurrentDirectory + "\\Banco\\Firebird.conf");

        public static DataSet? DbGenericSelect(String tableName) {
            FbConnection conexao = new FbConnection(strConexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbSelect(tableName),conexao);
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

        public static FbDataReader? DbSelectWhere(Model objeto) {
            FbConnection conexao = new FbConnection(strConexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbSelect(objeto.TableName, true, objeto.Id.ToString()), conexao);
            try {
                FbDataAdapter data = new FbDataAdapter(comando);
                DataSet dataSet = new DataSet();
                conexao.Open();
                data.Fill(dataSet, objeto.TableName);
                FbDataReader dataReader = comando.ExecuteReader();
                conexao.Close();
                return dataReader;
            } catch(Exception e) {
                MessageBox.Show("Firebird - Erro na busca do dado\n\n" + e.Message);
                return null;
            }
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

        public static String DbDelete(Model objeto) {
            FbConnection conexao = new FbConnection(strConexao);
            FbCommand comando = new FbCommand(QueryBuilder.DbDelete(objeto.TableName, objeto.Id.ToString()), conexao);
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
