namespace BOJ
{
    class No_16165
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];
            Dictionary<string,List<string>> girlgroups = new Dictionary<string,List<string>>();
            Dictionary<string,string> girlgroupMember = new Dictionary<string,string>();

            while(n-->0)
            {
                string girlgroup = input.ReadLine();
                int memberNum = int.Parse(input.ReadLine());

                girlgroups.Add(girlgroup, new List<string>());

                while(memberNum-->0)
                {
                    string member = input.ReadLine();
                    girlgroups[girlgroup].Add(member);
                    girlgroupMember.Add(member, girlgroup);
                }

                girlgroups[girlgroup].Sort();
            }

            while(m-->0)
            {
                string quiz = input.ReadLine();
                int quizType = int.Parse(input.ReadLine());

                if(quizType == 0)
                {
                    foreach(var member in girlgroups[quiz])
                        output.WriteLine(member);
                }
                else
                {
                    output.WriteLine(girlgroupMember[quiz]);
                }
            }
        }
    }
}