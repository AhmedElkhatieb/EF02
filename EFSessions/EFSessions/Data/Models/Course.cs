using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSessions.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        // commented to add grade attribute
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
