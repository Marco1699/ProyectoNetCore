using System;
using System.Collections.Generic;

#nullable disable

namespace BackEnd1.Entities
{
    public partial class Categorium
    {
        public Categorium()
        {
            Articulos = new HashSet<Articulo>();
        }

        public int Idcategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
