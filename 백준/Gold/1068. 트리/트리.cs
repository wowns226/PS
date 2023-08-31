namespace BOJ
{
    class No_1068
    {
        const int MAX = 52;

        static int n, deleteNodeNum, root = -1;
        static int[] nodes = new int[MAX];
        static List<int>[] tree = new List<int>[MAX];

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            nodes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            deleteNodeNum = int.Parse(Console.ReadLine());

            for(int i=0 ;i<n; i++)
                tree[i] = new List<int>();

            for(int i=0 ;i<n ;i++)
            {
                if(nodes[i] == -1) root = i;
                else tree[nodes[i]].Add(i);
            }

            int result = CountLeafNodes(root);

            Console.WriteLine(result);
        }

        static int CountLeafNodes(int parent)
        {
            if(parent == deleteNodeNum)
                return 0;

            int leafCount = 0;
            foreach(int child in tree[parent])
            {
                if(child == deleteNodeNum) continue;
                leafCount += CountLeafNodes(child);
            }

            return leafCount == 0 ? 1 : leafCount;
        }
    }
}