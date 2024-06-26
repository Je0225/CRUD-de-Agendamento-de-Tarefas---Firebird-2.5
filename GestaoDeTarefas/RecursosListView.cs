using System.Data;

namespace GestaoDeTarefas {

    public static class RecursosListView {

        public static void MontaColunasListView(ListView lv, String[] collumns) {
            for (int i = 0; i < collumns.Length; i++) {
                lv.Columns.Add(new ColumnHeader { DisplayIndex = i, Text = collumns[i] });
            }
        }

        public static void PopulaListView(ListView lv, DbComandos trListas, DbComandos trTarefas) {
            lv.Items.Clear();
            DataSet? dsLista = trListas.DbGenericSelect();
            if (lv.Tag == "Tarefa") {
                DataSet? dsTarefa = trTarefas.DbGenericSelect();
                BuscaEPopulaTarefas(dsTarefa, lv, trListas);
            } else if (lv.Tag == "ListaDeTarefas" && dsLista is not null) {
                foreach (DataRow linha in dsLista.Tables[0].Rows) {
                    ListaDeTarefas lista = new ListaDeTarefas(linha.Field<Int32>(0), linha.Field<String>(1));
                    lv.Items.Add(new ListViewItem(new[] { lista.Id.ToString(), lista.Nome }) { Tag = lista });
                }
            }
        }

        public static void TarefasDaListaSelecionada(ListView lvTarefa, ListaDeTarefas l, DbComandos trListas)  {
            lvTarefa.Items.Clear();
            DataSet? tarefas = trListas.ExecutaSql($"select * from {Tarefa.TableName} t where t.lista = {l.Id}");
            BuscaEPopulaTarefas(tarefas, lvTarefa, trListas);
        }

        private static void BuscaEPopulaTarefas(DataSet? dsTarefa, ListView lv, DbComandos trLista) {
            if (dsTarefa is not null) {
                foreach (DataRow linha in dsTarefa.Tables[0].Rows) {
                    DataSet? dsLista = trLista.DbSelectWhere(linha.Field<Int32>(5));
                    if (dsLista is not null) {
                        ListaDeTarefas lista = new ListaDeTarefas(dsLista.Tables[0].Rows[0].Field<Int32>(0), dsLista.Tables[0].Rows[0].Field<String>(1));
                        Tarefa t = new Tarefa(linha.Field<Int32>(0),
                            linha.Field<String>(1),
                            linha.Field<String>(2),
                            linha.Field<DateTime>(3),
                            linha.Field<String>(4),
                            lista);
                        lv.Items.Add(new ListViewItem(new[] { t.Id.ToString(), t.Titulo, t.Descricao, t.Data.ToString("d"), t.Status, t.Lista.Nome }) { Tag = t });
                    }
                }
            }
        }
    }
}