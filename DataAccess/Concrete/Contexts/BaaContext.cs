using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess.Concrete.Contexts
{
    public class BaaContext : DbContext
    {
        private readonly string filePath = @"C:\Basic Accounting Automation\connectionString.txt";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open,FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            string connectionString = streamReader.ReadLine();
            optionsBuilder.UseSqlServer(connectionString);
            streamReader.Close();
            fileStream.Close();
        }
        public DbSet<User> Users { get; set; }
    }
}

