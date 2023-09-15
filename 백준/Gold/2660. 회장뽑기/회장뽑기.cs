using System.Text;

namespace BOJ
{
    class No_2660
    {
        const int INF = 987654321;

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] arr = new int[N + 1, N + 1];

            for(int i = 1 ; i <= N ; i++)
            {
                for(int j = 1 ; j <= N ; j++)
                {
                    if(i != j)
                    {
                        arr[i, j] = INF;
                    }
                }
            }

            while(true)
            {
                string[] input = Console.ReadLine().Split();
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);

                if(x == -1 && y == -1)
                {
                    break;
                }

                arr[x, y] = arr[y, x] = 1;
            }

            for(int k = 1 ; k <= N ; k++)
            {
                for(int i = 1 ; i <= N ; i++)
                {
                    for(int j = 1 ; j <= N ; j++)
                    {
                        if(arr[i, j] > arr[i, k] + arr[k, j])
                        {
                            arr[i, j] = arr[i, k] + arr[k, j];
                        }
                    }
                }
            }

            int readerScore = INF;

            int[] scoreArr = new int[N + 1];

            for(int i = 1 ; i <= N ; i++)
            {
                int score = 0;
                for(int j = 1 ; j <= N ; j++)
                {
                    if(arr[i, j] != INF)
                    {
                        score = Math.Max(score, arr[i, j]);
                    }
                }

                scoreArr[i] = score;
                readerScore = Math.Min(readerScore, score);
            }

            StringBuilder sb1 = new StringBuilder();
            sb1.Append(readerScore + " ");

            StringBuilder sb2 = new StringBuilder();
            int readerNum = 0;

            for(int i = 1 ; i <= N ; i++)
            {
                if(readerScore == scoreArr[i])
                {
                    readerNum++;
                    sb2.Append(i + " ");
                }
            }

            sb1.Append(readerNum);

            Console.WriteLine(sb1.ToString());
            Console.WriteLine(sb2.ToString());
        }
    }
}