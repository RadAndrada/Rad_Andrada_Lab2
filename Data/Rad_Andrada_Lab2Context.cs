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
    }
}
