using System.Data;
using static GestaoDeTarefas.DbMapeamento;

namespace GestaoDeTarefas {

    public static class ListViewSources {

        private static readonly DbComandos trListas = new DbComandos(TabelaListasTarefas, ColunasListasTarefas, GeneratorListasTarefas);
        private static readonly DbComandos trTarefas = new DbComandos(TabelaTarefas, ColunasTarefas, GeneratorTarefas);

        public static void MontaColunasListView(ListView lv, String[] collumns) {
            for (int i = 0; i < collumns.Length; i++) {
                lv.Columns.Add(new ColumnHeader { DisplayIndex = i, Text = collumns[i] });
            }
        }

        public static void PopulaListView(ListView lv) {
            // verificar se tem algum jeito de criar dsTarefa so quando for necessario
            lv.Items.Clear();
            DataSet? dsTarefa = trTarefas.DbGenericSelect();
            DataSet? dsLista = trListas.DbGenericSelect();
            if (lv.Tag == "Tarefa" && dsTarefa is not null) {
                foreach (DataRow linha in dsTarefa.Tables[0].Rows) {
                    DbComandos trLista = new DbComandos(TabelaListasTarefas, ColunasListasTarefas, GeneratorListasTarefas);
                    DataSet? d = trLista.DbSelectWhere(linha.Field<Int32>(5));
                    ListaDeTarefas lista = new ListaDeTarefas(d.Tables[0].Rows[0].Field<Int32>(0), d.Tables[0].Rows[0].Field<String>(1));
                    Tarefa t = new Tarefa(linha.Field<Int32>(0), linha.Field<String>(1), linha.Field<String>(2), linha.Field<DateTime>(3), linha.Field<String>(4), lista);
                    lv.Items.Add(new ListViewItem(new[] { t.Id.ToString(), t.Titulo, t.Descricao, t.Data.ToString("d"), t.Status, t.Lista.Nome }) { Tag = t });
                }
            } else if (lv.Tag == "ListaDeTarefas" && dsLista is not null) {
                foreach (DataRow linha in dsLista.Tables[0].Rows) {
                    ListaDeTarefas lista = new ListaDeTarefas(linha.Field<Int32>(0), linha.Field<String>(1));
                    lv.Items.Add(new ListViewItem(new[] { lista.Id.ToString(), lista.Nome }) { Tag = lista });
                }
            }
        }

        public static void TarefasDaListaSelecionada(ListView lvTarefa, ListaDeTarefas l) {
            lvTarefa.Items.Clear();
            DataSet? tarefas = trListas.ExecutaSql($"select * from {TabelaTarefas} t where t.lista = {l.Id}");
            if (tarefas is not null) {
                foreach (DataRow linha in tarefas.Tables[0].Rows) {
                    DbComandos trLista = new DbComandos(TabelaListasTarefas, ColunasListasTarefas, GeneratorListasTarefas);
                    DataSet? d = trLista.DbSelectWhere(linha.Field<Int32>(5));
                    ListaDeTarefas lista = new ListaDeTarefas(d.Tables[0].Rows[0].Field<Int32>(0), d.Tables[0].Rows[0].Field<String>(1));
                    Tarefa t = new Tarefa(linha.Field<Int32>(0), linha.Field<String>(1), linha.Field<String>(2), linha.Field<DateTime>(3), linha.Field<String>(4), lista);
                    lvTarefa.Items.Add(new ListViewItem(new[] { t.Id.ToString(), t.Titulo, t.Descricao, t.Data.ToString("d"), t.Status, t.Lista.Nome }) { Tag = t });
                }
            }
        }
    }

}