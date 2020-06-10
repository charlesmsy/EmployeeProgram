// Resources used:
// https://www.geeksforgeeks.org/heap-sort/


using System;

namespace EmployeeProgramHeapSort
{
    class MainClass
    {
        private static Employee[] EmployeeList;

        public static void Main(string[] args)
        {
            // Data //
            EmployeeList = new [] {
                new Employee("Office_Lady", 1015),
                new Employee("Desk_Gentleman", 1050),
                new Employee("NEW_Girl", 1020),
                new Employee("Boss_Man", 1001),
                new Employee("Boss_Woman", 1070),
                new Employee("Office_Clown", 1060),
                new Employee("Cat_Man", 1040)
            };
            
            // UI //
            String userResponse = "";
            Console.WriteLine("Type COMMANDS to get a list of commands.");

            while (userResponse != "end")
            {

                Console.Write("//");
                userResponse = Console.ReadLine().ToLower();

                switch (userResponse)
                {

                    case "?":
                    case "help":
                    case "commands":
                        Console.WriteLine("List of Commands:");
                        Console.WriteLine("");
                        Console.WriteLine("COMMANDS");
                        Console.WriteLine("     List commands availible.");
                        Console.WriteLine("LIST");
                        Console.WriteLine("     List employee.");
                        Console.WriteLine("ORDER");
                        Console.WriteLine("     ORDER employee list using HeapSort.");
                        Console.WriteLine("REVERSE_ORDER");
                        Console.WriteLine("     Reverse order employee list.");
                        Console.WriteLine("RESET");
                        Console.WriteLine("     Reset the employee.");
                        Console.WriteLine("END");
                        Console.WriteLine("     End program.");
                        break;

                    case "list":
                        HeapSort.PrintArray(EmployeeList);
                        break;

                    case "order":
                        HeapSort.Sort(true, EmployeeList);
                        Console.WriteLine("List sorted.");
                        break;

                    case "reverse_order":
                        HeapSort.Sort(false, EmployeeList);
                        Console.WriteLine("List sorted reverse order.");
                        break;

                    case "reset":
                        Employee[] tempArray = {
                        new Employee("Office_Lady", 1015),
                        new Employee("Desk_Gentleman", 1050),
                        new Employee("NEW_Girl", 1020),
                        new Employee("Boss_Man", 1001),
                        new Employee("Boss_Woman", 1070),
                        new Employee("Office_Clown", 1060),
                        new Employee("Cat_Man", 1040)
                        };

                        EmployeeList = tempArray;
                        Console.WriteLine("Employee list RESET complete.");
                        Console.WriteLine("");
                        break;

                    case "end":
                        break;

                    default:
                        Console.WriteLine("Command Unknown");
                        Console.WriteLine("");
                        break;
                }
            }

            Console.WriteLine("Program END");
        }
    }

}