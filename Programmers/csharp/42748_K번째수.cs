namespace Programmers
{
    class No_42748
    {
        static void Main()
        {
            int[] array = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

            Solution sol = new Solution();

            int[] answer = sol.solution(array, commands);

            foreach(int i in answer)
            {
                Console.Write($"{i} ");
            }
        }
    }

    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            List<int> list = new List<int>(array);

            for(int c=0 ;c<commands.GetLength(0) ; c++)
            {
                int i = commands[c,0]-1;
                int j = commands[c,1];
                int k = commands[c,2]-1;

                var list2 = list.Where((x, idx) => idx >= i && idx < j).OrderBy(x => x).ToList();

                answer[c] = list2[k];
            }

            return answer;
        }
    }
}