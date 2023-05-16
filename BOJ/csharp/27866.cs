namespace BOJ
{
    class No_27866
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string s = input.ReadLine();
            int i = int.Parse(input.ReadLine());

            output.Write(s[i - 1]);
        }
    }
}
