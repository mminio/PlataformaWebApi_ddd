using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Infraestructure.Repository.Entity_Framework
{
    public class CredencialesConfigurationEF : IEntityTypeConfiguration<Credenciales.Domain.Credenciales>
    {
        public void Configure(EntityTypeBuilder<Credenciales.Domain.Credenciales> builder)
        {
            builder.OwnsOne(m => m._User, a =>
            {
                a.Property(p => p._Username)
                    .HasColumnName("_User")
                    .HasDefaultValue("");
            });
            builder.OwnsOne(m => m._Password, a =>
            {
                a.Property(p => p._Password)
                    .HasColumnName("_Password")
                    .HasDefaultValue("");
            });
        }
    }
}
