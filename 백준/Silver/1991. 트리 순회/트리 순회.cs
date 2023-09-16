namespace BOJ
{
    class Node
    {
        public char Left;
        public char Right;

        public Node(char left, char right)
        {
            Left = left;
            Right = right;
        }
    }

    class BinaryTree
    {
        static public void PreOrder(List<Node> list, char root)
        {
            // 근 - 좌 - 우
            if(root == '.') return;

            Console.Write(root);
            PreOrder(list, list[root - 'A'].Left);
            PreOrder(list, list[root - 'A'].Right);
        }

        static public void InOrder(List<Node> list, char root)
        {
            // 좌 - 근 - 우
            if(root == '.') return;

            InOrder(list, list[root - 'A'].Left);
            Console.Write(root);
            InOrder(list, list[root - 'A'].Right);
        }

        static public void PostOrder(List<Node> list, char root)
        {
            // 좌 - 우 - 근
            if(root == '.') return;

            PostOrder(list, list[root - 'A'].Left);
            PostOrder(list, list[root - 'A'].Right);
            Console.Write(root);
        }
    }

    class No_1991
    {
        const int MAX = 26;

        static List<Node> nodes = new List<Node>(MAX);

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0 ; i < 26 ; i++)
            {
                nodes.Add(new Node('.', '.'));
            }

            for(int i = 0 ; i < n ; i++)
            {
                string input = Console.ReadLine();
                char rt = input[0];
                char l = input[2];
                char r = input[4];

                nodes[rt - 'A'] = new Node(l, r);
            }

            BinaryTree.PreOrder(nodes, 'A');
            Console.WriteLine();

            BinaryTree.InOrder(nodes, 'A');
            Console.WriteLine();

            BinaryTree.PostOrder(nodes, 'A');
        }
    }
}


