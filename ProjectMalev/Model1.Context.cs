﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMalev
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AntonEntities : DbContext
    {
        public AntonEntities()
            : base("name=AntonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MasterPhoto> MasterPhoto { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TableApplication> TableApplication { get; set; }
        public virtual DbSet<TableBrand> TableBrand { get; set; }
        public virtual DbSet<TableGender> TableGender { get; set; }
        public virtual DbSet<TableMaster> TableMaster { get; set; }
        public virtual DbSet<TableRepair> TableRepair { get; set; }
        public virtual DbSet<TableRepairApp> TableRepairApp { get; set; }
        public virtual DbSet<TableRole> TableRole { get; set; }
    }
}
