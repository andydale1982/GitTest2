﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSandbox.Web.Models.Repositories
{
    public class ArtistRepository : Repository<Artist>
    {
        public List<Artist> GetByName(string name)
        {
            return DbSet.Where(a => a.Name.Contains(name)).ToList();
        }

    }
}