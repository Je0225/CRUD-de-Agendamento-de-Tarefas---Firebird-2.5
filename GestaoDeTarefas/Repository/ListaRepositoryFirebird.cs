using FirebirdSql.Data.FirebirdClient;
using GestaoDeTarefas.Domain;

namespace GestaoDeTarefas.Repository {

    public class ListaRepositoryFirebird: IListaTarefasRepository {

        private const String SQL_SELECT = "SELECT L.ID, L.NOME FROM LISTAS_TAREFAS L";
        private const String SQL_INSERT = "INSERT INTO LISTAS_TAREFAS(ID, NOME) VALUES(@ID, @NOME)";
        private const String SQL_UPDATE = "UPDATE LISTAS_TAREFAS L SET L.ID = @ID, L.NOME = @NOME WHERE L.ID = @ID";
        private const String SQL_DELETE = "DELETE FROM LISTAS_TAREFAS L WHERE L.ID = @ID";
        private const String SQL_SELECT_FROM_GENERATOR = "SELECT GEN_ID(GEN_ID_LISTAS_TAREFAS, 1) FROM RDB$DATABASE";

        private FbConnection conexao { get; }

        public ListaRepositoryFirebird(FbConnection conexao) {
            this.conexao = conexao;
        }

        public String Insert(ListaDeTarefas lista) {
            FbCommand comando = new FbCommand(SQL_INSERT, conexao);
            comando.Parameters.AddWithValue("@ID", lista.Id);
            comando.Parameters.AddWithValue("@NOME", lista.Nome);
            comando.ExecuteNonQuery();
            return "Lista adicionada com sucesso!";
        }

        public String Delete(ListaDeTarefas lista) {
            FbCommand comando = new FbCommand(SQL_DELETE, conexao);
            comando.Parameters.AddWithValue("@ID", lista.Id);
            comando.ExecuteNonQuery();
            return "Lista excluída com sucesso!";
        }

        public String Update(ListaDeTarefas lista) {
            FbCommand comando = new FbCommand(SQL_UPDATE, conexao);
            comando.Parameters.AddWithValue("@ID", lista.Id);
            comando.Parameters.AddWithValue("@NOME", lista.Nome);
            comando.ExecuteNonQuery();
            return "Lista adicionada com sucesso!";
        }

        public List<ListaDeTarefas> SelectAll() {
            List<ListaDeTarefas> listas = new List<ListaDeTarefas>();
            FbCommand comando = new FbCommand(SQL_SELECT, conexao);
            FbDataReader reader = comando.ExecuteReader();
            while (reader.Read()) {
                ListaDeTarefas lista = new ListaDeTarefas(reader.GetInt64(0), reader.GetString(1));
                listas.Add(lista);
            }
            return listas;
        }

        public Int64 GetNextId() {
            Int64 id = 0;
            FbCommand comando = new FbCommand(SQL_SELECT_FROM_GENERATOR, conexao);
            FbDataReader reader = comando.ExecuteReader();
            while (reader.Read()) {
                id = reader.GetInt64(0);
            }
            return id;
        }

    }

}