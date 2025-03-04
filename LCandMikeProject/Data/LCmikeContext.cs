﻿using System;
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
        public DbSet<Item> Item { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<LCandMikeProject.Model.OrderLine> OrderLine { get; set; } = default!;
        public DbSet<LCandMikeProject.Model.Employee> Employee { get; set; } = default!;
    }
}
