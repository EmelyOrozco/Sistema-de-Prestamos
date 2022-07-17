using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca1
{
    public class Prestamos
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal CantidadSOlicitada { get; set; }
        public decimal Tasa { get; set; }
        public int CantidadMeses { get; set; }
        public string Estado { get; set; }
    }
}
