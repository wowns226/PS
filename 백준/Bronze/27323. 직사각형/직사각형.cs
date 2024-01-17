namespace BOJ  
{  
    static class Input<T>  
    {  
        public static T GetInput() => ConvertStringToType(Console.ReadLine());
        private static T ConvertStringToType(string input) => (T)Convert.ChangeType(input, typeof(T));  
    }  
      
    class No_27323
    {
        static void Main()
        {
            int a = Input<int>.GetInput();
            int b = Input<int>.GetInput();

            Console.WriteLine(a * b);
        }
    }
}