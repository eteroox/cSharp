﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhoAmI_PC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WhoAmIEntities : DbContext
    {
        public WhoAmIEntities()
            : base("name=WhoAmIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<answer> answers { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Critical> Criticals { get; set; }
        public DbSet<journal> journals { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<player> players { get; set; }
        public DbSet<Stage> Stages { get; set; }
    }
}
