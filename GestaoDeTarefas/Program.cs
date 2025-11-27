using FirebirdSql.Data.FirebirdClient;
using GestaoDeTarefas.Ferramentas;
using GestaoDeTarefas.Repository;
using GestaoDeTarefas.Services;

namespace GestaoDeTarefas {

  internal static class Program {
    [STAThread]
    static void Main() {
      ApplicationConfiguration.Initialize();

      FirebirdParser fbParser = new FirebirdParser();
      FirebirdConfServices fbServices = new FirebirdConfServices(fbParser);
      FbConnection conexao;

      if (fbServices.GetEdit() > 0) {
        conexao = new FbConnection(fbServices.GetConexaoPadrao().ToString());
      } else {
        FormSelecionaConexaoPadrao formSelecionaConexaoPadrao = new FormSelecionaConexaoPadrao(fbServices);
        formSelecionaConexaoPadrao.ShowDialog();
        if (formSelecionaConexaoPadrao.DialogResult != DialogResult.OK) {
          return;
        }
        conexao = new FbConnection(formSelecionaConexaoPadrao.ConexaoSelecionada!.ToString());
      }
      conexao.Open();

      TarefaRepositorioFirebird tarefaRepositorioFb = new TarefaRepositorioFirebird(conexao);
      ListaRepositorioFirebird listaRepositorioFb = new ListaRepositorioFirebird(conexao);
      TarefaServices tarefaServices = new TarefaServices(tarefaRepositorioFb);
      ListaDeTarefasServices listaServices = new ListaDeTarefasServices(listaRepositorioFb);

      Application.Run(new FormPrincipal(tarefaServices, listaServices));
      conexao.Close();
    }
  }

}