namespace Programmers
{
    class No_42584
    {
        static void Main()
        {
            TestCase(new int[] { 1, 2, 3, 2, 3 }, new int[] { 4, 3, 1, 1, 0 });
        }

        static void TestCase(int[] prices, int[] answer)
        {
            var testCaseValue = Solution(prices);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int[] Solution(int[] prices)
        {
            List<int> answer = new List<int>();

            Queue<int> q = new Queue<int>(prices);
            int idx = 1;
            while(q.Count > 0)
            {
                int curPrice = q.Dequeue();
                int time = 0;

                for(int i = idx ; i < prices.Length ; i++)
                {
                    time++;
                    if(curPrice > prices[i] || i == prices.Length - 1)
                    {
                        answer.Add(time);
                        break;
                    }
                }

                idx++;
            }

            answer.Add(0);
            return answer.ToArray();
        }
    }
}