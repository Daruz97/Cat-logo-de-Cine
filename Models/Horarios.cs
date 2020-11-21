using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cine.Models
{
    public class Horarios
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Hora { get; set; }
        public decimal? Precio{ get; set; }
    }
}