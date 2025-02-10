using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment2.Data.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #region TopicRelation
        [ForeignKey(nameof(Topic))]
        public int Top_Id { get; set; }
        [InverseProperty(nameof(Models.Topic.Courses))]
        public Topic Topic { get; set; }
        #endregion
        
    }
}
