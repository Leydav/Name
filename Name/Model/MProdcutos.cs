using System;
using System.Collections.Generic;
using System.Text;

namespace Name.Model
{
    public class MProductos
    {
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
