namespace GestaoDeTarefas {

    public static class ConstrutorDeQueries {

        private static String ArrayEmString(String[] strings) {
            String str = "";
            foreach (String s in strings) {
                str = !str.Equals("") ? $"{str},{s}" : s;
            }
            return str;
        }

        private static String IntercalaValoresEColunas(String[] colluns, String[] values) {
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

        public static String QueryInsert(String TableName, String[] Colluns, String[] Values) {
            return $"insert into {TableName} ({ArrayEmString(Colluns)}) values ({ArrayEmString(Values)})";
        }

        public static String QueryUpdate(String TableName, String[] Colluns, String[] Values, Int64 idObject) {
            return $"update {TableName} t set {IntercalaValoresEColunas(Colluns, Values)} where t.id = {idObject}";
        }

        public static String QueryDelete(String TableName, Int64 Id) {
            return $"Delete from {TableName} t where t.id = {Id}";
        }

        public static String QuerySelect(String TableName, Boolean comWhere = false, Int64 id = -1) {
            String sql = $"select * from {TableName} t";
            if (comWhere && !id.Equals(-1)) {
                sql = sql + $" where t.id = {id}";
            }
            return sql;
        }

        public static String QuerySelectGeneratorId(String GeneratorName) {
            return $"SELECT GEN_ID( {GeneratorName}, 1 ) FROM RDB$DATABASE;";
        }

    }

}