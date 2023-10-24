using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOJ_30009
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int> t = new List<int>(n);
            for(int i=0 ; i < n; i++)
                t.Add(int.Parse(Console.ReadLine()));

            int minX = inputs[0] - inputs[2];
            int centerX = inputs[0];
            int maxX = inputs[0] + inputs[2];

            Console.WriteLine($"{t.Count(x => x > minX && x < maxX)} {t.Count(x => x == minX || x == maxX)}");
        }
    }
}
