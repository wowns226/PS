namespace BOJ
{
    class No_4562
    {
        static void Main(string[] args)
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());

            while(n-->0)
            {
                int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

                if(inputs[0] < inputs[1])
                    output.WriteLine("NO BRAINS");
                else
                    output.WriteLine("MMM BRAINS");
            }
        }
    }
}