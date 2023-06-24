namespace Programmers
{
    class No_42840
    {
        static void Main()
        {
            TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1 });
            TestCase(new int[] { 1, 3, 2, 4, 2 }, new int[] { 1, 2, 3 });
        }

        static void TestCase(int[] answers, int[] answer)
        {
            var testCaseValue = Solution(answers);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int[] Solution(int[] answers)
        {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            int[] B = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] C = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            var answer = new int[]
            {
                answers.Where((n,idx)=>n==A[idx%A.Count()]).Count(),
                answers.Where((n,idx)=>n==B[idx%B.Count()]).Count(),
                answers.Where((n,idx)=>n==C[idx%C.Count()]).Count()
            };

            return answer.Select((n, idx) => new { Index = idx + 1, N = n })
                .Where(t => t.N == answer.Max())
                .Select(t => t.Index).ToArray();
        }
    }
}