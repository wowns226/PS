using System.Text;

namespace BOJ
{
    class No_1753
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            
            // 다익스트라?
            int[] inputs = InputToIntArray();
            int V = inputs[0];
            int E = inputs[1];
            
            int K = InputToInt();

            // 그래프 초기화
            List<(int, int)>[] graph = new List<(int, int)>[V + 1];
            for (int i = 1; i <= V; i++)
            {
                graph[i] = new List<(int, int)>();
            }

            // 간선 정보 입력
            for (int i = 0; i < E; i++)
            {
                string[] edgeInput = Console.ReadLine().Split();
                int u = int.Parse(edgeInput[0]);
                int v = int.Parse(edgeInput[1]);
                int w = int.Parse(edgeInput[2]);

                graph[u].Add((v, w));
            }

            // 다익스트라 알고리즘 수행
            int[] shortestPaths = Dijkstra(graph, V, K);

            // 결과 출력
            for (int i = 1; i <= V; i++)
            {
                sb.AppendLine(shortestPaths[i] == int.MaxValue ? "INF" : $"{shortestPaths[i]}");
            }

            Console.Write(sb);
        }

        // 다익스트라 알고리즘
        static int[] Dijkstra(List<(int, int)>[] graph, int V, int startVertex)
        {
            int[] shortestPaths = new int[V + 1];
            bool[] visited = new bool[V + 1];

            // 모든 정점의 최단 경로 초기값 설정
            for (int i = 1; i <= V; i++)
            {
                shortestPaths[i] = int.MaxValue;
                visited[i] = false;
            }

            // 시작 정점의 최단 경로는 0으로 설정
            shortestPaths[startVertex] = 0;

            for (int count = 0; count < V - 1; count++)
            {
                int minDistance = MinDistance(shortestPaths, visited, V);

                visited[minDistance] = true;

                foreach (var edge in graph[minDistance])
                {
                    int v = edge.Item1;
                    int w = edge.Item2;

                    if (!visited[v] && shortestPaths[minDistance] != int.MaxValue &&
                        shortestPaths[minDistance] + w < shortestPaths[v])
                    {
                        shortestPaths[v] = shortestPaths[minDistance] + w;
                    }
                }
            }

            return shortestPaths;
        }

        // 최소 거리 정점 찾기
        static int MinDistance(int[] shortestPaths, bool[] visited, int V)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 1; v <= V; v++)
            {
                if (!visited[v] && shortestPaths[v] <= min)
                {
                    min = shortestPaths[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        static int InputToInt() => int.Parse(Console.ReadLine());
        static int[] InputToIntArray() => Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    }
}