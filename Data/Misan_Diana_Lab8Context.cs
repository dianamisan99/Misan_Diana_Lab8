using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Misan_Diana_Lab8.Models;

namespace Misan_Diana_Lab8.Data
{
    public class Misan_Diana_Lab8Context : DbContext
    {
        public Misan_Diana_Lab8Context (DbContextOptions<Misan_Diana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Misan_Diana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Misan_Diana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Misan_Diana_Lab8.Models.Category> Category { get; set; }
    }
}
