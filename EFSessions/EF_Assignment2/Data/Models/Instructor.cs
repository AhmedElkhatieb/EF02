using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment2.Data.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        #region Work
        [ForeignKey(nameof(Department))]
        public int DeptId { get; set; }
        [InverseProperty(nameof(Models.Department.Instructors))]
        public Department Department { get; set; }
        #endregion
        #region Manage
        [InverseProperty(nameof(Models.Department.ManagerIns))]
        public Department? ManagedDepartment { get; set; }
        #endregion
    }
}
