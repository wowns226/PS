namespace BOJ
{
    static class Input<T>
    {
        public static T Get() => ConvertTo(Console.ReadLine());
        private static T ConvertTo(string input) => (T)Convert.ChangeType(input, typeof(T));
    }
    
    class No_2485
    {
        static void Main()
        {
            int N = Input<int>.Get();

            List<int> trees = new List<int>();
            List<int> treeDistance = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int tree = Input<int>.Get();

                trees.Add(tree);
            }

            for (int i = 0; i < N - 1; i++)
            {
                int distance = trees[i + 1] - trees[i];
                
                treeDistance.Add(distance);
            }
            
            int count = 0;
            int gcd = treeDistance[0];
            for (int i = 1; i < N - 1; i++)
            {
                gcd = GCD(gcd, treeDistance[i]);
            }
            
            for (int i = 0; i < N - 1; i++) 
            {
                count += (treeDistance[i] / gcd) - 1;	
            }

            Console.WriteLine(count);
        }

        static int GCD(int x, int y)
        {
            int z = x % y;

            return z == 0 ? y : GCD(y, z);
        }
    }
}