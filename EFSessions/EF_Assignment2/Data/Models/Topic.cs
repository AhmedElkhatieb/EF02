using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment2.Data.Models
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [InverseProperty(nameof(Models.Course.Topic))]
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
