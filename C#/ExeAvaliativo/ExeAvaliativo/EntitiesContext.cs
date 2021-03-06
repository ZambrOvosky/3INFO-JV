﻿using ExeAvaliativo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using System.Configuration;

namespace ExeAvaliativo {
    public class EntitiesContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<ProdSale> ProdSales { get; set; }

        //NuGet Console:
        //Install-Package EntityFramework.MicrosoftSqlserver -Version 7.0.0-rc1-final -Pre
        //Install-Package EntityFramework.Commands -Version 7.0.0-rc1-final -Pre
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string stringConnection = ConfigurationManager.ConnectionStrings["dbLojaVirtualConn"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConnection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
