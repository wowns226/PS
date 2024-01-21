namespace BOJ
{
    static class Input<T>
    {
        public static T[] GetArray() => Array.ConvertAll(Console.ReadLine().Split(), ConvertTo);
        private static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class No_14215
    {
        static void Main()
        {
            int[] arr = Input<int>.GetArray();
            Array.Sort(arr);
            Console.WriteLine(arr[0] + arr[1] > arr[2] ? arr[0] + arr[1] + arr[2] : (arr[0] + arr[1]) * 2 - 1);
        }
    }
}