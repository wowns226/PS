namespace BOJ_20115
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(Console.ReadLine());

            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            long sum = 0;
            int max = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i];
                max = Math.Max(max, inputs[i]);
            }

            double answer = (max * 0.5) + (sum * 0.5);
            
            sw.Write($"{answer}");
        }
    }
}
