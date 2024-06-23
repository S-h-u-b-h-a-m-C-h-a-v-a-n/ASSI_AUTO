using AUTOMACTIC_INFOTECH_ASSIGMENT.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VendorApp.Models;

namespace VendorApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Material> Material { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
