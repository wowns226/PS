namespace Programmers
{
    class No_42747
    {
        static void Main()
        {
            TestCase(new int[] { 3, 0, 6, 1, 5 }, 3);
        }

        static void TestCase(int[] citations, int answer)
        {
            var testCaseValue = Solution(citations);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int Solution(int[] citations)
        {
            int answer = 0;

            // 정렬 => 6 5 3 1 0
            Array.Sort(citations, (x, y) => 
            {
                return x < y ? 1 : -1;
            }); 

            int citationCount = citations.Length; // 발표한 논문의 수
            for(int i=0 ;i<citations.Length;i++)
            {
                // 논문의 수가 인용된 수보다 작거나 같으면
                if((i + 1) <= citations[i]) answer++;
            }

            return answer;
        }
    }
}