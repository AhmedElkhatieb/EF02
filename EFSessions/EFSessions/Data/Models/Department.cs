using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSessions.Data.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        public DateOnly CreationDate { get; set; }
        #region Work
        [InverseProperty(nameof(Models.Employee.Department))]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); //Navigational Property [Many]
        #endregion
        #region Manage
        [ForeignKey(nameof(Manager))]
        public int? ManagerId { get; set; }
        [InverseProperty(nameof(Models.Employee.ManageDepartment))]
        public virtual Employee Manager { get; set; } = null!; // Navigational Property [One]
        
        #endregion
    }
}
