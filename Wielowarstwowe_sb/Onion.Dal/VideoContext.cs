using Microsoft.EntityFrameworkCore;
using Onion.Dal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Dal
{
    public class VideoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("video");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Video> Videos { get; set; }


    }
}
