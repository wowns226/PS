class Program
{
    static void Main(string[] args)
    {
        using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int testCase = int.Parse(input.ReadLine());

        while(testCase-->0)
        {
            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
            int w = inputs[0];
            int h = inputs[1];

            char[,] board = new char[w, h];
            int[,] dist1 = new int[w, h];
            int[,] dist2 = new int[w, h]; 
            bool[,] visited1 = new bool[w, h];
            bool[,] visited2 = new bool[w, h];
            Queue<(int, int)> q1 = new Queue<(int, int)>();
            Queue<(int, int)> q2 = new Queue<(int, int)>();

            for(int i=0 ;i<h ;i++)
            {
                char[] inputString = input.ReadLine().ToCharArray();
                for(int j=0 ;j<w ;j++)
                {
                    board[j,i] = inputString[j];

                    dist1[j, i] = -1;
                    dist2[j, i] = -1;

                    if(inputString[j] == '*')
                    {
                        dist1[j, i] = 1;
                        visited1[j, i] = true;
                        q1.Enqueue((j, i));
                    }
                    else if(inputString[j] == '@')
                    {
                        dist2[j, i] = 1;
                        visited2[j, i] = true;
                        q2.Enqueue((j, i));
                    }
                }

            }

            int[] dx = new int[] { 1, 0, -1, 0 };
            int[] dy = new int[] { 0, 1, 0, -1 };

            while(q1.Count>0)
            {
                var cur = q1.Dequeue();

                for(int dir=0 ;dir<dx.Length ;dir++)
                {
                    int nx = cur.Item1 + dx[dir];
                    int ny = cur.Item2 + dy[dir];

                    if(nx < 0 || nx >= w || ny < 0 || ny >= h) continue;
                    if(dist1[nx, ny] >= 0 || board[nx, ny] == '#') continue;

                    visited1[nx,ny] = true;
                    dist1[nx, ny] = dist1[cur.Item1, cur.Item2] + 1;
                    q1.Enqueue((nx, ny));
                }
            }

            bool isExit = false;
            int answer = 0;

            while(q2.Count>0)
            {
                var cur = q2.Dequeue();

                for(int dir = 0 ; dir < dx.Length ; dir++)
                {
                    int nx = cur.Item1 + dx[dir];
                    int ny = cur.Item2 + dy[dir];

                    if(nx < 0 || nx >= w || ny < 0 || ny >= h)
                    {
                        isExit = true;
                        q2.Clear();
                        answer = dist2[cur.Item1, cur.Item2];
                        break;
                    }
                    if(dist2[nx, ny] >= 0 || board[nx, ny] == '#') continue;
                    if(dist1[nx,ny] != -1 && dist1[nx, ny] <= dist2[cur.Item1, cur.Item2] + 1) continue;

                    visited2[nx, ny] = true;
                    dist2[nx, ny] = dist2[cur.Item1, cur.Item2] + 1;
                    q2.Enqueue((nx, ny));
                }
            }

            if(!isExit)
                output.WriteLine("IMPOSSIBLE");
            else
                output.WriteLine(answer);
        }
    }
}
