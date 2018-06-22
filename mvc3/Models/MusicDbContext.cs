using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace mvc3.Models
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public System.Data.Entity.DbSet<mvc3.Models.Genre> Genres { get; set; }
    }
}