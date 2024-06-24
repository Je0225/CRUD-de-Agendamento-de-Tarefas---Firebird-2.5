namespace GestaoDeTarefas {

     record ConstrutorDeQueries {

        private static String ArrayEmString(String[] strings) { 
            String str = "";
            foreach (String s in strings) {
                str = !str.Equals("") ? $"{str},{s}" : s;
            }
            return str;
        }

        private  String IntercalaValoresEColunas(String[] colluns, String[] values) {
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

        protected String QueryInsert(String tableName, String[] colluns, String[] values) {
            return $"insert into {tableName} ({ArrayEmString(colluns)}) values ({ArrayEmString(values)})";
        }

        protected String QueryUpdate(String tableName, String[] colluns, String[] values, Int64 idObject) {
            return $"update {tableName} t set {IntercalaValoresEColunas(colluns, values)} where t.id = {idObject}"; 
        }

        protected String QueryDelete(String tableName, Int64 id) {
            return $"Delete from {tableName} t where t.id = {id}";
        }

        protected String QuerySelect(String tableName, Boolean comWhere = false, Int64 id = -1) {
            String sql = $"select * from {tableName} t";
            if (comWhere && !id.Equals(-1)) {
                sql = sql + $" where t.id = {id}";
            }
            return sql;
        }

        protected String QuerySelectGeneratorId(String GeneratorName) {
            return $"SELECT GEN_ID( {GeneratorName}, 1 ) FROM RDB$DATABASE;";
        }
    }

}