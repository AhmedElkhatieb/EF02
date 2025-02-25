﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSessions.Data.Models
{
    public class Employee
    {
        // We have 4 ways to map classes
        // 1- By Convention
        // 2- Data Annotation (Set Of Attributes)
        // 3- FluentApis (Set of Methods)
        // 4- Class Configuration (Organisation for Fluent Apis)
        [Key] // Make the follwing property Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Puts identity (1,1)
        // Cant make identity(10,10) => use FluentApi
        public int Code { get; set; }
        [Column(TypeName = "varchar")] // Make the type of name varchar
        [StringLength(50, MinimumLength = 10)] // make the max length = 50
        // MinimumLength is ignored => some things from this class go to DB and others are not
        // Related to DB (App)
        [MaxLength(50)]
        [MinLength(10)]
        [Length(10, 50)]
        // Those attributes arent related to DB!
        public string? Name { get; set; }
        [Column(TypeName = "decimal(12,2)")] // Make the type decimal in DB but here it still double
        public double Salary { get; set; }
        [Range(22, 60)] // Not related to DB
        [AllowedValues(20, 21, 22, 23)]
        [DeniedValues(10, 15)]
        public int? Age { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        // Not related to DB
        public string? Email { get; set; }
        [Phone]
        public string? Phone { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        #region Work Relation
        //[ForeignKey("Department")]
        [ForeignKey(nameof(Department))]
        public int? DepartmentDeptId { get; set; } // Set foreign key for Department Table
        [InverseProperty(nameof(Models.Department.Employees))]
        public virtual Department? Department { get; set; } // Navigational Property [One]
        #endregion
        #region Manage Relation
        [InverseProperty(nameof(Models.Department.Manager))]
        public virtual Department? ManageDepartment { get; set; } // Navigational Property [One]
        // Now when trying to add migration there will be an error because EF wont be able to
        // Determine which NP is whose (we have 2 NP)
        // Solution: Using Inverse Property
        #endregion
    }
}
