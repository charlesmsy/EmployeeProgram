using System;
namespace EmployeeProgram
{
    public class ProgramData
    {
        Employee[] EmployeeList = {
                new Employee("Office_Lady", 1015),
                new Employee("Desk_Gentleman", 1050),
                new Employee("NEW_Girl", 1020),
                new Employee("Boss_Man", 1001),
                new Employee("Boss_Woman", 1070),
                new Employee("Office_Clown", 1060),
                new Employee("Cat_Man", 1040)
            };

        public Employee[] getList()
        {
            return EmployeeList;
        }

        public void setList(Employee[] arr) {
            EmployeeList = arr; 
        }

        public void minSort()
        {
            int lengthEffective = EmployeeList.Length;

            // Build heap
            for (int i = lengthEffective / 2 - 1; i >= 0; i--)
                minHeapify(EmployeeList, lengthEffective, i);

            // The actual sorting process 
            for (int i = lengthEffective - 1; i > 0; i--)
            {
                // Move current root to end 
                Employee temp = EmployeeList[0];
                EmployeeList[0] = EmployeeList[i];
                EmployeeList[i] = temp;

                // call min heapify on the reduced heap 
                minHeapify(EmployeeList, i, 0);
            }


            printArray();
        }

        public void minHeapify(Employee[] _EmployeeList, int lengthEffective, int i)
        {
            int lowest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            // If left child is less than root
            if (l < lengthEffective && _EmployeeList[l].getIdNumber() < _EmployeeList[lowest].getIdNumber())
                lowest = l;

            // If right child is less than largest so far 
            if (r < lengthEffective && _EmployeeList[r].getIdNumber() < _EmployeeList[lowest].getIdNumber())
                lowest = r;

            // If lowest is not root 
            if (lowest != i)
            {
                Employee swap = _EmployeeList[i];
                _EmployeeList[i] = _EmployeeList[lowest];
                _EmployeeList[lowest] = swap;

                // Recursively heapify the affected sub-tree 
                minHeapify(_EmployeeList, lengthEffective, lowest);
            }
        }

        public void maxSort()
        {
            int lengthEffective = EmployeeList.Length;

            // Build heap
            for (int i = lengthEffective / 2 - 1; i >= 0; i--)
                maxHeapify(EmployeeList, lengthEffective, i);

            // The actual sorting process 
            for (int i = lengthEffective - 1; i > 0; i--)
            {
                // Move current root to end 
                Employee temp = EmployeeList[0];
                EmployeeList[0] = EmployeeList[i];
                EmployeeList[i] = temp;

                // call max heapify on the reduced heap 
                maxHeapify(EmployeeList, i, 0);
            }


            printArray();
        }

        public void maxHeapify(Employee[] _EmployeeList, int lengthEffective, int i)
        {

            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            // If left child is larger than root
            if (l < lengthEffective && _EmployeeList[l].getIdNumber() > _EmployeeList[largest].getIdNumber())
                largest = l;

            // If right child is larger than largest so far 
            if (r < lengthEffective && _EmployeeList[r].getIdNumber() > _EmployeeList[largest].getIdNumber())
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                Employee swap = _EmployeeList[i];
                _EmployeeList[i] = _EmployeeList[largest];
                _EmployeeList[largest] = swap;

                // Recursively heapify the affected sub-tree 
                maxHeapify(_EmployeeList, lengthEffective, largest);
            }
        }


        public void printArray()
        {
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

        public void reset()
        {
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
        }

    }
}
