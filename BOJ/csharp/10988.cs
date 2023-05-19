namespace BOJ
{
    class No_10988
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string s = input.ReadLine();

            string reverse = "";

            for(int i = s.Length - 1 ; i >= 0 ; i--)
                reverse += s[i];

            if(s == reverse)
                output.Write(1);
            else
                output.Write(0);
        }
    }
}
