using System.Diagnostics.Contracts;
using System.Text;

namespace BOJ_9328
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(sr.ReadLine());
            
            while (t-- > 0)
            {
                int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int h = inputs[0] + 2;
                int w = inputs[1] + 2;
                
                int answer = 0;

                bool[] keys = new bool[26];
                Queue<(int, int)>[] doors = new Queue<(int, int)>[26];
                for (int i = 0; i < 26; i++)
                {
                    doors[i] = new Queue<(int, int)>();
                }
                Queue<(int, int)> q = new Queue<(int, int)>();

                char[,] board = new char[h, w];
                bool[,] visited = new bool[h, w];
                
                int[] dx = { 1, 0, -1, 0 };
                int[] dy = { 0, 1, 0, -1 };
                
                // 외곽 테두리 추가
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        board[i, j] = '.';
                    }
                }
                
                for (int i = 1; i <= h-2; i++)
                {
                    string s = sr.ReadLine();
                    for (int j = 1; j <= w-2; j++)
                    {
                        board[i, j] = s[j-1];
                    }
                }

                string input = sr.ReadLine();
                if (input != "0")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        keys[input[i] - 'a'] = true;
                    }
                }

                q.Enqueue((0, 0));
                visited[0, 0] = true;
                
                while (q.Count > 0)
                {
                    var cur = q.Dequeue();
                    int x = cur.Item1;
                    int y = cur.Item2;

                    for (int dir = 0; dir < 4; dir++)
                    {
                        int nx = x + dx[dir];
                        int ny = y + dy[dir];

                        // 보드 범위 밖으로 나간 경우
                        if (nx < 0 || ny < 0 || nx >= h || ny >= w) continue;
                        // 벽인 경우
                        if (board[nx, ny] == '*') continue;
                        // 방문한 경우
                        if (visited[nx, ny] == true) continue;
                        
                        // 열쇠인 경우
                        if (IsKey(board[nx, ny]))
                        {
                            // 열쇠 저장
                            keys[board[nx, ny] - 'a'] = true;
                            
                            // 열쇠면 해당 위치로는 갈 수 있으니 큐에 담아
                            q.Enqueue((nx, ny));
                            visited[nx, ny] = true;

                            // 해당 열쇠로 열 수 있는 문들을 큐에 담음
                            var tempQ = doors[board[nx, ny] - 'a'];
                            while (tempQ.Count > 0)
                            {
                                var temp = tempQ.Dequeue();
                                q.Enqueue(temp);
                                visited[temp.Item1, temp.Item2] = true;
                            }
                        }
                        
                        // 문인 경우
                        if (IsDoor(board[nx, ny]))
                        {
                            // 열쇠가 있는 경우
                            if (keys[board[nx, ny] - 'A'] == true)
                            {
                                // 큐에 담아
                                q.Enqueue((nx, ny));
                                visited[nx, ny] = true;
                            }
                            // 열쇠가 없는 경우
                            else
                            {
                                // 문 큐에 넣음
                                doors[board[nx, ny] - 'A'].Enqueue((nx, ny));
                            }
                        }
                        
                        // 빈 공간인 경우
                        if (board[nx, ny] == '.')
                        {
                            // 그냥 큐에 담음
                            q.Enqueue((nx, ny));
                            visited[nx, ny] = true;
                        }
                        
                        // 문서인 경우
                        if (board[nx, ny] == '$')
                        {
                            // 정답 증가시키고 큐에 담음
                            answer++;
                            q.Enqueue((nx, ny));
                            visited[nx, ny] = true;
                        }
                    }
                }

                sb.AppendLine($"{answer}");
            }
            
            
            
            sw.Write(sb);
            
            sr.Close(); sw.Flush(); sw.Close();
        }

        static bool IsKey(char alp) => alp is >= 'a' and <= 'z';
        static bool IsDoor(char alp) => alp is >= 'A' and <= 'Z';
    }
}

