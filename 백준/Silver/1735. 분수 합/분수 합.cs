namespace BOJ
{
    static class Input<T>
    {
        static public T[] GetArray() => Array.ConvertAll(Console.ReadLine().Split(), ConvertTo);
        static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class No_1735
    {
        static void Main()
        {
            var inputs = Input<int>.GetArray();
            int child1 = inputs[0];
            int parent1 = inputs[1];
            inputs = Input<int>.GetArray();
            int child2 = inputs[0];
            int parent2 = inputs[1];

            int parent = LCM(parent1, parent2);
            int child = child1 * (parent / parent1) + child2 * (parent / parent2);

            int gcd = GCD(child, parent);
            Console.WriteLine($"{child / gcd} {parent / gcd}");
        }

        static int GCD(int a, int b)
        {
            if (a > b)
            {
                return a % b == 0 ? b : GCD(b, a % b);
            }
            else
            {
                return b % a == 0 ? a : GCD(a, b % a);
            }
        }

        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}