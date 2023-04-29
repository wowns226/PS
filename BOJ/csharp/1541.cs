namespace BOJ
{
    class No_1541
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string s = input.ReadLine();

            int answer = 0;
            string num = string.Empty;
            bool isMinus = false;

            for(int i = 0 ; i <= s.Length ; i++)
            {
                if(i == s.Length)
                {
                    if(isMinus)
                    {
                        answer -= int.Parse(num);
                        num = string.Empty;
                    }
                    else
                    {
                        answer += int.Parse(num);
                        num = string.Empty;
                    }

                    break;
                }
                
                if(s[i] == '-' || s[i] == '+')
                {
                    if(isMinus)
                    {
                        answer -= int.Parse(num);
                        num = string.Empty;
                    }
                    else
                    {
                        answer += int.Parse(num);
                        num = string.Empty;
                    }
                }
                else
                {
                    num += s[i];
                }

                if(s[i]== '-')
                    isMinus = true;
            }

            output.Write(answer);
        }
    }
}