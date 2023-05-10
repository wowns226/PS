namespace BOJ
{
    class No_28018
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());
            int[] board = new int[1_000_005];

            while(n-->0)
            {
                int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                int start = inputs[0];
                int end = inputs[1]+1;

                board[start]++;
                board[end]--;
            }

            int m = int.Parse(input.ReadLine());
            int[] nums = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int temp = 0;
            for(int i=0 ;i<board.Length ;i++)
            {
                if(board[i] != 0)
                    temp += board[i];

                board[i] = temp;
            }

            for(int i = 0 ; i < m ; i++)
                output.WriteLine(board[nums[i]]);
        }
    }
}