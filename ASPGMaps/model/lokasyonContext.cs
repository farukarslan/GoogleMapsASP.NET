using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ASPGMaps.model
{
    public class lokasyonContext:DbContext
    {
        public lokasyonContext():base("sqlim")
        {


        }
        public DbSet<lokasyon> lokasyonlar { get; set; }

    }
}