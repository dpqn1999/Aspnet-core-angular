using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.data.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.data.EF
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
