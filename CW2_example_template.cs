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
            // input:   1 5 -5 -4 4 -1 3 -2 5 5 -3 4 -1 2 3
            // output:  1 5 2 -4 4 -1 3 -2 5 5 -3 4 -1 -5 3

            // Task_2:
            // input:   1 5 2 -4 4 -1 3 -2 5 5 -3 4 -1 -5 3
            // output:  1 5 4 4 2 -1 3 -2 5 5 -3 -4 -1 -5 3

            // Task_3:
            // input: 
            /*1 2 3 4 5
              5 0 3 2 3
              5 5 3 4 2
              1 2 2 1 0
              1 2 4 3 2*/
            // output:
            /*1 5 3 1 5
              5 2 3 3 3
              5 0 3 4 2
              1 2 2 2 0
              1 2 4 4 2*/

            // Task_4:
            // input:   1 5 4 4 2 -1 3 -2 5 5 -3 -4 -1 -5 3
            // output:  1 5 4 4 2 -1 3 -2 5 5 -4 -1 -5 3

            // Task_5:
            // input: 
            /*1 5 3 1 5
              5 2 3 3 3
              5 0 3 4 2
              1 2 2 2 0
              1 2 4 4 2*/
            // output:
            /*1 5 3 1 5
              1 2 3 3 3
              1 0 3 4 2
              1 2 3 2 2
              5 2 2 2 0
              5 2 4 4 2*/
        }
        void Task_1(int[] array)
        {
        }
        void Task_2(int[] array)
        {
        }
        void Task_3(int[,] matrix)
        {
        }
        void Task_4(ref int[] array)
        {
        }
        void Task_5(ref int[,] matrix)
        {
        }
    }
}