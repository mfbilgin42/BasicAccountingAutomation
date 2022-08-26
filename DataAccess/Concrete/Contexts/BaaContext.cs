﻿using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Contexts
{
    public class BaaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MFBILGIN\MFBILGIN;Database=BaaDatabase;Trusted_Connection=true");
        }
        public DbSet<User> Users { get; set; }
    }
}

