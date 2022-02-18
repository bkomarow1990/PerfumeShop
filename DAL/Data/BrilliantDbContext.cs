﻿using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class BrilliantDbContext : DbContext
    {
        public BrilliantDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public virtual DbSet<Product> Products { get;set; }
        public virtual DbSet<Category> Categories { get;set; }
    }
}
