using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace EmsTests
{
    public class ManagerFixture
    {
        private readonly EmsContext _context;
        private List<Manager> _managers = new List<Manager>()
        {
            new Manager(){Id=1,Name="vighnesh",Salary=600000},
            new Manager(){Id=2,Name="shubham",Salary=600000},
            new Manager(){Id=3,Name="bhanu",Salary=600000},
            new Manager(){Id=4,Name="raunak",Salary=600000},
            new Manager(){Id=5,Name="omkar",Salary=600000}
        };

        [Fact]
        public void get_all_managers_should_return_all_managers()
        {
            var controller = new ManagerController(_context,_managers);

            //List<Manager> result = controller.GetManagers() as List<Manager>;
        }
    }
}
