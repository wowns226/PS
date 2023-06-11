namespace BOJ
{
    class No_1550
    {
        static void Main(string[] args)
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string s = input.ReadLine();

            var answer = Convert.ToInt32(s, 16);

            Console.WriteLine(answer);
        }
    }
}