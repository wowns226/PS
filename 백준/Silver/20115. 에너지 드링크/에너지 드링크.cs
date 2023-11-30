namespace BOJ_20115
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(Console.ReadLine());

            List<double> inputs = Array.ConvertAll(Console.ReadLine().Split(), double.Parse).ToList();

            inputs.Sort();

            while(inputs.Count > 1)
            {
                inputs[inputs.Count - 1] += inputs[0] / 2;
                inputs.RemoveAt(0);
            }
            
            sw.Write($"{inputs[0]}");
        }
    }
}
