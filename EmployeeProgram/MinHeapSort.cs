using System;
namespace EmployeeProgram
{
    public class MinHeapSort
    {
        Employee[] TempMinEmployeeList;

        public MinHeapSort(Employee[] arr)
        {
            TempMinEmployeeList = arr;
            minSort(TempMinEmployeeList);
        }

        public void minSort(Employee[] _TempMinEmployeeLiat)
        {
            int lengthEffective = _TempMinEmployeeLiat.Length;

            // Build heap
            for (int i = lengthEffective / 2 - 1; i >= 0; i--)
                minHeapify(_TempMinEmployeeLiat, lengthEffective, i);

            // The actual sorting process 
            for (int i = lengthEffective - 1; i > 0; i--)
            {
                // Move current root to end 
                Employee temp = _TempMinEmployeeLiat[0];
                _TempMinEmployeeLiat[0] = _TempMinEmployeeLiat[i];
                _TempMinEmployeeLiat[i] = temp;

                // call min heapify on the reduced heap 
                minHeapify(_TempMinEmployeeLiat, i, 0);
            }


            printArray(_TempMinEmployeeLiat);
        }

        void minHeapify(Employee[] _TempMinEmployeeList, int lengthEffective, int i)
        {
            int lowest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            // If left child is less than root
            if (l < lengthEffective && _TempMinEmployeeList[l].getIdNumber() < _TempMinEmployeeList[lowest].getIdNumber())
                lowest = l;

            // If right child is less than largest so far 
            if (r < lengthEffective && _TempMinEmployeeList[r].getIdNumber() < _TempMinEmployeeList[lowest].getIdNumber())
                lowest = r;

            // If lowest is not root 
            if (lowest != i)
            {
                Employee swap = _TempMinEmployeeList[i];
                _TempMinEmployeeList[i] = _TempMinEmployeeList[lowest];
                _TempMinEmployeeList[lowest] = swap;

                // Recursively heapify the affected sub-tree 
                minHeapify(_TempMinEmployeeList, lengthEffective, lowest);
            }
        }

        
        static void printArray(Employee[] arr)
        {
            int n = arr.Length;
            Console.WriteLine("Listing inventory in Ascending Order");
            Console.WriteLine("");
            Console.WriteLine("ID         NAME");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{1}       {0}", arr[i].getName(), arr[i].getIdNumber());
            }
            Console.WriteLine("");
        }
        
    }
}
