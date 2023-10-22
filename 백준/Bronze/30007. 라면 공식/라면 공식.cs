using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOJ_30007
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());

            int[] inputs;
            while(n-->0)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int answer = (inputs[2] - 1) * inputs[0] + inputs[1];
                sb.AppendLine(answer.ToString());
            }

            Console.Write(sb.ToString());
        }
    }
}
