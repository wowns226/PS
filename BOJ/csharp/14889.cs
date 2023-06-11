namespace cs
{
    class No_14889
    {
        static int n;
        static int[,] arr;
        static bool[] visited;
        static int ans = int.MaxValue;

        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            n = int.Parse(input.ReadLine());
            arr = new int[n, n];
            visited = new bool[n];

            for(int i=0 ;i<n ;i++)
            {
                int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                for(int j=0 ;j<n ; j++)
                {
                    arr[i, j] = inputs[j];
                }
            }

            DFS(0, 1);

            output.Write(ans);
        }

        static void DFS(int depth, int idx)
        {
            if(depth == n / 2)
            {
                int start = 0, link = 0;
                
                for(int i=0 ;i<n ;i++)
                {
                    for(int j=0 ;j<n ;j++)
                    {
                        if(visited[i] == true && visited[j] == true) start += arr[i, j];
                        if(visited[i] == false && visited[j] == false) link += arr[i, j];
                    }
                }

                int temp = Math.Abs(start - link);
                if(ans > temp) ans = temp;

                return;
            }

            for(int i= idx ;i<n ;i++)
            {
                visited[i] = true;
                DFS(depth + 1, i + 1);
                visited[i] = false;
            }
        }
    }
}