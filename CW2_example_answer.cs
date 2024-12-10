using System;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CW2_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            // Task_1:
            var error = new int[0];
            var array = new int[] { 1, 5, -5, 4, 4, -1, 3, -2, 5, 5, 3, -4, -1, 2, 3 };
            var matrix = new int[,] { { 1, 2, 3, 4, 5 }, { 5, 0, 3, 2, 3 }, { 5, 5, 3, 4, 2 }, { 1, 2, 2, 1, 0 }, { 1, 2, 4, 3, 2 } };
            var matrix2 = new int[,] { { 1, 2, 3, 4 }, { 5, 0, 3, 2 }, { 5, 5, 3, 4 }, { 1, 2, 2, 1 } };
            // input:   1 5 -5 4 4 -1 3 -2 5 5 3 -4 -1 2 3
            program.Print(array);
            program.Task_1(array);
            // output:  1 5 -5 4 4 -1 3 18 5 5 3 18 -1 2 3
            program.Print(array);

            // Task_2:
            // input:   1 5 -5 4 4 -1 3 18 5 5 3 18 -1 2 3
            program.Print(array);
            program.Task_2(array);
            // output:  1 5 -5 4 3 -1 4 18 5 5 3 18 -1 2 3
            program.Print(array);

            // Task_3:
            // input: 
            /*1 2 3 4 5
              5 0 3 2 3
              5 5 3 4 2
              1 2 2 1 0
              1 2 4 3 2*/
            program.Print(matrix);
            program.Task_3(matrix);
            // output:
            /*1 2 3 4 5
              5 0 3 2 3
              5 5 20 4 2
              1 2 2 1 0
              1 2 4 3 2*/
            program.Print(matrix);

            // Task_4:
            // input:   1 5 -5 4 3 -1 4 18 5 5 3 18 -1 2 3
            program.Print(array);
            program.Task_4(ref array);
            // output:  1 5 -5 4 3 -1 4 18 5 5 3 18 -1 13 2 3
            program.Print(array);

            // Task_5:
            // input: 
            /*1 2 3 4 5
              5 0 3 2 3
              5 5 20 4 2
              1 2 2 1 0
              1 2 4 3 2*/
            program.Print(matrix);
            program.Task_5(ref matrix);
            // output:
            /*1 2 2 1 0
            1 2 4 3 2
            5 0 3 2 3
            1 2 3 4 5
            5 5 20 4 2*/
            program.Print(matrix);

        }
        void Print(int[] array)
        {
            Console.WriteLine();
            foreach (int i in array) Console.Write(i + " ");
            Console.WriteLine();
        }
        void Print(int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        void Task_1(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max)
                    sum += i;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0 && array[i] % 2 == 0)
                    array[i] = sum;
        }
        void Task_2(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int imax = 0, imin = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[imax])
                    imax = i;
                if (array[i] < array[imin])
                    imin = i;
            }
            for (int k = Math.Min(imin, imax); k < Math.Max(imin, imax); k++)
            {
                if (array[k] > 0 && k % 2 == 0)
                {
                    int i = k, j = k - 2;
                    while (j >= 0)
                    {
                        if (array[j] > 0 && array[i] < array[j])
                        {
                            var temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                            i = j;
                        }
                        j -= 2;
                    }
                }
            }
        }
        void Task_3(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(0) != matrix.GetLength(1)) return;
            int sum = 0, n = matrix.GetLength(0);
            int rest = n % 2;
            for (int i = n / 2 + 1; i < n; i++)
            {
                for (int j = 0; j < n / 2 - 1 + rest; j++)
                {
                    sum += matrix[i, j];
                    sum += matrix[j, i];
                }
            }
            matrix[n / 2, n / 2] = sum;
            if (rest == 0)
            {
                matrix[n / 2 - 1, n / 2] = sum;
                matrix[n / 2 - 1, n / 2 - 1] = sum;
                matrix[n / 2, n / 2 - 1] = sum;
            }
        }
        void Task_4(ref int[] array)
        {
            if (array == null || array.Length == 0) return;
            int max = array[0], min = array[0], k = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
                if (array[i] < 0) k = i;
            }
            if (k > -1)
                array = InsertItem(array, min + max, k);
        }
        int[] InsertItem(int[] array, int item, int index)
        {
            if (index < 0 || index >= array.Length) return array;
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i <= index) newArray[i] = array[i];
                else newArray[i + 1] = array[i];
            }
            newArray[index + 1] = item;
            return newArray;
        }
        void Task_5(ref int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return;
            int[] sums = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                sums[i] = SumRow(matrix, i);
            SortByPatternDescending(matrix, sums);
        }
        int SumRow(int[,] matrix, int row)
        {
            if (row < 0 || row >= matrix.GetLength(0)) return 0;
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
                sum += matrix[row, i];
            return sum;
        }
        void SortByPatternDescending(int[,] matrix, int[] pattern)
        {
            for (int i = 1; i < pattern.Length; i++)
            {
                int key = pattern[i], j = i - 1;
                int[] row = new int[matrix.GetLength(1)];
                for (int k = 0; k < matrix.GetLength(1); k++)
                    row[k] = matrix[i, k];
                while (j >= 0 && pattern[j] > key)
                {
                    pattern[j + 1] = pattern[j];
                    for (int k = 0; k < matrix.GetLength(1); k++)
                        matrix[j + 1, k] = matrix[j, k];
                    j--;
                }
                pattern[j + 1] = key;
                for (int k = 0; k < matrix.GetLength(1); k++)
                    matrix[j + 1, k] = row[k];
            }
        }
    }
}