namespace BOJ
{
    static class Input<T>
    {
        public static T GetInput() => ConvertStringToType(Console.ReadLine());
        public static T[] GetInputArray() => Array.ConvertAll(Console.ReadLine().Split(), ConvertStringToType);
        private static T ConvertStringToType(string input) => (T)Convert.ChangeType(input, typeof(T));
    }

    class No_9063
    {
        static void Main()
        {
            int n = Input<int>.GetInput();

            int maxX = -987654321, maxY = -987654321;
            int minX = 987654321, minY = 987654321;
            for (int i = 0; i < n; i++)
            {
                var inputs = Input<int>.GetInputArray();

                maxX = Math.Max(maxX, inputs[0]);
                minX = Math.Min(minX, inputs[0]);
                maxY = Math.Max(maxY, inputs[1]);
                minY = Math.Min(minY, inputs[1]);
            }
            
            if (n == 1)
            {
                Console.WriteLine(0);

                return;
            }

            Console.WriteLine((maxX - minX) * (maxY - minY));
        }
    }
}