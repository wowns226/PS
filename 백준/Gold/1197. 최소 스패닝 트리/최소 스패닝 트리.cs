namespace BOJ
{
    static class Input<T>
    {
        public static T[] GetArray() => Array.ConvertAll(Console.ReadLine().Split(), ConvertTo);
        private static T ConvertTo(string input) => (T)Convert.ChangeType(input, typeof(T));
    }
    
    class Edge 
    {
        public int u;
        public int v;
        public int weight;

        public Edge(int u, int v, int weight) {
            this.u = u;
            this.v = v;
            this.weight = weight;
        }
    }
    
    class No_1197
    {
        static int[] Parent = new int[10001];
        
        static void Main()
        {
            List<Edge> edges = new List<Edge>();
            long ans = 0;
            var input = Input<int>.GetArray();
            int V = input[0];
            int E = input[1];

            for (int i = 0; i < V; i++)
            {
                Parent[i] = i;
            }

            for (int i = 0; i < E; i++)
            {
                input = Input<int>.GetArray();
                int u = input[0];
                int v = input[1];
                int weight = input[2];
                edges.Add(new Edge(u, v, weight));
            }

            edges.Sort(MyCompare);

            foreach (var edge in edges.Where(edge => !IsSameParent(edge.u, edge.v)))
            {
                Union(edge.u, edge.v);
                ans += edge.weight;
            }

            Console.WriteLine(ans);
        }
        
        static int Find(int x) {
            if (Parent[x] == x)
                return x;
            
            return Parent[x] = Find(Parent[x]);
        }

        static void Union(int x, int y) {
            x = Find(x);
            y = Find(y);
            
            if (x != y) Parent[y] = x;
        }

        static bool IsSameParent(int x, int y) {
            x = Find(x);
            y = Find(y);
            
            return x == y;
        }

        static int MyCompare(Edge a, Edge b) {
            return a.weight.CompareTo(b.weight);
        }
    }
}