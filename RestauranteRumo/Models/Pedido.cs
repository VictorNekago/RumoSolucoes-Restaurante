using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauranteRumo.Models
{
    public class Pedido
    {
        public int Identificador { get; set; }
        public string NomeSolicitante { get; set; }


        public int NumeroMesa { get; set; }

        public int IdentificadorPrato { get; set; }

        public Prato Prato { get; set; }

        public int IdentificadorBebida { get; set; }

        public Bebida Bebida { get; set; }




        //  public ICollection<Bebida> ListaBebibas { get; set; }

        //  public ICollection<Prato> ListaPrato { get; set; }

    }

    
}