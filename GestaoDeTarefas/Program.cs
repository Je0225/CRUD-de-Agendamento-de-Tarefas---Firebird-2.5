
using System.Security.Cryptography.X509Certificates;
using FirebirdSql.Data.FirebirdClient;

namespace GestaoDeTarefas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ConexaoFirebird.conexao.Open();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal());
            ConexaoFirebird.conexao.Close();
        }
    }
}