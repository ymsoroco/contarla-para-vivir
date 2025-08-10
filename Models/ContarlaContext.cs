using Contarla_Para_Vivir_PNT.Models;
using Microsoft.EntityFrameworkCore;

namespace ContarlaParaVivir.Models
{
    public class ContarlaContext : DbContext
    {
        public ContarlaContext(DbContextOptions<ContarlaContext> options)
            : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<DosisLiteraria> DosisLiterarias { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contacto> Contactos { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<Inscripcion>()
                .Property(i => i.Estado)
                .HasConversion<string>();

            base.OnModelCreating(modelBuilder);
        }
    }
}

