namespace cs
{
    class No_1543
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string s1 = input.ReadLine();
            string s2 = input.ReadLine();

            int ans = 0;
            int wordLen = s2.Length;

            if(s1.Length < wordLen)
            {
                output.Write(0);
                return;
            }
            else
            {
                for(int i=0 ;i<=s1.Length-wordLen ;i++)
                {
                    if(s1[i] == s2[0])
                    {
                        string sub = s1.Substring(i, wordLen);
                        if( sub == s2)
                        {
                            ans++;
                            i += (wordLen - 1);
                        }
                    }
                }
            }

            output.Write(ans);
        }
    }
}