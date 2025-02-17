using EFSessions.Data;
using EFSessions.Data.Data_Seeding;
using EFSessions.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace EFSessions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revesion
            // 1- Create CopanyDbContext Class
            // 2- Download Microsoft.EntityFrameworkCore.SqlServer Package
            // 3- Make the class inherite from DbContext
            // 4- override onconfiguring
            // 5- Connection String:
            // optionsBuilder.UseSqlServer("Server=DESKTOP-UFFGN5G;Database=Company;Trusted_Connection=True;Trustservercertificate=true");
            // 6- public DbSet<Employee> Employees { get; set; } // to create employees table
            #endregion
            #region Session 2
            #region Connections
            //CompanyDbContext dbContext = new CompanyDbContext();
            //try
            //{
            //    // CRUD OPERATIONNS
            //}
            //finally
            //{
            //    dbContext.Dispose();
            //}
            // Syntax Sugar:
            //using (CompanyDbContext dbContext = new CompanyDbContext())
            //{

            //}
            // Another Syntax Sugar 
            #endregion
            //using CompanyDbContext dbContext = new CompanyDbContext();


            #endregion
            #region Session 3
            #region CRUD Operations
            #region Insert
            Employee Emp01 = new Employee()
            {
                //Code = 1, // Invalid (Has identity)
                Name = "Rana",
                Age = 22,
                Salary = 2000,
                Email = "ranahatem709@gmail.com",
                Phone = "01111111111",
                Password = "Password"
            };
            Employee Emp02 = new Employee()
            {
                Name = "Nada",
                Age = 22,
                Salary = 4000,
                Email = "nadahatem709@gmail.com",
                Phone = "01111111111",
                Password = "Password"
            };
            // States of an object:
            // 1- Detached: Object isnt related to DB
            // 2- Unchanged: Object is in DB but didnt change
            // 3- Deleted: Object is in DB but will be deleted
            // 4- Added: Object is not in DB and will be added
            //Console.WriteLine(dbContext.Entry(Emp01).State);
            //// Adding
            //// Add Locally
            //dbContext.Employees.Add(Emp01);
            //dbContext.Employees.Add(Emp02);
            //Console.WriteLine(dbContext.Entry(Emp02).State);
            #region Other Ways Of Adding
            //dbContext.Set<Employee>().Add(Emp02);
            //dbContext.Add(Emp01); // Not Recommended
            //dbContext.Entry(Emp02).State = EntityState.Added; // Not Recommened
            #endregion
            //// Add to DB
            //dbContext.SaveChanges(); // Add Remote
            //Console.WriteLine(dbContext.Entry(Emp02).State);
            #endregion
            #region Read/Retreive
            //var Employee = (from E in dbContext.Employees
            //               where E.Code == 2
            //               select E).FirstOrDefault();
            //Console.WriteLine(Employee?.Name??"Not found");
            #endregion
            #region Update
            //var Employee = (from E in dbContext.Employees
            //                where E.Code == 1
            //                select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //Employee.Name = "Heba"; // Update Locally
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            #endregion
            #region Delete
            //var Employee = (from E in dbContext.Employees
            //                where E.Code == 1
            //                select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.Employees.Remove(Employee); // Removing Locally
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges(); // Remove remotely
            //Console.WriteLine(dbContext.Entry(Employee).State);
            #endregion
            #endregion
            #region One To Many

            #endregion
            #endregion
            #region Session 4
            #region Data Seeding
            using CompanyDbContext dbContext = new CompanyDbContext();
            dbContext.Database.ExecuteSqlRaw("ALTER TABLE Departments NOCHECK CONSTRAINT ALL");
            DbContextSeed.Seed(dbContext);
            dbContext.Database.ExecuteSqlRaw("ALTER TABLE Departments CHECK CONSTRAINT ALL");
            #endregion
            #region Navigational Properties
            //// Navigational Properties wont be loaded automatically
            //// We must load the data by ourselves
            #region Example 1: Nav Prop wont be loaded automatically
            //var employee = (from E in dbContext.Employees
            //                where E.Code == 2
            //                select E).FirstOrDefault();
            //Console.WriteLine($"Emp Name: {employee.Name}, Department: {employee.Department?.Name ?? "No Data"}");
            #endregion
            #region Example 2: NP wont be loaded automatically
            // var Department = (from D in dbContext.Departments
            //                   where D.DeptId == 30
            //                   select D).FirstOrDefault();
            //if (Department is not null)
            // {
            //     Console.WriteLine($"Department: {Department.Name}");
            //     foreach (var emp in Department.Employees)
            //     {
            //         Console.WriteLine($"{emp?.Name ?? "No Data"}");
            //     }
            // }
            #endregion
            #endregion
            #region Explicit Loading
            // Loading is done on 2 requests
            // first request will get the data from a specific table
            // Second request will get the relation
            #region Example 1
            //var employee = (from E in dbContext.Employees
            //                where E.Code == 2
            //                select E).FirstOrDefault();
            //if (employee is not null)
            //{
            //    // Loading the NP for [one]
            //    dbContext.Entry(employee).Reference(nameof(employee.Department)).Load();
            //    Console.WriteLine($"Emp Name: {employee.Name}, Department: {employee.Department?.Name ?? "No Data"}");
            //}
            #endregion
            #region Example 2
            //var Department = (from D in dbContext.Departments
            //                  where D.DeptId == 30
            //                  select D).FirstOrDefault();
            //if (Department is not null)
            //{
            //    Console.WriteLine($"Department: {Department.Name}");
            //    dbContext.Entry(Department).Collection<Employee>(nameof(Department.Employees)).Load();
            //    foreach (var emp in Department.Employees)
            //    {
            //        Console.WriteLine($"{emp?.Name ?? "No Data"}");
            //    }
            //}
            #endregion
            #endregion
            #region Egar Loading
            // Get all the data in one request (get requested data and telated data)
            #region Example 1
            //var employee = (from E in dbContext.Employees.Include(E => E.Department)/*.ThenInclude(E => E.Project)*/ 
            //// if emp in relation with dept and project and we want to load the project too but thenInclude will submit another request
            //// If we want only 1 request => use .include again!
            //                where E.Code == 2
            //                select E).FirstOrDefault();
            //Console.WriteLine($"Emp Name: {employee.Name}, Department: {employee.Department?.Name ?? "No Data"}");
            #endregion
            #region Example 2
            //var Department = (from D in dbContext.Departments.Include(D => D.Employees)
            //                  where D.DeptId == 30
            //                  select D).FirstOrDefault();
            //if (Department is not null)
            //{
            //    Console.WriteLine($"Department: {Department.Name}");
            //    foreach (var emp in Department.Employees)
            //    {
            //        Console.WriteLine($"{emp?.Name ?? "No Data"}");
            //    }
            //}
            #endregion
            #endregion
            #region Lazy Loading
            // we must prepare its environment
            // 1- Download Microsoft.EntityFrameworkCore.Proxies
            // 2- Configure its method in DbContext
            // 3- It overrides the NPs so all of them must be virtual and the class to be public
            // it wont load anything untill requested
            #region Example 1
            //var employee = (from E in dbContext.Employees
            //                where E.Code == 2
            //                select E).FirstOrDefault();
            //Console.WriteLine($"Emp Name: {employee.Name}, Department: {employee.Department?.Name ?? "No Data"}");
            #endregion
            #region Example 2
            //var Department = (from D in dbContext.Departments
            //                  where D.DeptId == 30
            //                  select D).FirstOrDefault();
            //if (Department is not null)
            //{
            //    Console.WriteLine($"Department: {Department.Name}");
            //    foreach (var emp in Department.Employees)
            //    {
            //        Console.WriteLine($"{emp?.Name ?? "No Data"}");
            //    }
            //}
            #endregion
            #endregion


            #region Views
            // Create an empty migration
            // Write the sql code for view in up and for drop in down
            //var Resault = dbContext.Employees.FromSqlRaw("select * from EmployeeDepartmentView");
            //var Resault = from item in dbContext.EmployeeDepartmentViews
            //              select item;
            // No Need (We can use dbcontext.View)
            foreach(var item in dbContext.EmployeeDepartmentViews)
            {
                Console.WriteLine($"{item.EmployeeName}--{item.DepartmentName}");
            }
            #endregion
            #endregion
        }
    }
}
