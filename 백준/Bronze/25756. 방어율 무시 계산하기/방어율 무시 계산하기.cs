namespace BOJ_25756
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(Console.ReadLine());

            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            double curDefense = 0f;
            for (int i = 0; i < n; i++)
            {
                curDefense = 1 - (1 - (curDefense * 0.01)) * (1 - (inputs[i] * 0.01));
                curDefense *= 100;
                sw.WriteLine(curDefense);
            }
        }
    }
}
