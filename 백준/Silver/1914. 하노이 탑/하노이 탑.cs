using System.Numerics;
using System.Text;

namespace BOJ
{
    class No_1914
    {
        static int callCount = 0; 
        static StringBuilder sb = new StringBuilder();
        
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 20)
            {
                Console.WriteLine($"{BigInteger.Subtract((BigInteger)Math.Pow(2, n), 1)}");
                return;
            }
            
            Hanoi(n, 1, 2, 3);

            Console.WriteLine(callCount);
            Console.WriteLine(sb);
        }

        static void Move(int from, int to)
        {
            sb.AppendLine($"{from} {to}");
        }

        static void Hanoi(int n, int from, int by, int to)
        {
            if (n == 0) return;

            callCount++;
            Hanoi(n - 1, from, to, by);
            Move(from, to);
            Hanoi(n - 1, by, from, to);
        }
    }   
}