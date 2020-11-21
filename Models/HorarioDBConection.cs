using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

    public class HorarioDBConection : DbContext
    {
        public HorarioDBConection() : base("Horariodb")
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
    }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
    }
}
}


    
    
