namespace Programmers
{
    class No_84512
    {
        static string[] chars = { "A", "E", "I", "O", "U" };

        static int count = 0;
        static int answer = 0;

        static void Main()
        {
            TestCase("AAAAE", 6);
            TestCase("AAAE", 10);
            TestCase("I", 1563);
            TestCase("EIO", 1189);
        }

        static void TestCase(string word, int answer)
        {
            var testCaseValue = Solution(word);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int Solution(string word)
        {
            dfs("", word);
            return answer;
        }

        static void dfs(string now, string target)
        {
            if(now.Equals(target))
            {
                answer = count;
                return;
            }
            if(now.Length == 5) return;
            for(int i = 0 ; i < chars.Length ; i++)
            {
                count++;
                string word = now + chars[i];
                dfs(word, target);
            }
        }
    }
}