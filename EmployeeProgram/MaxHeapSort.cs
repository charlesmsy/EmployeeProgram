using System;
namespace EmployeeProgram
{
    public class MaxHeapSort
    {
        Employee[] TempEmployeeList;

        public MaxHeapSort(Employee[] arr)
        {
            TempEmployeeList = arr;
            maxSort(TempEmployeeList);
        }

        public void maxSort(Employee[] _TempEmployeeList)
        {
            int lengthEffective = _TempEmployeeList.Length;

            // Build heap
            for (int i = lengthEffective / 2 - 1; i >= 0; i--)
                maxHeapify(_TempEmployeeList, lengthEffective, i);

            // The actual sorting process 
            for (int i = lengthEffective - 1; i > 0; i--)
            {
                // Move current root to end 
                Employee temp = _TempEmployeeList[0];
                _TempEmployeeList[0] = _TempEmployeeList[i];
                _TempEmployeeList[i] = temp;

                // call max heapify on the reduced heap 
                maxHeapify(_TempEmployeeList, i, 0);
            }


            printArray(_TempEmployeeList);
        }

        void maxHeapify(Employee[] _TempEmployeeList, int lengthEffective, int i)
        {

            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            // If left child is larger than root
            if (l < lengthEffective && _TempEmployeeList[l].getIdNumber() > _TempEmployeeList[largest].getIdNumber())
                largest = l;

            // If right child is larger than largest so far 
            if (r < lengthEffective && _TempEmployeeList[r].getIdNumber() > _TempEmployeeList[largest].getIdNumber())
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                Employee swap = _TempEmployeeList[i];
                _TempEmployeeList[i] = _TempEmployeeList[largest];
                _TempEmployeeList[largest] = swap;

                // Recursively heapify the affected sub-tree 
                maxHeapify(_TempEmployeeList, lengthEffective, largest);
            }
        }

        
        static void printArray(Employee[] arr)
        {
            int n = arr.Length;
            Console.WriteLine("Listing inventory in Descending Order");
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
