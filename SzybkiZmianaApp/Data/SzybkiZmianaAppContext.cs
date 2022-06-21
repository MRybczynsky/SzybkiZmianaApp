using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SzybkiZmianaApp.Models;

namespace SzybkiZmianaApp.Data
{
    public class SzybkiZmianaAppContext : DbContext
    {
        public SzybkiZmianaAppContext (DbContextOptions<SzybkiZmianaAppContext> options)
            : base(options)
        {
        }

        public DbSet<SzybkiZmianaApp.Models.Problem> Problems { get; set; }

        public DbSet<SzybkiZmianaApp.Models.Client> Client { get; set; }
    }
}
