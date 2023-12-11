namespace BOJ
{
    class No_15686
    {
        const int MAX_CHOICE_COUNT = 13;
        const int MAX = 987654321;

        static int N, M, answer = MAX;
        static int[,] board;
        static bool[] selected = new bool[MAX_CHOICE_COUNT];
        static List<(int, int)> houses = new List<(int, int)>();
        static List<(int, int)> chickenHouses = new List<(int, int)>();
        static List<(int, int)> list = new List<(int, int)>();

        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            N = inputs[0];
            M = inputs[1];

            board = new int[N, N];
            for(int i=0 ;i<N ;i++)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0 ;j<N ;j++)
                {
                    board[i, j] = inputs[j];

                    if(board[i, j] == 1) houses.Add((i, j));
                    else if(board[i, j] == 2) chickenHouses.Add((i, j));
                }
            }

            ChoiceChickenHouse(0, 0);

            Console.WriteLine(answer);
        }

        static int CalculateDistance()
        {
            int totalDist = 0;

            for(int i=0 ;i<houses.Count ;i++)
            {
                int d = MAX;

                for(int j=0 ;j<list.Count ; j++)
                {
                    int dist = DistanceBetweenHouseAndChicken(houses[i], list[j]);
                    d = Math.Min(d, dist);
                }
                totalDist += d;
            }

            return totalDist;
        }

        static void ChoiceChickenHouse(int idx, int cnt)
        {
            if(cnt == M)
            {
                answer = Math.Min(answer, CalculateDistance());
                return;
            }

            for(int i = idx ;i<chickenHouses.Count ; i++)
            {
                if(selected[i]) continue;
                selected[i] = true;
                list.Add(chickenHouses[i]);
                ChoiceChickenHouse(i, cnt + 1);
                selected[i] = false;
                list.RemoveAt(list.Count - 1);
            }
        }

        static int DistanceBetweenHouseAndChicken((int,int) house, (int,int) chicken)
            => (Math.Abs(house.Item1 - chicken.Item1) + Math.Abs(house.Item2 - chicken.Item2));
    }
}


