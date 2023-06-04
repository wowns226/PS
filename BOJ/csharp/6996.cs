using System.Text;

namespace cs
{
    class No_6996
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int t = int.Parse(input.ReadLine());
            while(t-->0)
            {
                string[] inputs = input.ReadLine().Split();
                string s1 = inputs[0];
                string s2 = inputs[1];

                output.WriteLine(Anagrams(s1, s2));
            }
        }

        static string Anagrams(string s1, string s2)
        {
            StringBuilder sb = new StringBuilder();

            var s3 = s1.OrderBy(x => x).ToList();
            var s4 = s2.OrderBy(x => x).ToList();

            bool check = false;

            if(s3.Count != s4.Count)
            {
                check = true;
            }
            else
            {
                for(int i = 0 ; i < s3.Count ; i++)
                {
                    if(s3[i] != s4[i])
                    {
                        check = true;
                        break;
                    }
                }
            }

            if(!check)
                sb.Append($"{s1} & {s2} are anagrams.");
            else
                sb.Append($"{s1} & {s2} are NOT anagrams.");

            return sb.ToString();
        }
    }
}