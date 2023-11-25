using System.Numerics;

namespace BOJ_1271
{
    class Program
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();

            BigInteger n = BigInteger.Parse(s[0]);
            BigInteger m = BigInteger.Parse(s[1]);

            Console.WriteLine(BigInteger.Divide(n, m));
            Console.WriteLine(BigInteger.Remainder(n,m));
        }
    }
}
