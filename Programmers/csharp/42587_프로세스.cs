namespace Programmers
{
    class No_42587
    {
        static void Main()
        {
            TestCase(new int[] { 2, 1, 3, 2 }, 2, 1);
            TestCase(new int[] { 1, 1, 9, 1, 1, 1 }, 0, 5);
        }

        static void TestCase(int[] priorities, int location, int answer)
        {
            var testCaseValue = Solution(priorities, location);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int Solution(int[] priorities, int location)
        {
            int answer = 0;
            Queue<(int, int)> q = new Queue<(int, int)>();
            for(int i = 0 ; i < priorities.Length ; i++)
            {
                q.Enqueue((i, priorities[i]));
            }
            // (2,0) , (1,1) , (3,2) , (2,3)

            while(true)
            {
                int myMax = q.Max(x => x.Item2);

                var cur = q.Dequeue();

                if(cur.Item2 == myMax)
                {
                    if(cur.Item1 == location)
                        return answer + 1;
                    else
                    {
                        answer++;
                        continue;
                    }
                }

                q.Enqueue(cur);
            }
        }
    }
}