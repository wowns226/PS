namespace Programmers
{
    class No_12909
    {
        static void Main()
        {
            TestCase("()()", true);
            TestCase("(())()", true);
            TestCase(")()(", false);
            TestCase("(()(", false);
        }

        static void TestCase(string s, bool answer)
        {
            var testCaseValue = Solution(s);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static bool Solution(string s)
        {
            int idx = 0;

            for(int i = 0 ; i < s.Length ; i++)
            {
                if(s[i] == '(')
                {
                    idx++;
                }
                else if(s[i] == ')')
                {
                    if(idx == 0)
                    {
                        return false;
                    }
                    else
                    {
                        idx--;
                    }
                }
            }

            if(idx > 0) return false;

            return true;
        }
    }
}