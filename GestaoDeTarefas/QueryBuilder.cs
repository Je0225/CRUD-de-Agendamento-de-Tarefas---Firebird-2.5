using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String = System.String;

namespace GestaoDeTarefas
{
    public static class QueryBuilder
    {

        private static String PreparaQuery(String query, String[] colluns, String[] values){
            String strColluns = "";
            String strValues = "";

            foreach (String c in values)
            {
                String col = c;
                col = col.Insert(0, "'");
                col = col.Insert(col.Length, "'");
                if (strValues.Equals(""))
                {
                    strValues = col;
                }
                else
                {
                    strValues = $"{strValues},{col}";
                }
            }

            foreach (String c in colluns)
            {
                strColluns = $"{strColluns}, {c}";
            }
            query = query.Replace("[colluns]", strColluns).Replace("[values]", strValues);
            return query;
        }

        public static String DbInsert(String tableName, String[] colluns, String[] values)
        {
            String sql = "insert into [tabela] ([collumns]) values ([values])";
            sql = PreparaQuery(sql.Replace("[tabela]", tableName), colluns, values);
            return sql;
        }
    }
}
