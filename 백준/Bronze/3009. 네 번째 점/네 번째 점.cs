namespace BOJ
{
    static class Input<T>  
    {
        public static T[] GetInputArray() => Array.ConvertAll(Console.ReadLine().Split(), ConvertStringToType);
        private static T ConvertStringToType(string input) => (T)Convert.ChangeType(input, typeof(T));
    }  
      
    class No_27323
    {
        static void Main()
        {
            HashSet<int> xHashSet = new HashSet<int>();
            HashSet<int> yHashSet = new HashSet<int>();
            for (int i = 0; i < 3; i++)
            {
                var input = Input<int>.GetInputArray();

                if (!xHashSet.Add(input[0]))
                {
                    xHashSet.Remove(input[0]);
                }

                if (!yHashSet.Add(input[1]))
                {
                    yHashSet.Remove(input[1]);
                }
            }

            Console.WriteLine($"{xHashSet.First()} {yHashSet.First()}");
        }
    }
}