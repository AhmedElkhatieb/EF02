using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment2.Data.Models
{
    internal class Stud_Course
    {
        [ForeignKey(nameof(Studnet))]
        public int Student_Id { get; set; }
        public Studnet Studnet { get; set; }
        [ForeignKey(nameof(Course))]
        public int Course_Id { get; set; }
        public Course Course { get; set; }
        public int Grade { get; set; }
    }
}
