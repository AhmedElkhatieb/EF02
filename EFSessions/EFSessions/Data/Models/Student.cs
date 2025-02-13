using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSessions.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        //public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        // Commented to add grade attribute by using fluentapis
        // Like that EF will create the many to many relation by convention but if the 
        // relation has an attribute like grade, we wont be able to add it
        // Solution: use FluentApis
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();

    }
}
