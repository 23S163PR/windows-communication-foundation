//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace transaction_scope_demo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderLine = new HashSet<OrderLine>();
        }
    
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal OrderTotal { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}