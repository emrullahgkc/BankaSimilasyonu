﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankaHesabi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BankaHesabEntitiess : DbContext
    {
        public BankaHesabEntitiess()
            : base("name=BankaHesabEntitiess")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Banka> tbl_Banka { get; set; }
        public virtual DbSet<tbl_kul_bnk> tbl_kul_bnk { get; set; }
        public virtual DbSet<tbl_kullanici> tbl_kullanici { get; set; }
        public virtual DbSet<tbl_kullanicihareket> tbl_kullanicihareket { get; set; }
    }
}
