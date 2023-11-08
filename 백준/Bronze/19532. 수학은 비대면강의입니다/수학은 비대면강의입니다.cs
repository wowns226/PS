using System;

namespace BOJ_19532
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = inputs[0];
            int b = inputs[1];
            int c = inputs[2];
            int d = inputs[3];
            int e = inputs[4];
            int f = inputs[5];

            int i = 0, j = 0, x = 0, y = 0;
            if (a == 0)
            {
                y = c / b;
                x = (f - (e * y)) / d;
            }
            else if (d == 0)
            {
                y = f / e;
                x = (c - (b * y)) / a;
            }
            else
            {
                int temp = LCM(Math.Abs(a), Math.Abs(d));

                int g = temp / a;
                int h = temp / d;

                int bb = b * g;
                int cc = c * g;
                int ee = e * h;
                int ff = f * h;
            
                if (a*g==d*h)
                {
                    i = bb - ee;
                    j = cc - ff;
                }
                else
                {
                    i = bb + ee;
                    j = cc + ff;
                }

                y = j / i;
                x = (c - (b * y)) / a;
            }
            Console.WriteLine($"{x} {y}");
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}