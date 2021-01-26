using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteRumo.Models
{
    public class Bebida
    {
        public int Identificador { get; set; }

        [Display(Name = "Nome Bebida")]
        public string Nome { get; set; }

        public int Mililitro { get; set; }

        [Display(Name = "Quantidade Bebida")]
        public int Quantidade { get; set; }


        public ICollection<Pedido> ListaPedidos { get; set; }


    }
}