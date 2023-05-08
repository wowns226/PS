namespace BOJ
{
    class No_1972
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));


            while(true)
            {
                string s = input.ReadLine();

                if(s == "*")
                    break;

                int len = 1;
                bool isSurprise = true;
                while(len<s.Length)
                {
                    List<string> list = new List<string>();
                    for(int i=0 ;i<s.Length; i++)
                    {
                        if(i + len >= s.Length) break;

                        string temp = "";
                        temp += s[i];
                        temp += s[i + len];

                        list.Add(temp);
                    }

                    for(int i=0 ;i<list.Count; i++)
                    {
                        for(int j=i+1 ;j<list.Count; j++)
                        {
                            if(list[i] == list[j])
                            {
                                isSurprise = false;
                                break;
                            }
                        }
                    }

                    if(!isSurprise) break;

                    len++;
                }

                if(isSurprise)
                    output.WriteLine($"{s} is surprising.");
                else
                    output.WriteLine($"{s} is NOT surprising.");
            }
        }
    }
}