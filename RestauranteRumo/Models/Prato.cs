using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteRumo.Models
{
    public class Prato
    {
        public int Identificador { get; set; }

        [Display(Name = "Nome Prato")]
        public string Nome { get; set; }

        [Display(Name = "Quantidade Prato")]
        public int Quantidade { get; set; }

        public ICollection<Pedido> ListaPedidos { get; set; }
    }
}