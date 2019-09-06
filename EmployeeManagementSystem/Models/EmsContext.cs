using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class EmsContext : DbContext
    {
        public EmsContext(DbContextOptions<EmsContext> options)
            : base(options)
        {
        }

        public DbSet<Manager> _managers { get; set; }
        public DbSet<Employee> _employees { get; set; }
    }
}
