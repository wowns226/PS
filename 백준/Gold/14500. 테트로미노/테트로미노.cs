using System.Text;

namespace BOJ
{    
    class No_20529
    {
        static void Main()
        {
            List<int[,]> shapeList = new List<int[,]>()
            {
                new int[2, 2] { { 1, 1 }, { 1, 1 } },
                new int[1, 4] { { 1, 1 , 1, 1 } },
                new int[4, 1] { { 1 }, { 1 } ,{ 1 },{ 1 } },

                new int[2,3]{ { 1, 1, 1 }, { 1, 0, 0 } },
                new int[2,3]{ { 1, 0, 0 }, { 1, 1, 1 } },
                new int[2,3]{ { 0, 0, 1 }, { 1, 1, 1 } },
                new int[2,3]{ { 1, 1, 1 }, { 0, 0, 1 } },

                new int[3,2]{ { 1, 1 }, { 1, 0 }, { 1, 0 } },
                new int[3,2]{ { 1, 0 }, { 1, 0 }, { 1, 1 } },
                new int[3,2]{ { 0, 1 }, { 0, 1 }, { 1, 1 } },
                new int[3,2]{ { 1, 1 }, { 0, 1 }, { 0, 1 } },

                new int[2,3]{ { 1, 1, 0 }, { 0, 1, 1 } },
                new int[2,3]{ { 0, 1, 1 }, { 1, 1, 0 } },
                new int[3,2]{ { 1, 0 }, { 1, 1 }, { 0, 1 } },
                new int[3,2]{ { 0, 1 }, { 1, 1 }, { 1, 0 } },

                new int[2,3]{ { 1, 1, 1 }, { 0, 1, 0 } },
                new int[2,3]{ { 0, 1, 0 }, { 1, 1, 1 } },
                new int[3,2]{ { 0, 1 }, { 1, 1 }, { 0, 1 } },
                new int[3,2]{ { 1, 0 }, { 1, 1 }, { 1, 0 } }
            };

            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];

            int[,] board = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = inputs[j];
                }
            }

            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    foreach (int[,] t in shapeList)
                    {
                        if (i + t.GetLength(0) > n) continue;
                        if (j + t.GetLength(1) > m) continue;

                        int sum = 0;
                        for (int x = 0; x < t.GetLength(0); x++)
                        {
                            for (int y = 0; y < t.GetLength(1); y++)
                            {
                                if (t[x, y] == 0) continue;

                                sum += board[i + x, j + y];
                            }
                        }
                        
                        answer = Math.Max(answer, sum);
                    }
                }
            }

            Console.WriteLine(answer);
        }
    }
}