namespace GestaoDeTarefas {

    public static class QueryBuilder {

        private static String ArrayToString(String[] strings) {
            String str = "";
            foreach (String s in strings) {
                str = !str.Equals("") ? $"{str},{s}" : s;
            }
            return str;
        }

        public static String DbInsert(String tableName, String[] colluns, String[] values) {
            String sql = $"insert into {tableName} ({ArrayToString(colluns)}) values ({ArrayToString(values)})";
            return sql;
        }

        public static String DbDelete(String tableName, String id) {
            String sql = $"Delete from {tableName} t where t.id = {id}";
            return sql;
        }

        public static String DbSelect(String tableName, Boolean comWhere = false, String id = "") {
            String sql = $"select * from {tableName} t";
            if (comWhere && !id.Equals("")) {
                sql = sql + $" where t.id = {id}";
            }
            return sql;
        }
    }
}