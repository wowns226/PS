namespace BOJ_30011
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int answer = 0;

            if(n == 1)
            {
                answer = 180 * (inputs[0] - 2);
            }
            else
            {
                answer += (180 * (inputs[0] - 2));

                for (int i=1 ;i<n ;i++)
                    answer += (inputs[i] * 180);
            }

            Console.WriteLine(answer);
        }
    }
}
