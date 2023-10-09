using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=agenda;User ID=sa;Password=1q2w3e4r@#$;");

    }
}