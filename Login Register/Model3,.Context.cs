﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login_Register
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OgrBilSisEntities1 : DbContext
    {
        public OgrBilSisEntities1()
            : base("name=OgrBilSisEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolumler> Bolumler { get; set; }
        public virtual DbSet<Dersler> Dersler { get; set; }
        public virtual DbSet<Fakulteler> Fakulteler { get; set; }
        public virtual DbSet<Ogrenciler> Ogrenciler { get; set; }
    }
}
