namespace Programmers
{
    class No_43165
    {
        static int answer = 0;

        static void Main()
        {
            Console.WriteLine(TestCase(new int[] { 1, 1, 1, 1, 1 }, 3, 5));
            Console.WriteLine(TestCase(new int[] { 4, 1, 2, 1 }, 4, 2));
        }

        static string TestCase(int[] numbers, int target, int returnValue)
        {
            int testCaseValue = Solution(numbers, target);

            if(testCaseValue == returnValue)
                return "성공";

            return "실패";
        }

        static int Solution(int[] numbers, int target)
        {
            int answer = 0;

            DFS(numbers, target, 0, 0, ref answer);

            return answer;
        }

        static void DFS(int[] numbers, int target, int idx, int number, ref int answer)
        {
            if(idx == numbers.Length)
            {
                if(number == target) answer++;

                return;
            }

            DFS(numbers, target, idx + 1, number + numbers[idx], ref answer);
            DFS(numbers, target, idx + 1, number - numbers[idx], ref answer);
        }
    }
}