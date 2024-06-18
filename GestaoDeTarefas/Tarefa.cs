using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using FirebirdSql.Data;

namespace GestaoDeTarefas
{
    public class Tarefa : Model{

        public Int32 Id { get; set; }
        public override String TableName { get; set; }

        public String Titulo { get; set; }

        public String Descricao { get; set; }

        public DateTime Data { get; set; }

        public Status Status { get; set; }

        public Tarefa(int id, string titulo, string descricao, DateTime data, Status status)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Data = data;
            Status = status;
            TableName = "tarefas";
        }

        public override String[] GetValues() {
            return new[] { Titulo, Descricao, Data.ToString(CultureInfo.CurrentCulture), Status.ToString() };
        }

        public override String[] DbCollumns() {
            return new[] { "id", "titulo", "Descricao", "data", "status" };
        }

    }
}
