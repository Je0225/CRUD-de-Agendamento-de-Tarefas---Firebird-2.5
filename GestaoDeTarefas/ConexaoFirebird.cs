using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas
{
    public static class ConexaoFirebird {

        private static String strConexao => File.ReadAllText(Environment.CurrentDirectory + "\\Banco\\Firebird.conf"); //to do: read more than one string connection
        public static FbConnection conexao => new FbConnection(strConexao); // to do: create and close conexao in class program
    }
}
