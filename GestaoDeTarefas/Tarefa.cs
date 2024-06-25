using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using FirebirdSql.Data;

namespace GestaoDeTarefas
{
    public class Tarefa : Model {

        public String Titulo { get; set; }

        public String Descricao { get; set; }

        public DateTime Data { get; set; }

        public String Status { get; set; }

        public ListaDeTarefas Lista { get; set; }

        public override string[] GetValues { get; set; }

        public Tarefa(Int64 id, string titulo, string descricao, DateTime data, String status, ListaDeTarefas lista) {
            Titulo = titulo;
            Descricao = descricao;
            Data = data;
            Status = status;
            Id = id;
            Lista = lista;
            GetValues = new[] { Id.ToString(), $"'{Titulo}'", $"'{Descricao}'", $"'{Data.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}'", $"'{Status}'", lista.Id.ToString()};
        }
    }
}
