using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }

        public long ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        public Manager Manager { get; set; }
    }
}
