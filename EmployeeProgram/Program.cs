// Resources used:
// https://www.geeksforgeeks.org/heap-sort/


using System;

namespace EmployeeProgramHeapSort
{
    class MainClass
    {
        public static void Sort(bool isMaxheap)
        {
            int lengthEffective = EmployeeList.Length;

            if (isMaxheap)
            {
                // Build heap
                for (int i = lengthEffective / 2 - 1; i >= 0; i--)
                    Heapify(EmployeeList, lengthEffective, i, isMaxheap);

                // The actual sorting process 
                for (int i = lengthEffective - 1; i > 0; i--)
                {
                    // Move current root to end 
                    Employee temp = EmployeeList[0];
                    EmployeeList[0] = EmployeeList[i];
                    EmployeeList[i] = temp;

                    // call max heapify on the reduced heap 
                    Heapify(EmployeeList, i, 0, isMaxheap);
                }
            }

            else
            {
                // Build heap
                for (int i = lengthEffective / 2 - 1; i >= 0; i--)
                    Heapify(EmployeeList, lengthEffective, i, isMaxheap);

                // The actual sorting process 
                for (int i = lengthEffective - 1; i > 0; i--)
                {
                    // Move current root to end 
                    Employee temp = EmployeeList[0];
                    EmployeeList[0] = EmployeeList[i];
                    EmployeeList[i] = temp;

                    // call min heapify on the reduced heap 
                    Heapify(EmployeeList, i, 0, isMaxheap);
                }

            }
            PrintArray();
        }

        public static void Heapify(Employee[] _EmployeeList, int lengthEffective, int i, bool isMaxheap)
        {
            int smallestOrLargest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (isMaxheap)
            {
                // If left child is larger than root
                if (l < lengthEffective && _EmployeeList[l].getIdNumber() > _EmployeeList[smallestOrLargest].getIdNumber())
                    smallestOrLargest = l;

                // If right child is larger than largest so far 
                if (r < lengthEffective && _EmployeeList[r].getIdNumber() > _EmployeeList[smallestOrLargest].getIdNumber())
                    smallestOrLargest = r;

                // If largest is not root 
                if (smallestOrLargest != i)
                {
                    Employee swap = _EmployeeList[i];
                    _EmployeeList[i] = _EmployeeList[smallestOrLargest];
                    _EmployeeList[smallestOrLargest] = swap;

                    // Recursively heapify the affected sub-tree 
                    Heapify(_EmployeeList, lengthEffective, smallestOrLargest, isMaxheap);
                }
            }

            else
            {
                // If left child is less than root
                if (l < lengthEffective && _EmployeeList[l].getIdNumber() < _EmployeeList[smallestOrLargest].getIdNumber())
                    smallestOrLargest = l;

                // If right child is less than largest so far 
                if (r < lengthEffective && _EmployeeList[r].getIdNumber() < _EmployeeList[smallestOrLargest].getIdNumber())
                    smallestOrLargest = r;

                // If lowest is not root 
                if (smallestOrLargest != i)
                {
                    Employee swap = _EmployeeList[i];
                    _EmployeeList[i] = _EmployeeList[smallestOrLargest];
                    _EmployeeList[smallestOrLargest] = swap;

                    // Recursively heapify the affected sub-tree 
                    Heapify(_EmployeeList, lengthEffective, smallestOrLargest, isMaxheap);
                }
            }
        }

        public static void PrintArray() {
            int n = EmployeeList.Length;
            Console.WriteLine("Listing employees");
            Console.WriteLine("");
            Console.WriteLine("ID         NAME");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{1}       {0}", EmployeeList[i].getName(), EmployeeList[i].getIdNumber());
            }
            Console.WriteLine("");
        }

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
                        PrintArray();
                        break;

                    case "order":
                        Sort(true);
                        Console.WriteLine("List sorted.");
                        break;

                    case "reverse_order":
                        Sort(false);
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