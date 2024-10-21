using Microsoft.EntityFrameworkCore;
using System.Threading;
using TareasAPI.Models;

namespace TareasAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarea>()
                .HasMany(t => t.Etiquetas)
                .WithMany(e => e.Tareas)
                .UsingEntity(j => j.ToTable("TareasEtiquetas"));
        }
    }
}