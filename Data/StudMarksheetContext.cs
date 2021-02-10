using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationCoreFirst.ExtensionClass;

namespace WebApplicationCoreFirst.Data
{
    public class StudMarksheetContext : DbContext
    {
        public StudMarksheetContext (DbContextOptions<StudMarksheetContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ResultMyDB();
        }

        public DbSet<WebApplicationCoreFirst.Data.StudResult> StudResult { get; set; }
    }
}
