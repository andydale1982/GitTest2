using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFSandbox.Web.Models
{
    public class EFSandboxDbContextInitializer : DropCreateDatabaseAlways<EFSandboxDbContext>
    {
        protected override void Seed(EFSandboxDbContext context)
        {
            context.Artists.Add(new Artist() { Name = "Name 1" });
            context.Artists.Add(new Artist() { Name = "Name 2" });
            context.SaveChanges();
        }
    }
}