namespace BOJ_24228
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            long[] inputs = sr.ReadLine().Split().Select(long.Parse).ToArray();
            long n = inputs[0];
            long r = inputs[1];

            sw.Write(n + (r * 2) - 1);
            
            sw.Flush(); sw.Close(); sr.Close();
        }
    }
}

