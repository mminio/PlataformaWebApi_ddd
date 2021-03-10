using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using LoginApi.Repository.Models;
using Common.Models;

#nullable disable

namespace Common
{
    public partial class LoginApiDbContext : DbContext
    {
        public LoginApiDbContext()
        {
        }

        public LoginApiDbContext(DbContextOptions<LoginApiDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DatosUsuario> DatosUsuarios { get; set; }
        public virtual DbSet<Credenciales> Credenciales { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=dbTestApi;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DatosUsuario>(entity =>
            {
                entity.Property(e => e.Apellido).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Credenciales>(entity =>
            {
                entity.Property(e => e._User).IsUnicode(false);

                entity.Property(e => e._Password).IsUnicode(false);

                
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
