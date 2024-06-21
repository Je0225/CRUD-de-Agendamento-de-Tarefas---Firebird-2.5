namespace GestaoDeTarefas {

    public static class QueryBuilder {

        private static String ArrayToString(String[] strings) { //to do:melhorar nome
            String str = "";
            foreach (String s in strings) {
                str = !str.Equals("") ? $"{str},{s}" : s;
            }
            return str;
        }

        private static String StringKeyValue(String[] colluns, String[] values) { // melhorar o nome
            String str = "";
            for (int i = 0; i < colluns.Length; i++) {
                if (!i.Equals(colluns.Length - 1)) {
                    str += $"t.{colluns[i]} = {values[i]}, ";
                } else {
                    str += $"t.{colluns[i]} = {values[i]}";
                }
            }
            return str;
        }

        public static String DbInsert(String tableName, String[] colluns, String[] values) {
            String sql = $"insert into {tableName} ({ArrayToString(colluns)}) values ({ArrayToString(values)})";
            return sql;
        }

        public static String DbUpdate(String tableName, String[] colluns, String[] values, Int32 idObject) {
            String sql = $"update {tableName} t set {StringKeyValue(colluns,values)} where t.id = {idObject}"; ;
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