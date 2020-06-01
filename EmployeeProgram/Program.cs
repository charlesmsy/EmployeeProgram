// Resources used:
// https://www.geeksforgeeks.org/heap-sort/


using System;

namespace EmployeeProgram
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Data //
            ProgramData data = new ProgramData();
            
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
                        data.printArray();
                        break;

                    case "order":
                        data.maxSort();
                        break;

                    case "reverse_order":
                        data.minSort();
                        break;

                    case "reset":
                        data.reset();
                        break;

                    case "end":
                        break;

                    default:
                        Console.WriteLine("Command Unkown");
                        Console.WriteLine("");
                        break;
                }
            }

            Console.WriteLine("Program END");
        }
    }

}