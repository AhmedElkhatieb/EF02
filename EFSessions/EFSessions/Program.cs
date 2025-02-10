using EFSessions.Data;
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
            using CompanyDbContext dbContext = new CompanyDbContext();


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
        }
    }
}
