using System;
namespace EmployeeProgram
{
    public class UIFunction
    {
        public void help()
        {
            Console.WriteLine("List of Commands:");
            Console.WriteLine("");
            Console.WriteLine("COMMANDS");
            Console.WriteLine("     List commands availible.");
            Console.WriteLine("LIST");
            Console.WriteLine("     List inventory.");
            Console.WriteLine("ORDER");
            Console.WriteLine("     ORDER inventory list using HeapSort.");
            Console.WriteLine("REVERSE_ORDER");
            Console.WriteLine("     Reverse order inventory list.");
            Console.WriteLine("RESET");
            Console.WriteLine("     Reset the inventory items.");
            Console.WriteLine("END");
            Console.WriteLine("     End program. MUST BE IN ALL CAPS!!");
        }

        public void list(Employee[] itemArray) {    
            Console.WriteLine("Listing employees");
            Console.WriteLine("");
            Console.WriteLine("ID         NAME");
            for (int i = 0; i < itemArray.Length; i++)
            {
                Console.WriteLine("{1}       {0}", itemArray[i].getName(), itemArray[i].getIdNumber());
            }
            Console.WriteLine("");
        }

        public void reset(Employee[] _itemArray)
        {
            Employee[] tempArray = {
                        new Employee("Office_Lady", 1001),
                        new Employee("Desk_Gentleman", 1050),
                        new Employee("NEW_Girl", 1020),
                        new Employee("Boss_Man", 1015),
                        new Employee("Boss_Woman", 1070),
                        new Employee("Office_Clown", 1060),
                        new Employee("Cat_Man", 1040)
                        };
            _itemArray = tempArray;
            Console.WriteLine("Employee list RESET complete.");
            Console.WriteLine("");
        }
    }
}
