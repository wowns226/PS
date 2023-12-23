namespace BOJ
{
    class No_2420
    {
        static void Main()
        {
            long[] array = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            long answer = Math.Abs(array[0] - array[1]);

            Console.WriteLine(answer);
        }
    }   
}