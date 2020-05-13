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
            
            // UI //
            String userResponse = "";
            Console.WriteLine("Type COMMANDS to get a list of commands.");

            while (userResponse != "END")
            {

                Console.Write("//");
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
                        uif.list(data.getList());
                        break;

                    case "order":
                    case "Order":
                    case "ORDER":
                        MaxHeapSort ob = new MaxHeapSort(data.getList());
                        break;

                    case "reverse_order":
                    case "Reverse_Order":
                    case "REVERSE_ORDER":
                        MinHeapSort obj = new MinHeapSort(data.getList());
                        break;

                    case "reset":
                    case "Reset":
                    case "RESET":
                        uif.reset(data);
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