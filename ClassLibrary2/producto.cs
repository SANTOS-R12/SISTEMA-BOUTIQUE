//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary2
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        public producto()
        {
            this.pedido = new HashSet<pedido>();
            this.venta = new HashSet<venta>();
        }
    
        public int id_producto { get; set; }
        public decimal precio { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public int id_categoria { get; set; }
    
        public virtual categoria categoria { get; set; }
        public virtual ICollection<pedido> pedido { get; set; }
        public virtual ICollection<venta> venta { get; set; }
    }
}
