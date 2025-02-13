using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using EFSessions.Data.Models;

namespace EFSessions.Data.Data_Seeding
{
    internal class DbContextSeed
    {
        public static void Seed (CompanyDbContext dbContext)
        {
            #region Departments
            if (!dbContext.Departments.Any())
            {
                var DepartmentsData = File.ReadAllText("..\\..\\..\\Data\\Data Seeding\\departments.json");
                var Departments = JsonSerializer.Deserialize<List<Department>>(DepartmentsData);
                if (Departments?.Count > 0)
                {
                    foreach (var Department in Departments)
                    {
                        dbContext.Departments.Add(Department); // Add Locally
                    }
                    dbContext.SaveChanges();
                }
            }
            #endregion
            #region Employees
            if(!dbContext.Employees.Any())
            {
                var EmployeesData = File.ReadAllText("..\\..\\..\\Data\\Data Seeding\\employees.json");
                var Employees = JsonSerializer.Deserialize<List<Employee>>(EmployeesData);
                if (Employees?.Count > 0)
                {
                    foreach (var Employee in Employees)
                    {
                        dbContext.Employees.Add(Employee);
                    }
                    dbContext.SaveChanges();
                }
            }
            #endregion
        }
    }
}
