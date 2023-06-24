namespace Programmers
{
    class No_42586
    {
        static void Main()
        {
            TestCase(new int[] { 93, 30, 55 }, new int[] { 1, 30, 5 }, new int[] { 2, 1 });
            TestCase(new int[] { 95, 90, 99, 99, 80, 99 }, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 3, 2 });
        }

        static void TestCase(int[] progresses, int[] speeds, int[] answer)
        {
            var testCaseValue = Solution(progresses, speeds);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int[] Solution(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>();
            int[] days = new int[progresses.Length];

            for(int i = 0 ; i < progresses.Length ; i++)
            {
                int day = (100 - progresses[i]) / speeds[i];

                if((100 - progresses[i]) % speeds[i] == 0)
                    days[i] = day;
                else
                    days[i] = day + 1;
            }

            int count = 1;
            int maxDay = days[0];
            for(int i = 1 ; i < days.Length ; i++)
            {

                if(maxDay < days[i])
                {
                    answer.Add(count);
                    maxDay = days[i];
                    count = 1;
                }
                else
                {
                    count++;
                    continue;
                }

            }

            answer.Add(count);

            return answer.ToArray();
        }
    }
}