namespace BOJ_6749
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int gap = m - n;
            Console.WriteLine(m+gap);
        }
    }
}
