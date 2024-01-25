using System.Text;

namespace BOJ
{
    static class Input<T>
    {
        static public T Get() => ConvertTo(Console.ReadLine());
        static T ConvertTo(string s) => (T)Convert.ChangeType(s, typeof(T));
    }
    
    class DisjointSet
    {
        private int[] parent;
        private int[] rank;
        private int[] friendNum;

        public DisjointSet(int size)
        {
            parent = new int[size + 1];
            rank = new int[size + 1];
            friendNum = new int[size + 1];

            for (int i = 1; i <= size; i++)
            {
                parent[i] = i;
                rank[i] = 0;
                friendNum[i] = 1;
            }
        }

        private int FindParent(int x)
        {
            if (parent[x] != x)
                parent[x] = FindParent(parent[x]);
            return parent[x];
        }

        public void Union(int a, int b)
        {
            int rootA = FindParent(a);
            int rootB = FindParent(b);

            if (rootA == rootB) return;

            if (rank[rootA] < rank[rootB])
            {
                parent[rootA] = rootB;
                friendNum[rootB] += friendNum[rootA];
            }
            else if (rank[rootA] > rank[rootB])
            {
                parent[rootB] = rootA;
                friendNum[rootA] += friendNum[rootB];
            }
            else
            {
                parent[rootA] = rootB;
                rank[rootB]++;
                friendNum[rootB] += friendNum[rootA];
            }
        }

        public int GetFriendNum(int x)
        {
            return friendNum[FindParent(x)];
        }
    }
    
    class No_4195
    {
        static void Main()
        {
            Dictionary<string, int> indexDict = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            int testCase = Input<int>.Get();
            while (testCase-- > 0)
            {
                int friendRelationShipCount = Input<int>.Get();
                DisjointSet disjointSet = new DisjointSet(friendRelationShipCount * 2);
                indexDict.Clear();

                int cnt = 0;
                for (int i = 0; i < friendRelationShipCount; i++)
                {
                    var friendRelationShip = Input<string>.Get().Split();

                    string friendA = friendRelationShip[0];
                    string friendB = friendRelationShip[1];
                    
                    if (!indexDict.ContainsKey(friendA))
                        indexDict[friendA] = ++cnt;

                    if (!indexDict.ContainsKey(friendB))
                        indexDict[friendB] = ++cnt;

                    int a = indexDict[friendA];
                    int b = indexDict[friendB];

                    disjointSet.Union(a, b);

                    sb.AppendLine($"{disjointSet.GetFriendNum(a)}");
                }
            }

            Console.Write(sb);
        }
    }
}