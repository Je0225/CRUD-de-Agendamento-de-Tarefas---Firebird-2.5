using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using FirebirdSql.Data;

namespace GestaoDeTarefas
{
    public class Tarefa : Model {

        public override String TableName { get; set; }

        public String Titulo { get; set; }

        public String Descricao { get; set; }

        public DateTime Data { get; set; }

        public Status Status { get; set; }
        public override string[] GetValues { get; set; }
        public override string[] DbCollumns { get; set; }

        public Tarefa(int id, string titulo, string descricao, DateTime data, Status status){
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Data = data;
            Status = status;
            TableName = "tarefas";
            GetValues = new[] {Id.ToString(), Titulo, Descricao, Data.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), Status.ToString()};
            DbCollumns = new[] { "id", "titulo", "Descricao", "data", "status" };
        }
    }
}
