// Variant_3
using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace Exam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine(program.Task_1(4, 6, 22));
            Console.WriteLine(program.Task_2(4, 6, 22));
            var A = new int[] { 17, 17, 2, -1, -10, -20 };
            var M = new int[,] { { 23, 7, -13, 24, -21, 18 }, { 2, 0, 12, -16, -20, -17 }, { 22, 21, -6, 19, -22, -4 }, { -13, 13, 18, -15, -20, -2 }, { 3, 7, 1, -20, 22, -8 }, { -22, -11, 13, -2, 0, -14 } };
            var arr = new int[] { 1, 3, 5 };

            program.Task_3(M);
            program.Print(M);

            program.Task_4(ref A);
            program.Print(A);

            // Task_1:
            // Input: F = 4, N = 6, T = 22
            // Output: years = 91


            // Task_2:
            // Input: N = 4, stairs = 6, time = 22
            // Output: N = 3

            // Task_3:
            // Input:
            /*   23,   7, -13,  24, -21,  18, 
                  2,   0,  12, -16, -20, -17, 
                 22,  21,  -6,  19, -22,  -4, 
                 -13, 13,  18, -15, -20,  -2, 
                  3,   7,   1, -20,  22,  -8, 
                -22, -11,  13,  -2,   0, -14 */
            // Output:
            /*   23,   7, -13,  21, -25,  18, 
                  2,   0,  12, -18, -23, -17, 
                 22,  21,  -6,  18, -24,  -4, 
                -13,  13,  18, -15, -20,  -2, 
                  3,   7,   1, -20,  22,  -8, 
                -22, -11,  13,  -2,   0, -14 */

            // Task_4:
            // Input:
            /*   17,   2,  -1, -10, -20 */
            // Output:
            /*  -20, -10,  -1 * /

            // Task_5:
            // Input:
            /*  -22, -11,  13,  -2,   0, -14, 
                -13,  13,  18, -15, -20,  -2, 
                  2,   0,  12, -16, -20, -17, 
                 17,  17,   2, -10,  -1, -20, 
                 22,  21,  -6,  19, -22,  -4, 
                 23,   7, -13,  24, -21,  18 */
            /*   17,  17,   2, -10,  -1, -20 */
            // Output 1:
            /*   23,   7, -13, -20, -21,  18, 
                  2,   0,  12, -16, -20, -17, 
                 22,  21,  -6,  19, -22,  -4, 
                -13,  13,  18, -15, -20,  -2, 
                  3,   7,   1, -20,  22,  -8, 
                 17, -11,  13,  -2,   0, -14 */
            /*   17,  17,   2, -10,  -1, -20 */
            // Output 2:
            /*    2,   0,  12, -16, -20, -17, 
                -22, -11,  13,  -2,   0, -14, 
                 17,  17,   2, -10,  -1, -20, 
                 22,  21,  -6,  19, -22,  -4, 
                -13,  13,  18, -15, -20,  -2, 
                 23,   7, -13,  24, -21,  18 */
            /*   17,  17,   2, -10,  -1, -20 */

        }

        public double Task_1(double F, double N, double T)
        {
            double years = 0, k = 0;
            while(T > 0)
            {
                
                k++;
                if(k % N == 0 && (F - 1) >= 1)
                {
                    F -= 1;
                }
                
                if (k % 5 == 0)
                {
                    years += F * 4;
                }
                else if(k % 7 == 0)
                {
                    years += F * 2;
                }
                else
                {
                    years += F;
                }
                T--;
            }
            
            return years;
        }
        public double Task_2(double N, double stairs, double time)
        {
            double stair = 0, flight = 0;
            while(N > 0 && time > 0)
            {
                if(stair < stairs)
                {
                    stair++;
                    time--;
                }
                else
                {
                    if(flight == 1)
                    {
                        N--;
                        flight = 0;
                    }
                    else
                    {
                        flight = 1;
                    }
                    stair = 0;
                }
            }

            return N;
        }
        public void Task_3(int[,] M)
        {
            if (M == null || M.GetLength(0) == 0 || M.GetLength(1) != M.GetLength(0)) return;
            int maxi = M[0, 0], mini = M[0, 0];
            int min1 = 0, min2 = 0;
            int max1 = 0, max2 = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for(int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i, j] > maxi)
                    {
                        maxi = M[i, j];
                        max1 = i;
                        max2 = j;
                    }
                    if (M[i, j] < mini)
                    {
                        mini = M[i, j];
                        min1 = i;
                        min2 = j;
                    }
                }
            }

 
            int startRow = Math.Min(min1, max1);
            int endRow = Math.Max(min1, max1);
            int startCol = Math.Min(min2, max2);
            int endCol = Math.Max(min2, max2);

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    M[i, j] += i - j;
                }
            }



        }
        public void Task_4(ref int[] A)
        {
            if(A == null || A.Length < 2) return;
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for(int j = 0; j >  A.Length - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int da = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = da;
                    }
                }
            }
            for(int i = 0; i < A.Length / 2; i++)
            {
                if(i % 4 == 0)
                {
                    index++;
                }
            }
           

          A = DeleteFromArray(A, index);

        }


        public int[] DeleteFromArray(int[] array, int index)
        {
            int[] da = new int[array.Length - index];
            int j = 0;
            for(int i = 0; i < da.Length; i ++)
            {
              if(i % 4 == 0 && i < array.Length / 2) 
              {
                  j++;
              }
                da[i] = array[j];
                j++;

            }
 
            return da;
        }

        
        public void Task_5(ref int[,] M, ref int[] A, SortRowsMatrixAscending Op)
        {
            if (M == null || M.GetLength(0) < 1 || M.GetLength(0) != M.GetLength(1)) return;
            if (A == null || A.Length < 1 || M.GetLength(0) != A.Length) return;
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    sum1 += M[i, j];
                }
            }
            for(int i = 0; i < A.Length; i++)
            {
                sum2 += A[i];
            }
            Op(M);
        }
        public delegate void SortRowsMatrixAscending(int[,] array);
        public void SortRowsAscendingByFirst(int[,] M)
        {

            
        }
        public void SortRowsAscendingByLast(int[,] M) { }
        public void ChangeRowElements(int[,] matrix, int[] array) { }
        public void Print(int[] array)
        {
            Console.WriteLine();
            foreach (var item in array) Console.Write(item + ", ");
            Console.WriteLine();
        }

        public void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + ", ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}
