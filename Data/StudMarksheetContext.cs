using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationCoreFirst.Data
{
    public class StudMarksheetContext : DbContext
    {
        public StudMarksheetContext (DbContextOptions<StudMarksheetContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationCoreFirst.Data.StudResult> StudResult { get; set; }
    }
}
