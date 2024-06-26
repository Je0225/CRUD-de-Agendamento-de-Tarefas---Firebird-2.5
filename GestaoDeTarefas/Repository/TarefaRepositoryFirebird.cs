﻿using FirebirdSql.Data.FirebirdClient;
using GestaoDeTarefas.Domain;

namespace GestaoDeTarefas.Repository {

    internal class TarefaRepositoryFirebird: ITarefaRepository {

        private const String SQL_INSERT = "INSERT INTO TAREFAS (ID, TITULO, DESCRICAO, DATA, STATUS, LISTA) VALUES (@ID, @TITULO, @DESCRICAO, @DATA, @STATUS, @LISTA)";
        private const String SQL_DELETE = "DELETE FROM TAREFAS T WHERE T.ID = @ID";
        private const String SQL_UPDATE = "UPDATE  TAREFAS T SET TITULO = @TITULO, DESCRICAO = @DESCRICAO, STATUS = @STATUS, LISTA = @LISTA WHERE T.ID = @ID";
        private const String SQL_SELECT_ALL = "SELECT T.ID, T.TITULO, T.DESCRICAO, T.DATA, T.STATUS, T.LISTA FROM TAREFAS T";
        private const String SQL_SELECT_WHERE = "SELECT T.ID, T.TITULO, T.DESCRICAO, T.DATA, T.STATUS, T.LISTA FROM TAREFAS T WHERE T.LISTA = @IDLISTA";
        private const String SQL_SELECT_WHERE_LISTA = "SELECT L.ID, L.NOME FROM LISTAS_TAREFAS L WHERE L.ID = @ID";
        private const String SQL_GENERATOR = "SELECT GEN_ID(GEN_ID_TAREFAS, 1) FROM RDB$DATABASE";

        private FbConnection conexao { get; }

        public TarefaRepositoryFirebird(FbConnection conexao) {
            this.conexao = conexao;
        }

        public String Insert(Tarefa tarefa) {
            FbCommand comando = new FbCommand(SQL_INSERT, conexao);
            comando.Parameters.AddWithValue("@ID", tarefa.Id);
            comando.Parameters.AddWithValue("@TITULO", tarefa.Titulo);
            comando.Parameters.AddWithValue("@DESCRICAO", tarefa.Descricao);
            comando.Parameters.AddWithValue("@DATA", tarefa.Data);
            comando.Parameters.AddWithValue("@STATUS", tarefa.Status);
            comando.Parameters.AddWithValue("@LISTA", tarefa.Lista.Id);
            comando.ExecuteNonQuery();
            return @"Tarefa adicionada com sucesso!";
        }

        public String Delete(Tarefa tarefa) {
            FbCommand comando = new FbCommand(SQL_DELETE, conexao);
            comando.Parameters.AddWithValue("@ID", tarefa.Id);
            comando.ExecuteNonQuery();
            return @"Tarefa excluída com sucesso!";
        }

        public String Update(Tarefa tarefa) {
            FbCommand comando = new FbCommand(SQL_UPDATE, conexao);
            comando.Parameters.AddWithValue("@ID", tarefa.Id);
            comando.Parameters.AddWithValue("@TITULO", tarefa.Titulo);
            comando.Parameters.AddWithValue("@DESCRICAO", tarefa.Descricao);
            comando.Parameters.AddWithValue("@STATUS", tarefa.Status);
            comando.Parameters.AddWithValue("@LISTA", tarefa.Lista.Id);
            comando.ExecuteNonQuery();
            return @"Tarefa editada com sucesso!";
        }

        public List<Tarefa> SelectAll() {
            FbCommand comando = new FbCommand(SQL_SELECT_ALL, conexao);
            comando.ExecuteNonQuery();
            FbDataReader reader = comando.ExecuteReader();
            return CriaListaTarefas(reader);
        }

        private ListaDeTarefas? CriaObjetoDeLista(Int64 idLista) {
            ListaDeTarefas? lista = null;

            FbCommand buscaLista = new FbCommand(SQL_SELECT_WHERE_LISTA, conexao);
            buscaLista.Parameters.AddWithValue("@ID", idLista);
            buscaLista.ExecuteNonQuery();
            FbDataReader readerLista = buscaLista.ExecuteReader();
            if (readerLista == null) {
                return null;
            }
            while (readerLista.Read()) {
                lista = new ListaDeTarefas(readerLista.GetInt64(0), readerLista.GetString(1));
            }
            return lista;
        }

        private List<Tarefa> CriaListaTarefas(FbDataReader reader) {
            List<Tarefa> tarefas = new List<Tarefa>();
            while (reader.Read()) {
                ListaDeTarefas? lista = CriaObjetoDeLista(reader.GetInt64(5));
                if (lista != null) {
                    Tarefa tarefa = new Tarefa(reader.GetInt64(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(4),
                        lista);
                    tarefas.Add(tarefa);
                }
            }
            return tarefas;
        }

        public Int64 GetNextId() {
            FbCommand comando = new FbCommand(SQL_GENERATOR, conexao);
            comando.ExecuteNonQuery();
            FbDataReader reader = comando.ExecuteReader();
            reader.Read();
            return reader.GetInt64(0);
        }

        public List<Tarefa> BuscaTarefasDaLista(Int64 id) {
            List<Tarefa> tarefas = new List<Tarefa>();
            FbCommand comando = new FbCommand(SQL_SELECT_WHERE, conexao);
            comando.Parameters.AddWithValue("@IDLISTA", id);
            comando.ExecuteNonQuery();
            FbDataReader reader = comando.ExecuteReader();
            tarefas = CriaListaTarefas(reader);
            return tarefas;
        }

    }

}