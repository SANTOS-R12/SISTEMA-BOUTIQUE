//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalle
    {
        public detalle()
        {
            this.venta = new HashSet<venta>();
        }
    
        public int id_detalle { get; set; }
        public int cantidad { get; set; }
        public int id_pastel { get; set; }
    
        public virtual pasteles pasteles { get; set; }
        public virtual ICollection<venta> venta { get; set; }
    }
}
