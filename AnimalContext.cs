using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Quete_EntityFrameworkLINQ
{
    class AnimalContext : DbContext
    {
        public virtual DbSet<Animal> Animal { get; set; }

        public virtual DbSet<Species> Species { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LOCALHOST\SQLEXPRESS;Database=Species;Integrated Security=True");
        }
    }
}