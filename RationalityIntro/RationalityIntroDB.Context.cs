﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RationalityIntroDBEntities2 : DbContext
    {
        public RationalityIntroDBEntities2()
            : base("name=RationalityIntroDBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Act> Act { get; set; }
        public virtual DbSet<Human> Human { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}