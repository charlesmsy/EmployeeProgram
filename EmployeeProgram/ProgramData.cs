using System;
namespace EmployeeProgram
{
    public class ProgramData
    {
        Employee[] EmployeeList = {
                new Employee("Office_Lady", 1001),
                new Employee("Desk_Gentleman", 1050),
                new Employee("NEW_Girl", 1020),
                new Employee("Boss_Man", 1015),
                new Employee("Boss_Woman", 1070),
                new Employee("Office_Clown", 1060),
                new Employee("Cat_Man", 1040)
            };

        public Employee[] getList()
        {
            return EmployeeList;
        }
    }
}
