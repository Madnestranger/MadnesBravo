//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectPharmacy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicineDelivery
    {
        public System.Guid MedicineId { get; set; }
        public System.Guid DeliveryId { get; set; }
        public int Quantity { get; set; }
        public System.Guid Id { get; set; }
    
        public virtual Delivery Delivery { get; set; }
        public virtual Medicine Medicine { get; set; }
    }
}
