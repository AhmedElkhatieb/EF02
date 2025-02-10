using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment2.Data.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        #region Student
        [InverseProperty(nameof(Models.Studnet.Department))]
        public ICollection<Studnet> Studnets { get; set; } = new HashSet<Studnet>();
        #endregion
        #region Instructor
        #region Work
        [InverseProperty(nameof(Models.Instructor.Department))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        #endregion
        #region Manage
        [ForeignKey(nameof(ManagerIns))]
        public int Ins_Id { get; set; }
        [InverseProperty(nameof(Models.Instructor.ManagedDepartment))]
        public Instructor ManagerIns { get; set; } = null!;
        public DateTime HiringDate {  get; set; }
        #endregion
        #endregion

    }
}
