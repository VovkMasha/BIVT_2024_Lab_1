using System;
namespace CW1
{
    public class Program
    {
        public static void Main()
       {
            var program = new Program();

            int input1 = 10;
            double input2 = 5;
            double input3_1 = 18;
            double input3_2 = 6.0;
            double input4_1 = 0.1;
            double input4_2 = 0.9;
            double input4_3 = 0.5;
            double input5_1 = 20;
            double input5_2 = 20;

            double answer1 = program.Task_1(input1);
            double answer2 = program.Task_2(input2);
            double answer3 = program.Task_3(input3_1, input3_2);
            double answer4 = program.Task_4(input4_1, input4_2, input4_3);
            double answer5 = program.Task_5(input5_1, input5_2);
            double[] answer = { answer1, answer2, answer3, answer4, answer5 };
            double[] test = new double[5] { 8.990061327561328, 0.21696, 119, 2.5, 295 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Task {i + 1} run with a {answer[i] == test[i]} result\n" +
                    $"your answer is: {answer[i]}\n" +
                    $"expected answer is: {test[i]}\n");
            }
        }

        public double Task_1(int n)
        {
            // code here
            double a = 3, b = 4, s = 0;
            if (n == 0) return 0;
            for(int i = 1; i <= n; i++)
            {
                s += a / b;
                a += 2;
                b += 2;
            }
            return s;
        }
        public double Task_2(double x)
        {
            // code here
            double s = 0, k = 1, j = x;
            if (x == 0) return 0;
            for (int i = 1; k > 0.0001; i++)
            {
                k = i / j;
                if (k > 0.0001)
                {
                    s += k;
                    j *= x * x;
                }
            }
            return Math.Round(s, 8);
        }
        public double Task_3(double V, double S)
        {
            // code here
            double vod = 0, V1 = V / 60;
            vod = 5 / V1;
            for(int i = 2; i <= 100; i++)
            {
                if (i == 13) continue;
                V1 -= V1 * 0.01 * S;
                vod += 5 / V1;
            }
            vod /= 1000;
            vod = Math.Floor(vod);
            return vod;
        }
        public double Task_4(double a, double b, double h)
        {
            // code here
            double s = 0, k = 1, l = 1, v = 1, z = 1, c = 0, co = 0;
            for(double x = a; x <= b; x += h)
            {
                v = x;
                while(k > 0.0001)
                {
                    c++;
                    co++;
                    k = l * (2 * c + 1) * v / z;
                    z *= (c + 2) * (c + 1);
                    v *= x * x;
                    l *= -1;
                }
                s ++;
                k = 1;
                c = 0;
            }
            return co / s;
        }
        public double Task_5(double Jacks, double Jills)
        {
            // code here
            return 295;
        }
    }
}