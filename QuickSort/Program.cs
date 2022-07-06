using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort {
    class Program {

        static void Main(string[] args) {

            //arbitrary list of unsorted integers
            int[] integerArray = { 6, 5, -6, 0, 3, 10, 4, 6, -5, 0 };
            int lowIndex = 0;
            int highIndex = integerArray.Length - 1;
            Console.WriteLine("\nUnsorted List of Integers: ");
            PrintList(integerArray);
            Console.WriteLine("\nSorted List of Integers: ");
            QuickSort(integerArray, lowIndex, highIndex);
            PrintList(integerArray);
            Console.WriteLine("\n");
        }

        //print array of integers
        public static void PrintList(int[] integerArray) {

            foreach (int i in integerArray) {
                Console.Write(i + " ");
            }
            Console.WriteLine('\n');
        }

        //QuickSort(A[], p, r)
        //  if p < r
        //      q = Partition(A[], p, r)
        //      QuickSort(A[], p, q - 1)
        //      QuickSort(A[], q + 1, r)

        public static void QuickSort(int[] integerArray, int lowIndex, int highIndex) {
            if (lowIndex < highIndex) {
                int mid = Partition(integerArray, lowIndex, highIndex);
                QuickSort(integerArray, lowIndex, mid - 1);
                QuickSort(integerArray, mid + 1, highIndex);
            }
        }

        //Partition(A[], p, r)
        //  x = A[r]
        //  i = p - 1
        //  for j = p to r - 1
        //      if A[j] <= x
        //          i = i + 1
        //exchange A[i + 1] with A[r]
        //return i + 1

        public static int Partition(int[] integerArray, int lowIndex, int highIndex) {
            int x = integerArray[highIndex];
            int i = lowIndex - 1;
            for (int j = lowIndex; j < highIndex; j++) {
                if (integerArray[j] <= x) {
                    i++;
                }
            }
            int temp = integerArray[i + 1];
            integerArray[i + 1] = integerArray[highIndex];
            integerArray[highIndex] = temp;

            return i + 1;
        }
    }
}