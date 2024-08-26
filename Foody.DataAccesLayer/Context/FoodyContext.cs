using Foody_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccesLayer.Context
{
    public class FoodyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0M1OPMD\\SQLEXPRESS50;initial catalog=FoodyDatabase;integrated security=true;TrustServerCertificate=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
