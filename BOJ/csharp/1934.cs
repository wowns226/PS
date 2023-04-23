using System;
using System.Collections.Generic;
using System.Text;

namespace BOJ
{
    internal class MainApp
    {
        static int GCD(int _a, int _b)
        {
            int r = _a % _b;
            if (r == 0)
            {
                return _b;
            }

            return GCD(_b, r);
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int n, answer, a, b, temp;
            n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                a = int.Parse(inputs[0]);
                b = int.Parse(inputs[1]);

                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }

                answer = (a * b) / GCD(a, b);

                sb.AppendLine(answer.ToString());
            }

            Console.Write(sb.ToString());
        }
    }
}