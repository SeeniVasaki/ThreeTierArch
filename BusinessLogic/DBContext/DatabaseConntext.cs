using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZHO.BAL.Models;

namespace ZHO.BAL.DBContext
{
    public class DatabaseConntext : DbContext
    {
        public DatabaseConntext(DbContextOptions<DatabaseConntext> options)
        : base(options)
        {

        }

        public DbSet<Employees> Employees { get; set; }
    }
}
