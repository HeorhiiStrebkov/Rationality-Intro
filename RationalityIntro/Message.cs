//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RationalityIntro
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int Id { get; set; }
        public Nullable<int> ActId { get; set; }
        public string Text { get; set; }
    
        public virtual Act Act { get; set; }
    }
}
