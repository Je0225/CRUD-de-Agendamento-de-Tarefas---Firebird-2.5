using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeTarefas
{
    internal class DbAplicacaoContext : DbContext
    {
        public DbAplicacaoContext(DbContextOptions<DbAplicacaoContext>  options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
