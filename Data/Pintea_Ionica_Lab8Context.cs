using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pintea_Ionica_Lab8.Models;

namespace Pintea_Ionica_Lab8.Data
{
    public class Pintea_Ionica_Lab8Context : DbContext
    {
        public Pintea_Ionica_Lab8Context (DbContextOptions<Pintea_Ionica_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pintea_Ionica_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pintea_Ionica_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pintea_Ionica_Lab8.Models.Category> Category { get; set; }

        public DbSet<Pintea_Ionica_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
