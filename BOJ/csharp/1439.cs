namespace BOJ
{
    class No_1439
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string s = input.ReadLine();

            int one = 0, zero = 0;
            for(int i=0 ;i<s.Length ;i++)
            {
                if(i > 0 && s[i] == s[i - 1])
                    continue;

                if(s[i] == '0')
                    zero++;
                else if(s[i] == '1')
                    one++;
            }

            output.Write(Math.Min(one, zero));
        }
    }
}