using System;
using Microsoft.EntityFrameworkCore;
using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Infraestructure.Repository;


#nullable disable

namespace PlataformaWebApi.Shared.Repository
{
    
    public partial class PlataformaWebApiContext : DbContext
    {
        public PlataformaWebApiContext()
        {
        }

        public PlataformaWebApiContext(DbContextOptions<PlataformaWebApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=server28.intecsoft.com.ar;Initial Catalog=dbPlataformaWebApi;User ID=sa;Password=sasa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Usuario>().HasKey(t => t.Id);
            modelBuilder.ApplyConfiguration(new UsuarioConfigurationEF());            
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AI");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
