﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ScriptsControlBackgroundContainer : DbContext
    {
        public ScriptsControlBackgroundContainer()
            : base("name=ScriptsControlBackgroundContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_Game> tb_GameSet { get; set; }
        public virtual DbSet<tb_User> tb_UserSet { get; set; }
        public virtual DbSet<tb_Plan> tb_PlanSet { get; set; }
        public virtual DbSet<UserSet> UserSet { get; set; }
    }
}
