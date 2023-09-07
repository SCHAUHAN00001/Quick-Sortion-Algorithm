using System;

namespace Quick_Sort_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3,5,7,1,5,9 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
            
        }

        public static void QuickSort(int[] A, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(A, low, high);
                QuickSort(A, low, pi - 1);
                QuickSort(A, pi + 1, high);
            }
        }

        public static int Partition(int[] A, int low, int high)
        {
            int pivot = A[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (A[j] < pivot)
                {
                    i++;
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }

            int temp1 = A[i + 1];
            A[i + 1] = A[high];
            A[high] = temp1;

            return i + 1;
        }

        
    }
}

