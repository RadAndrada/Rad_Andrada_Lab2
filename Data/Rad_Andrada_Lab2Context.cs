using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rad_Andrada_Lab2.Models;

namespace Rad_Andrada_Lab2.Data
{
    public class Rad_Andrada_Lab2Context : DbContext
    {
        internal object Authors;

        public Rad_Andrada_Lab2Context (DbContextOptions<Rad_Andrada_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Rad_Andrada_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Rad_Andrada_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Rad_Andrada_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Rad_Andrada_Lab2.Models.Category>? Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Borrowing)
            .WithOne(e => e.Book)
                .HasForeignKey<Borrowing>("BookID");
        }

        public DbSet<Rad_Andrada_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Rad_Andrada_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
