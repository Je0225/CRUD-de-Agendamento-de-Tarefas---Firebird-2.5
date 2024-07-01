﻿using FirebirdSql.Data.FirebirdClient;

namespace GestaoDeTarefas.Repository {

    public static class ConexaoFirebird {

        private static FbConnection conexao;

        public static FbConnection getConnetion() {
            if (conexao == null) {
                conexao = new FbConnection(File.ReadAllText(Environment.CurrentDirectory + "\\Banco\\Firebird.conf"));
            }
            return conexao;
        }

        private static void GetStringConection() {

        }

    }

}