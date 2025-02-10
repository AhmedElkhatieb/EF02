using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment2.Data.Models
{
    internal class Studnet
    {
        public int Id { get; set; }
        public string FName {  get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        #region Student Department One To Many
        [ForeignKey(nameof(Department))]
        public int DeptId { get; set; }
        [InverseProperty(nameof(Models.Department.Studnets))]
        public Department Department { get; set; } 
        #endregion

    }
}
