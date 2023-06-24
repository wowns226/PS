namespace Programmers
{
    class No_86491
    {
        static void Main()
        {
            int[,] sizes = { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };

            Solution sol = new Solution();

            int answer = sol.solution(sizes);

            Console.Write($"{answer}");
        }
    }

    public class Solution
    {
        public int solution(int[,] sizes)
        {
            int maxWidth = 0;
            int maxHeight = 0;

            for(int i = 0 ; i < sizes.GetLength(0) ; i++)
            {
                int width = sizes[i, 0];
                int height = sizes[i, 1];

                if(width < height)
                {
                    int temp = width;
                    width = height;
                    height = temp;
                }

                maxWidth = Math.Max(maxWidth, width);
                maxHeight = Math.Max(maxHeight, height);
            }

            return maxWidth * maxHeight;
        }
    }
}