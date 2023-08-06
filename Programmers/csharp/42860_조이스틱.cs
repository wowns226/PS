namespace Programmers
{
    class No_42860
    { 
        static void Main()
        {
            TestCase("JEROEN", 56);
            TestCase("JAN", 23);
        }

        static void TestCase(string name, int answer)
        {
            var testCaseValue = Solution(name);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int Solution(string name)
        {
            int answer = 0;
            int n = name.Length;
            int leftOrRight = name.Length - 1;
            for(int i = 0 ; i < n ; i++)
            {
                int next = i + 1;
                char target = name[i];
                 
                //첫 알파벳이 A~N 오른쪽 이동
                if(target <= 'N') answer += target - 'A'; 
                //첫 알파벳이  O~Z 왼쪽 이동
                else answer += 'Z' - target + 1; 

                while(next < n && name[next] == 'A') next++;
                leftOrRight = Math.Min(leftOrRight, i + n - next + Math.Min(i, n - next));
            }
            answer += leftOrRight;
            return answer;
        }
    }
}