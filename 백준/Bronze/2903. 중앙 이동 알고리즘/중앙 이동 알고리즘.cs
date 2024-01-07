namespace BOJ
{
    class No_2903
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int temp = 3;
            while (--n > 0)
            {
                temp = temp * 2 - 1;
            }

            temp = (int)Math.Pow(temp, 2);

            Console.WriteLine(temp);
        }
    }
}