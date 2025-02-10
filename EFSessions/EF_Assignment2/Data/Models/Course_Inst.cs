using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Assignment2.Data.Models;

namespace EF_Assignments.Data.Models
{
    internal class Course_Inst
    {
        [ForeignKey(nameof(Instructor))]
        public int Inst_Id { get; set; }
        public Instructor Instructor { get; set; }
        [ForeignKey(nameof(Course))]
        public int Course_Id { get; set; }
        public Course Course { get; set; }
        public int Evaluate {  get; set; }
    }
}
