using System.Numerics;

namespace BOJ
{
    class No_15700
    {
        static void Main()
        {
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var answer = BigInteger.Multiply(inputs[0], inputs[1]);
            answer = BigInteger.Divide(answer, 2);

            Console.WriteLine(answer);
        }
    }
}