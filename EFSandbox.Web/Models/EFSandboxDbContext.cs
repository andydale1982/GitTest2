using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFSandbox.Web.Models
{
    public class EFSandboxDbContext : DbContext
    {
        public DbSet<Promo> Promos { get; set; }

        public DbSet<Artist> Artists { get; set; }
    }
}