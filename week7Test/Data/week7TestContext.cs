using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using week7Test.Models;

namespace week7Test.Data
{
    public class week7TestContext : DbContext
    {
        public week7TestContext (DbContextOptions<week7TestContext> options)
            : base(options)
        {
        }

        public DbSet<week7Test.Models.ToDo> ToDo { get; set; } = default!;
    }
}
