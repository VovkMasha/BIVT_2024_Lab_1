// Variant_4
using System;

namespace Exam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine(program.Task_1(4, 6, 22));
            Console.WriteLine(program.Task_2(4, 6, 22));
            program.Task_3(new int[,]
            {{23,   7, -13,  24, -21,  18 },
                  { 2,   0,  12, -16, -20, -17 },
                 { 22, 21, -6, 19, -22, -4 },
                 { -13, 13,  18, -15, -20,  -2},
                 { 3,   7,   1, -20,  22,  -8},
                { -22, -11,  13,  -2,   0, -14}});

            // Task_1:
            // Input: A = 4, T = 6, N = 22
            // Output: time = 116.9156060766202


            // Task_2:
            // Input: peopleAmount = 4, avgTrackLength = 6, newSongs = 22
            // Output: tracks = 40

            // Task_3:
            // Input:
            /*   23,   7, -13,  24, -21,  18, 
                  2,   0,  12, -16, -20, -17, 
                 22,  21,  -6,  19, -22,  -4, 
                 -13, 13,  18, -15, -20,  -2, 
                  3,   7,   1, -20,  22,  -8, 
                -22, -11,  13,  -2,   0, -14 */
            // Output:
            /*   23,   7, -13,  24, -21,  18, 
                  8,   0,  12, -16, -20, -17, 
                  8,  32,  -6,  19, -22,  -4, 
                 10,  -4,  36, -15, -20,  -2, 
                -19, -14, -22, -41,  22,  -8, 
                 -5, -29,   8,  -5,  -9, -14 */

            // Task_4:
            // Input:
            /*   17,   2,  -1, -10, -20 */
            // Output:
            /*  -20, -10,  -1,  17 */

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
            /*   17,  17,   2, -10,  -1, -20, 
                  2,   0,  12, -16, -20, -17, 
                 22,  21,  -6,  19, -22,  -4, 
                -13,  13,  18, -15, -20,  -2, 
                  3,   7,   1, -20,  22,  -8, 
                -22, -11,  13,  -2,   0, -14 */
            /*   17,  17,   2, -10,  -1, -20 */
            // Output 2:
            /*   23,   7, -13,  17, -21,  18, 
                  2,   0,  12,  17, -20, -17, 
                 22,  21,  -6,   2, -22,  -4, 
                -13,  13,  18, -10, -20,  -2, 
                  3,   7,   1,  -1,  22,  -8, 
                -22, -11,  13, -20,   0, -14 */
            /*   17,  17,   2, -10,  -1, -20 */

        }
        public double Task_1(double T, double D, double N)
        {

            return 0;
        }
        public double Task_2(double peopleAmount, double avgTrackLength, double newSongs)
        {
            double time = 1140, tracks = 0;
            if (peopleAmount > 10000)
            {
                tracks += 10;
            }
            else tracks += 5;
            time += tracks * avgTrackLength;
            while (newSongs > 0)
            {
                if (time > 1320 || tracks % 2 == 0)
                {
                    newSongs--;
                }
                time += avgTrackLength;
                tracks++;
            }
            return tracks;
        }
        public void Task_3(int[,] M)
        {
            if (M == null || M.GetLength(0) < 2 && M.GetLength(1) < 2) return;
            if (M.GetLength(0) != M.GetLength(1)) return;
            int size = M.GetLength(0);
            int dSum = 0;
            for (int i = 0; i < size; i++)
            {
                dSum += M[i, i];
            }
            int dAverage = dSum / size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if(i<j)
                    {
                        M[i, j] += M[j, i];
                        M[i, j] -= dAverage;
                    }
                }
            }
        }
        public void Task_4(ref int[] A)
        {
            if (A == null || A.Length < 3) return;
            int imax = 0, firstNegIndex = -1;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > A[imax]) imax = i;
                if (A[i] < 0 && firstNegIndex == -1) firstNegIndex = i;

            }
            int start = Math.Min(imax, firstNegIndex);
            int end = Math.Max(imax, firstNegIndex);

            int[] modifiedArray = DeleteArrayPart(A, start, end);
            Array.Sort(modifiedArray);
        }
        

        public int[] DeleteArrayPart(int[] array, int start, int end)
        {
            int newSize = array.Length - (end - start + 1);
            int[] newArray = new int[newSize];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i < start || i > end)
                {
                    newArray[index++] = array[i];
                }
            }
            return newArray;
        }
        

        public void Task_5(ref int[,] M, ref int[] A, ReplaceLine Op)
        {

        }
        public delegate void ReplaceLine(int[,] matrix, int imax, int jmax, int[] array);
        public void ReplaceRow(int[,] matrix, int row, int col, int[] array) { }
        public void ReplaceColumn(int[,] matrix, int row, int col, int[] array) { }
        public void FindMaxInUpperQuorter(int[,] matrix, out int imax, out int jmax) { imax = 0; jmax = 0; }
    }
}