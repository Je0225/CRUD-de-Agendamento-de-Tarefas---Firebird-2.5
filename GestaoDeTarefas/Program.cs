using FirebirdSql.Data.FirebirdClient;
using GestaoDeTarefas.Repository;
using GestaoDeTarefas.Service;

namespace GestaoDeTarefas {

    internal static class Program {

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            FormSelecionaConexao frmSelecionaConexao = new FormSelecionaConexao();
            Application.Run(frmSelecionaConexao);
            if (frmSelecionaConexao.DialogResult != DialogResult.OK) {
                return;
            }
            FbConnection connection = ConexaoFirebird.getConnetion(frmSelecionaConexao.ConexaoSelecionada);
            connection.Open();

            TarefaRepositoryFirebird repositoryTarefas = new TarefaRepositoryFirebird(connection);
            ListaRepositoryFirebird repositoryListas = new ListaRepositoryFirebird(connection);
            TarefasServices tarefasServices = new TarefasServices(repositoryTarefas);
            ListasDeTarefasServices listasServices = new ListasDeTarefasServices(repositoryListas);

            Application.Run(new FormPrincipal(tarefasServices, listasServices));

            connection.Close();
        }

    }

}