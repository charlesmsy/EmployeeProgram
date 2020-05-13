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
            UIFunction uif = new UIFunction();
            ProgramData data = new ProgramData();
            Employee[] itemArray = data.getList();
            
            // UI //
            String userResponse = "";
            Console.WriteLine("Insert Command");

            while (userResponse != "END")
            {

                Console.Write("//ROOT/");
                userResponse = Console.ReadLine();

                switch (userResponse)
                {

                    case "?":
                    case "help":
                    case "Help":
                    case "HELP":
                    case "commands":
                    case "Commands":
                    case "COMMANDS":
                        uif.help();
                        break;

                    case "list":
                    case "List":
                    case "LIST":
                        uif.list(itemArray);
                        break;

                    case "order":
                    case "Order":
                    case "ORDER":
                        MaxHeapSort ob = new MaxHeapSort(itemArray);
                        break;

                    case "reverse_order":
                    case "Reverse_Order":
                    case "REVERSE_ORDER":
                        MinHeapSort obj = new MinHeapSort(itemArray);
                        break;

                    case "reset":
                    case "Reset":
                    case "RESET":
                        uif.reset(itemArray);
                        break;

                    case "END":
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