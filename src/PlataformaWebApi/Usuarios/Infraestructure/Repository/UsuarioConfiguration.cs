using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Infraestructure.Repository
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.OwnsOne(m => m.ID, a =>
            {
                a.Property(p => p.Id)
                    .HasColumnName("Id")
                    .HasDefaultValue(1);
            });
            builder.OwnsOne(m => m.Nombre, a =>
            {
                a.Property(p => p.Nombre)
                    .HasColumnName("Nombre")
                    .HasDefaultValue("");                
            });
            builder.OwnsOne(m => m.Apellido, a =>
            {
                a.Property(p => p.Apellido)
                    .HasColumnName("Apellido")
                    .HasDefaultValue("");
            });
            builder.OwnsOne(m => m.Edad, a =>
            {
                a.Property(p => p.Edad)
                    .HasColumnName("Edad")
                    .HasDefaultValue(0);
            });
            builder.OwnsOne(m => m.Email, a =>
            {
                a.Property(p => p.Email)
                    .HasColumnName("Email")
                    .HasDefaultValue("");
            });

        }
    }
}
