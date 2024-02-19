namespace BOJ
{
    static class Input<T>
    {
        public static T[] GetArray() => Array.ConvertAll(Console.ReadLine().Split(), ConvertTo);
        private static T ConvertTo(string input) => (T)Convert.ChangeType(input, typeof(T));
    }
    
    class No_14890
    {
        static void Main()
        {
            //입력
            //가로 방향과 세로 방향으로 각각 지형을 탐색하면서 경사로를 설치할 수 있는지 확인
            //설치한 경사로가 유효한지 검사
            //결과를 출력
            
            int[] NL = Input<int>.GetArray();
            int N = NL[0];
            int L = NL[1];

            int[,] map = new int[N, N]; // 지형 정보를 저장할 배열

            // 지형 정보 입력
            for (int i = 0; i < N; i++)
            {
                int[] inputs = Input<int>.GetArray();
                for (int j = 0; j < N; j++)
                {
                    map[i, j] = inputs[j];
                }
            }
            
            int count = 0; // 유효한 경사로의 개수

            // 가로 방향 탐색
            for (int i = 0; i < N; i++)
            {
                bool[] visited = new bool[N]; // 이미 경사로가 설치된 위치인지를 표시하기 위한 배열

                bool valid = true; // 현재 위치에서 경사로를 설치할 수 있는지 여부

                for (int j = 0; j < N - 1; j++)
                {
                    // 높이 차이가 1 이상인 경우
                    if (Math.Abs(map[i, j] - map[i, j + 1]) > 1)
                    {
                        valid = false;
                        break;
                    }
                    // 높이가 1 높아지는 경우
                    else if (map[i, j] < map[i, j + 1])
                    {
                        // 경사로를 설치할 수 있는지 확인
                        for (int k = j; k > j - L; k--)
                        {
                            // 범위를 벗어나거나 이미 경사로가 설치된 경우
                            if (k < 0 || visited[k] || map[i, k] != map[i, j])
                            {
                                valid = false;
                                break;
                            }
                            visited[k] = true; // 경사로 설치 표시
                        }
                    }
                    // 높이가 1 낮아지는 경우
                    else if (map[i, j] > map[i, j + 1])
                    {
                        // 경사로를 설치할 수 있는지 확인
                        for (int k = j + 1; k <= j + L; k++)
                        {
                            // 범위를 벗어나거나 이미 경사로가 설치된 경우
                            if (k >= N || visited[k] || map[i, k] != map[i, j + 1])
                            {
                                valid = false;
                                break;
                            }
                            visited[k] = true; // 경사로 설치 표시
                        }
                    }
                }

                if (valid)
                    count++;
            }

            // 세로 방향 탐색
            for (int j = 0; j < N; j++)
            {
                bool[] visited = new bool[N]; // 이미 경사로가 설치된 위치인지를 표시하기 위한 배열

                bool valid = true; // 현재 위치에서 경사로를 설치할 수 있는지 여부

                for (int i = 0; i < N - 1; i++)
                {
                    // 높이 차이가 1 이상인 경우
                    if (Math.Abs(map[i, j] - map[i + 1, j]) > 1)
                    {
                        valid = false;
                        break;
                    }
                    // 높이가 1 높아지는 경우
                    else if (map[i, j] < map[i + 1, j])
                    {
                        // 경사로를 설치할 수 있는지 확인
                        for (int k = i; k > i - L; k--)
                        {
                            // 범위를 벗어나거나 이미 경사로가 설치된 경우
                            if (k < 0 || visited[k] || map[k, j] != map[i, j])
                            {
                                valid = false;
                                break;
                            }
                            visited[k] = true; // 경사로 설치 표시
                        }
                    }
                    // 높이가 1 낮아지는 경우
                    else if (map[i, j] > map[i + 1, j])
                    {
                        // 경사로를 설치할 수 있는지 확인
                        for (int k = i + 1; k <= i + L; k++)
                        {
                            // 범위를 벗어나거나 이미 경사로가 설치된 경우
                            if (k >= N || visited[k] || map[k, j] != map[i + 1, j])
                            {
                                valid = false;
                                break;
                            }
                            visited[k] = true; // 경사로 설치 표시
                        }
                    }
                }

                if (valid)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}