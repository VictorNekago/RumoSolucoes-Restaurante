using RestauranteRumo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace RestauranteRumo.ModeloConfigEF
{
    public class PedidoConfiguration:EntityTypeConfiguration<Pedido>
    {
        public PedidoConfiguration()
        {
            HasKey(c => c.Identificador);

            Property(c => c.Identificador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.NomeSolicitante)
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.NumeroMesa)
             .IsRequired();


            HasRequired(x => x.Prato)
                 .WithMany(x => x.ListaPedidos)
                 .HasForeignKey(x => x.IdentificadorPrato);




            HasRequired(x => x.Bebida)
                 .WithMany(x => x.ListaPedidos)
                 .HasForeignKey(x => x.IdentificadorBebida);


        }

    }
}