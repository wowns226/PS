namespace BOJ
{
    class No_12100
    {
        public class Point
        {
            private int pointValue;
            private bool isMove;
            private bool isCombine;

            public bool IsActivated => pointValue == 0 ? false : true;
            public bool IsMove => isMove;
            public bool IsCombine => isCombine;

            public int Value
            {
                get => pointValue;
                set => pointValue = value;
            }

            public Point(int value)
            {
                pointValue = value;
            }

            public void Combine(Point other)
            {
                isCombine = true;
                pointValue <<= 1;
                other.Clear();
            }

            public void Clear()
            {
                pointValue = 0;
            }
        }

        public class Board
        {
            private Point[,] mainBoard;

            public Board(int num)
            {
                mainBoard = new Point[num, num];
            }

            public void SetTile(int x, int y, int value)
            {
                mainBoard[x, y] = new Point(value);
            }

            public int GetTileValue(int x, int y)
            {
                return mainBoard[x, y].Value;
            }

            public void MoveUpRow(int rowIndex)
            {
                for(int i = 0 ; i < n ; i++)
                {
                    if(!mainBoard[i, rowIndex].IsActivated) continue;

                    for(int j = i + 1 ; j < n ; j++)
                    {
                        if(!mainBoard[j, rowIndex].IsActivated) continue;

                        if(mainBoard[i, rowIndex].Value == mainBoard[j, rowIndex].Value)
                        {
                            mainBoard[i, rowIndex].Combine(mainBoard[j, rowIndex]);
                        }
                        else
                        {
                            i = j - 1;
                        }
                        break;
                    }
                }

                for(int i = 0 ; i < n ; i++)
                {
                    if(mainBoard[i, rowIndex].IsActivated)
                    {
                        int j = i - 1;
                        while(j >= 0 && !mainBoard[j, rowIndex].IsActivated)
                        {
                            mainBoard[j, rowIndex].Value = mainBoard[j + 1, rowIndex].Value;
                            mainBoard[j + 1, rowIndex].Clear();
                            j--;
                        }
                    }
                }
            }

            public void MoveUp()
            {
                for(int i = 0 ; i < n ; i++)
                {
                    MoveUpRow(i);
                }
            }

            public void Rotate()
            {
                Point[,] tempBoard = new Point[n, n];

                for(int x = 0 ; x < n ; x++)
                {
                    for(int y = 0 ; y < n ; y++)
                    {
                        tempBoard[x, y] = mainBoard[y, n - x - 1];
                    }
                }

                mainBoard = tempBoard;
            }

            public int FindMaxBlock()
            {
                int maxBlock = 0;
                for(int i = 0 ; i < n ; i++)
                {
                    for(int j = 0 ; j < n ; j++)
                    {
                        maxBlock = Math.Max(maxBlock, mainBoard[i, j].Value);
                    }
                }
                return maxBlock;
            }
        }

        const int MAX_MOVE_COUNT = 5;
        static int n;

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            Board board = new Board(n);

            for(int x = 0 ; x < n ; x++)
            {
                string[] row = Console.ReadLine().Split();
                for(int y = 0 ; y < n ; y++)
                {
                    int value = int.Parse(row[y]);
                    board.SetTile(x, y, value);
                }
            }

            int maxBlock = FindMaxValue(board, 0);
            Console.WriteLine(maxBlock);
        }

        static int FindMaxValue(Board board, int moveCount)
        {
            if(moveCount == MAX_MOVE_COUNT)
            {
                return board.FindMaxBlock();
            }

            int maxBlock = 0;
            for(int i = 0 ; i < 4 ; i++)
            {
                Board newBoard = new Board(n);
                newBoard = DeepCopy(board);
                newBoard.MoveUp();
                maxBlock = Math.Max(maxBlock, FindMaxValue(newBoard, moveCount + 1));
                board.Rotate();
            }

            return maxBlock;
        }

        static Board DeepCopy(Board original)
        {
            Board copy = new Board(n);
            for(int x = 0 ; x < n ; x++)
            {
                for(int y = 0 ; y < n ; y++)
                {
                    copy.SetTile(x, y, original.GetTileValue(x, y));
                }
            }

            return copy;
        }
    }
}