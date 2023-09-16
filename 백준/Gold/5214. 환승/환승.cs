using System.Linq;

namespace BOJ
{
    class No_5214
    {
        const int MAX = 100001;
        static int N, K, M;
        static int[] Cost = new int[MAX + 1000];
        static List<int>[] Station = new List<int>[MAX + 1000];

        static void Input()
        {
            string[] input = Console.ReadLine().Split();
            N = int.Parse(input[0]);
            K = int.Parse(input[1]);
            M = int.Parse(input[2]);

            for(int i=1 ;i<(MAX + 1000) ; i++)
                Station[i] = new List<int>();

            for(int i = 1 ; i <= M ; i++)
            {
                input = Console.ReadLine().Split();
                for(int j = 0 ; j < K ; j++)
                {
                    int a = int.Parse(input[j]);
                    Station[a].Add(i + N);
                    Station[i + N].Add(a);
                }
            }
        }

        static int BFS()
        {
            Queue<int> Q = new Queue<int>();
            Q.Enqueue(1);
            Cost[1] = 1;

            while(Q.Count > 0)
            {
                int Cur = Q.Dequeue();

                if(Cur == N) return Cost[Cur];

                foreach(int Next in Station[Cur])
                {
                    if(Cost[Next] == 0)
                    {
                        if(Next > N) Cost[Next] = Cost[Cur];
                        else Cost[Next] = Cost[Cur] + 1;
                        Q.Enqueue(Next);
                    }
                }
            }
            return -1;
        }

        static void Solution()
        {
            int Answer = BFS();
            Console.WriteLine(Answer);
        }

        static void Main(string[] args)
        {
            Input();
            Solution();
        }
    }
}


