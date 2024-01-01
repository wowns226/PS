List<int[,]> shapeList = new List<int[,]>()
{
    new int[2, 2] { { 1, 1 }, { 1, 1 } },
    new int[1, 4] { { 1, 1, 1, 1 } },
    new int[4, 1] { { 1 }, { 1 }, { 1 }, { 1 } },

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
foreach (var item in shapeList)
{
    for (int i = 0; i < n - (item.GetLength(0) - 1) ; i++)
    {
        for (int j = 0; j < m - (item.GetLength(1) - 1); j++)
        {
            int sum = 0;
            for (int x = 0; x < item.GetLength(0); x++)
            {
                for (int y = 0; y < item.GetLength(1); y++)
                {
                    if(item[x, y] == 0) continue;

                    sum += board[x + i, y + j];
                }
            }

            if (answer < sum)
            {
                answer = sum;
            }
        }
    }
}

Console.WriteLine(answer);