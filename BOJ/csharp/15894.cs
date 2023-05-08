namespace BOJ
{
    class No_15894
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            long n = int.Parse(input.ReadLine());

            output.Write(n * 4);
        }
    }
}