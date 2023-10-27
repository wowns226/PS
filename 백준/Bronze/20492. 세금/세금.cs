namespace BOJ_20492
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double tax1 = n * 0.22;
            double answer = n - tax1;

            double x = n * 0.80;
            double y = n - x;
            double tax2 = y * 0.22;
            double answer2 = x + y - tax2;

            Console.WriteLine(answer + " " + answer2);
        }
    }
}
