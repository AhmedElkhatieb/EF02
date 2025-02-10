using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSessions.Data.Models
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        #region Work
        [InverseProperty(nameof(Models.Employee.Department))]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); //Navigational Property [Many]
        #endregion
        #region Manage
        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }
        [InverseProperty(nameof(Models.Employee.ManageDepartment))]
        public Employee Manager { get; set; } = null!; // Navigational Property [One]
        
        #endregion
    }
}
