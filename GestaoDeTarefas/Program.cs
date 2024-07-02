using FirebirdSql.Data.FirebirdClient;
using GestaoDeTarefas.Repository;
using GestaoDeTarefas.Service;

namespace GestaoDeTarefas
{

    internal static class Program {

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            FbConnection connection = ConexaoFirebird.getConnetion();
            connection.Open();

            TarefaRepositoryFirebird repositoryTarefas = new TarefaRepositoryFirebird(connection);
            ListaRepositoryFirebird repositoryListas = new ListaRepositoryFirebird(connection);
            TarefasServices tarefasServices = new TarefasServices(repositoryTarefas);
            ListasDeTarefasServices listasServices = new ListasDeTarefasServices(repositoryListas);

            ApplicationConfiguration.Initialize();
            Application.Run(new FormSelecionaConexao());
            Application.Run(new FormPrincipal(tarefasServices, listasServices));

            connection.Close();
        }

    }

}