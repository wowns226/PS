using System.Text;

namespace BOJ
{
    static class Input<T>
    {
        public static T[] GetArray() => Array.ConvertAll(Console.ReadLine().Split(), ConvertTo);
        private static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class No_13241
    {
        static void Main()
        {
            long[] inputs = Input<long>.GetArray();

            Console.WriteLine(LCM(inputs[0], inputs[1]));
        }

        static long LCM(long a, long b)
        {
            long gcd = GCD(a, b);
            long lcm = (a * b) / gcd;

            return lcm;
        }
        
        static long GCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}