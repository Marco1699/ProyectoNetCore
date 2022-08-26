using System;
using System.Collections.Generic;

#nullable disable

namespace BackEnd1.Entities
{
    public partial class Articulo
    {
        public int Idarticulo { get; set; }
        public int Idcategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }

        public virtual Categorium IdcategoriaNavigation { get; set; }
    }
}
