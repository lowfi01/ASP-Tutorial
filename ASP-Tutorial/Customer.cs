//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_Tutorial
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsSubscribedToNewsLetter { get; set; }
        public Nullable<int> MembershipTypeId { get; set; }
        public virtual MembershipType MembershipType { get; set; }
    }
}
