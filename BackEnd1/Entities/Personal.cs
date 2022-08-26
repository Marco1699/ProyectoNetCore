using System;
using System.Collections.Generic;

#nullable disable

namespace BackEnd1.Entities
{
    public partial class Personal
    {
        public int IdPersonal { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
    }
}
