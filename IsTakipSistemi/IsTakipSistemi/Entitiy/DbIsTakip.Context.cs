﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsTakipSistemi.Entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbIsTakipEntitiesUP1 : DbContext
    {
        public DbIsTakipEntitiesUP1()
            : base("name=DbIsTakipEntitiesUP1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblDepartmanlar> TblDepartmanlars { get; set; }
        public virtual DbSet<TblFirmalar> TblFirmalars { get; set; }
        public virtual DbSet<TblGorevler> TblGorevlers { get; set; }
        public virtual DbSet<TblGorevlerDetaylar> TblGorevlerDetaylars { get; set; }
        public virtual DbSet<TblKullanicilar> TblKullanicilars { get; set; }
        public virtual DbSet<TblPersonel> TblPersonels { get; set; }
    }
}