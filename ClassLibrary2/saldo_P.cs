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
    
    public partial class saldo_P
    {
        public saldo_P()
        {
            this.cliente = new HashSet<cliente>();
        }
    
        public int id_saldop { get; set; }
        public Nullable<decimal> importe { get; set; }
        public Nullable<decimal> cobrado { get; set; }
        public Nullable<decimal> pendiente { get; set; }
    
        public virtual ICollection<cliente> cliente { get; set; }
    }
}
