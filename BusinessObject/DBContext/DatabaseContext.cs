using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeTierArch.Models;

namespace BusinessObject.DBContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(IDbContextOptions options)
        {

        }

        public DbSet<Employees> Employees { get; set; }
    }
}
