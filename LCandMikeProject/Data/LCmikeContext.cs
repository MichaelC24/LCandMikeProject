using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LCandMikeProject.Model;

namespace LCandMikeProject.Data
{
    public class LCmikeContext : DbContext
    {
        public LCmikeContext (DbContextOptions<LCmikeContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<LCandMikeProject.Model.Item> Item { get; set; } = default!;
        public DbSet<Order> Order { get; set; } = default!;
        public DbSet<LCandMikeProject.Model.OrderLine> OrderLine { get; set; } = default!;
    }
}
