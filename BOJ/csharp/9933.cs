namespace cs
{
    class No_9933
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            List<string> list = new List<string>();
            int t = int.Parse(input.ReadLine());
            while(t-->0)
            {
                string s = input.ReadLine();

                list.Add(s);
            }

            for(int i=0 ;i<list.Count; i++)
            {
                string temp = list[i];
                string reverse = new string(temp.Reverse().ToArray());

                for(int j=0 ;j<list.Count ;j++)
                {
                    if(reverse.Equals(list[j]))
                    {
                        string answer = list[j];

                        output.Write($"{answer.Length} {answer[answer.Length / 2]}");

                        return;
                    }
                }
            }
        }
    }
}