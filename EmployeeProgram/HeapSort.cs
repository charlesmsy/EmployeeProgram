using System;
namespace EmployeeProgramHeapSort
{
    public class HeapSort
    {
        public static void Sort(bool isMaxheap, Employee[] EmployeeList)
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
            PrintArray(EmployeeList);
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

        public static void PrintArray(Employee[] EmployeeList)
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

        
    }
}
