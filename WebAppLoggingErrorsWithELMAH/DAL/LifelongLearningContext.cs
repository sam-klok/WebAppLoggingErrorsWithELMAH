using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppLoggingErrorsWithELMAH.DAL
{
    public class LifelongLearningContext: DbContext
    {
        public LifelongLearningContext()  : base("LifeLongLearningDatabase")
        { 
        }

        public DbSet<Models.Ludi> Ludi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}