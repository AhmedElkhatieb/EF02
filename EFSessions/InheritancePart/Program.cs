using InheritancePart.Contexts;
using InheritancePart.Data.Models;

namespace InheritancePart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RouteDbContext dbContext = new RouteDbContext();

            #region TPCC
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Name = "Rana",
                Address = "Banaha",
                Age = 20,
                Salary = 4000,
                StartDate = DateTime.Now,
            };

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Name = "Nada",
                Address = "Banaha",
                Age = 22,
                CountOfHours = 20,
                HourRate = 200
            };
            //dbContext.FullTimeEmployees.Add(fullTimeEmployee);
            //dbContext.PartTimeEmployees.Add(partTimeEmployee);
            //dbContext.SaveChanges();
            //var FTEmp = from FT in dbContext.FullTimeEmployees
            //            select FT;
            //var PTEmp = from PT in dbContext.PartTimeEmployees
            //            select PT;
            //foreach (var i in FTEmp)
            //{
            //    Console.WriteLine($"Name: {i.Name}, Salary = {i.Salary}");
            //}
            //foreach (var i in PTEmp)
            //{
            //    Console.WriteLine($"Name: {i.Name}, Hour Rate = {i.HourRate}");
            //}
            #endregion
            #region TPH
            FullTimeEmployee fullTimeEmployee1 = new FullTimeEmployee()
            {
                Name = "Rana",
                Age = 22,
                Address = "Banha",
                Salary = 5000,
                StartDate = DateTime.Now
            };
            PartTimeEmployee partTimeEmployee1 = new PartTimeEmployee()
            {
                Name = "Rana",
                Age = 22,
                Address = "Banha",
                CountOfHours = 22,
                HourRate = 200
            };
            //dbContext.FullTimeEmployees.Add(fullTimeEmployee1);
            //dbContext.PartTimeEmployees.Add(partTimeEmployee1);
            //dbContext.SaveChanges();
            //var FTEmp = from FT in dbContext.FullTimeEmployees
            //            select FT;
            //var PTEmp = from PT in dbContext.PartTimeEmployees
            //            select PT;
            //foreach (var i in FTEmp)
            //{
            //    Console.WriteLine($"Name: {i.Name}, Salary = {i.Salary}");
            //}
            //foreach (var i in PTEmp)
            //{
            //    Console.WriteLine($"Name: {i.Name}, Hour Rate = {i.HourRate}");
            //}

            #endregion
        }
    }
}
