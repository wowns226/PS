namespace BOJ_30010
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0 ; i < n ; i++)
                Console.Write($"{n - i} ");
        }
    }
}
