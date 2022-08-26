using System;
using System.Collections.Generic;

#nullable disable

namespace BackEnd1.Entities
{
    public partial class Proveedore
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public string Correo { get; set; }
    }
}
