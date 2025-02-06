using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSessions.Data.Models;

namespace FluentApis
{
    public class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate {  get; set; }
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
