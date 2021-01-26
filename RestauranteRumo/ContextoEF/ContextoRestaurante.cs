using RestauranteRumo.ModeloConfigEF;
using RestauranteRumo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace RestauranteRumo.ContextoEF
{
    public class ContextoRestaurante : DbContext
    {
        public ContextoRestaurante() : base("name=ConexaoPrincipal")
        {

        }
        public DbSet<Pedido> PedidoDBset { get; set; }
        public DbSet<Bebida> BebidaDBSet { get; set; }
        public DbSet<Prato> PratoDBSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            Configuration.LazyLoadingEnabled = false;

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new PedidoConfiguration());
            modelBuilder.Configurations.Add(new PratoConfiguration());
            modelBuilder.Configurations.Add(new BebidaConfiguration());

        }





    }
}