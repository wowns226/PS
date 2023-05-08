namespace BOJ
{
    class No_25314
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());

            int count = n / 4;
            while(count-->0)
            {
                output.Write("long ");
            }

            output.Write("int");
        }
    }
}