﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReviewsMVC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_A3F963_reviewsEntities : DbContext
    {
        public DB_A3F963_reviewsEntities()
            : base("name=DB_A3F963_reviewsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<userStoryDEV> userStoryDEV { get; set; }
        public virtual DbSet<userStory> userStory { get; set; }
        public virtual DbSet<contact> contact { get; set; }
    }
}
