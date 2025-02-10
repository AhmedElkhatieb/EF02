using EF_Assignment2.Data.Models;
using EF_Assignments.Data.Contexts;
using EF_Assignments.Data.Models;

namespace EF_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext dbContext = new ITIDbContext();
            #region CRUD
            // I have temporarily disabled constraints then after adding data I reenabled it
            #region Topic Table
            //Topic topic = new Topic()
            //{
            //    Name = "Dot Net"
            //};
            //dbContext.Topics.Add(topic);
            //dbContext.SaveChanges();
            #endregion
            #region Course Table
            //Course course = new Course()
            //{
            //    Duration = 5,
            //    Name = "C#",
            //    Description = "C# Good Course",
            //    Top_Id = 1
            //};
            //dbContext.Courses.Add(course);
            //dbContext.SaveChanges();
            #endregion
            #region Department Table
            //Department department = new Department()
            //{
            //    Name = "Dep1"
            //};
            //dbContext.Departments.Add(department);
            //dbContext.SaveChanges();
            //var Dep = (from D in dbContext.Departments
            //          where D.Id == 2
            //          select D).First();
            //Dep.Ins_Id = 3;
            //Dep.HiringDate = DateTime.Now;
            //dbContext.SaveChanges();
            #endregion
            #region Instructor Table
            //Instructor instructor = new Instructor()
            //{
            //    Name = "Rana Hatem",
            //    Bonus = 1000,
            //    Salary = 10000,
            //    Address = "Banha",
            //    HourRate = 200
            //};
            //dbContext.Instructors.Add(instructor);
            //dbContext.SaveChanges();

            //var Ins = (from I in dbContext.Instructors
            //          where I.Id == 3
            //          select I).First();
            //Ins.DeptId = 2;
            //dbContext.SaveChanges();

            //var Ins = (from I in dbContext.Instructors
            //           where I.Id == 6
            //           select I).First();
            //dbContext.Instructors.Remove(Ins);
            //dbContext.SaveChanges();
            #endregion
            #region Student Table
            //Studnet studnet1 = new Studnet()
            //{
            //    FName = "Ahmed",
            //    LName = "Essam",
            //    Address = "Alexandria",
            //    Age = 25,
            //};
            //dbContext.Studnets.Add(studnet1);
            //dbContext.SaveChanges();
            //var stud = (from S in dbContext.Studnets
            //            select S).First();
            //stud.DeptId = 2;
            //dbContext.SaveChanges();
            #endregion
            #region Stud_Course
            //Stud_Course stud_Course = new Stud_Course()
            //{
            //    Student_Id = 2,
            //    Course_Id = 1,
            //    Grade = 95
            //};
            //dbContext.Stud_Course.Add(stud_Course);
            //dbContext.SaveChanges();
            #endregion
            #region Course_Ins
            //Course_Inst course_Inst = new Course_Inst()
            //{
            //    Inst_Id = 3,
            //    Course_Id = 1,
            //    Evaluate = 100
            //};
            //dbContext.Course_Insts.Add(course_Inst);
            //dbContext.SaveChanges();
            #endregion
            // All operations were covered
            #endregion
            #region Mapping
            // Since there is no inheritance, we should use Table Per Class!!!!!!
            #endregion
        }
    }
}
