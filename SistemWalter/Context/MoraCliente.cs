//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemWalter.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class MoraCliente
    {
        public int Id { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> Meses { get; set; }
        public Nullable<decimal> Total { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
