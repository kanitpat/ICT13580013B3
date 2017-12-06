using System;
using ICT13580013B3.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace ICT13580013B3.Api.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products
        {
            get;
            set;
        }
        public MyDbContext(DbContextOptions<MyDbContext> options) :base(options)
        {
        }
    }
}
