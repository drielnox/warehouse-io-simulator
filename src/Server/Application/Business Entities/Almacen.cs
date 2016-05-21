using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Entities
{
    public class Almacen
    {
        public IEnumerable<Zona> Zonas { get; set; }

        public Almacen()
        {
            Zonas = new List<Zona>();
        }
    }
}
