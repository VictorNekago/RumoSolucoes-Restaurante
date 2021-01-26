using RestauranteRumo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace RestauranteRumo.ModeloConfigEF
{
    public class BebidaConfiguration : EntityTypeConfiguration<Bebida>
    {
        public BebidaConfiguration()
        {
            HasKey(c => c.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.Quantidade)
               .IsRequired();

            Property(c => c.Mililitro)
               .IsOptional();


            
        }
    }
}