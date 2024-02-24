using Microsoft.EntityFrameworkCore;
using MinimalStock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MinimalStock.Persistance
{
    public class MinimalStockContext : DbContext
    {
        public DbSet<Field> Fields { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryConfiguration> CategoriesConfiguration { get; set; }

        public string DbPath { get; }

        public MinimalStockContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            // Make sure the folder MinimalStock is created before executing Update-Database
            DbPath = System.IO.Path.Join(path, "MinimalStock\\stock.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
