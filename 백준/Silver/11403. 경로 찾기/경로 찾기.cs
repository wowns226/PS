using System.Text;

namespace BOJ
{
    class No_11403
    {
        const int MAX = 102;
        const int INF = 987654321;

        static int n;
        static int[,] board = new int[MAX, MAX];

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            n = int.Parse(Console.ReadLine());

            for(int i=0 ;i<n ;i++)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0 ;j<n ;j++)
                {
                    board[i, j] = inputs[j] == 0 ? INF : inputs[j];
                }
            }

            Floyd();

            for(int i = 0 ; i < n ; i++)
            {
                for(int j = 0 ; j < n ; j++)
                {
                    sb.Append(board[i, j] == INF ? "0 " : "1 ");
                }
                sb.Append('\n');
            }

            Console.WriteLine(sb.ToString());
        }

        static void Floyd()
        {
            for(int k = 0 ; k < n ; k++)
                for(int x = 0 ; x < n ; x++)
                    for(int y = 0 ; y < n ; y++)
                        if(board[x, y] > board[x, k] + board[k, y])
                            board[x, y] = board[x, k] + board[k, y];
        }
    }
}