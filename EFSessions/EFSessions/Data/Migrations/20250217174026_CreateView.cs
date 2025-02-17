using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSessions.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" Create or Alter View EmployeeDepartmentView
                                    with Encryption
                                    as
                                    Select E.Code as ""EmployeeCode"", E.Name as ""EmployeeName"", D.DeptId as ""DepartmentId"", D.Name as ""DepartmentName""
                                    from Departments D inner join Employees E
                                    on D.DeptId = E.DepartmentDeptId
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop View EmployeeDepartmentView");
        }
    }
}
