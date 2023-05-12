namespace BOJ
{
    class No_11724
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);

            int n = inputs[0];
            int m = inputs[1];

            Queue<int>[] qs = new Queue<int>[n];
            bool[] visited = new bool[n];

            for(int i = 0 ; i < n ; i++)
                qs[i] = new Queue<int>();

            for(int i=0 ;i<m ;i++)
            {
                inputs = Array.ConvertAll(input.ReadLine().Split(), int.Parse);
                int u  = inputs[0]-1;
                int v = inputs[1]-1;

                qs[u].Enqueue(v);
                qs[v].Enqueue(u);
            }

            int answer = 0;
            Queue<int> q = new Queue<int>();
            for(int i=0 ;i<n ;i++)
            {
                if(visited[i]) continue;

                q.Enqueue(i);
                while(q.Count>0)
                {
                    var cur = q.Dequeue();

                    if(visited[cur]) continue;

                    visited[cur] = true;

                    foreach(var item in qs[cur])
                        q.Enqueue(item);
                }
                answer++;
            }

            output.Write(answer);
        }
    }
}
