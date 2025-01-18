class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var thresholds = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int MP = thresholds[0], MF = thresholds[1], MS = thresholds[2], MV = thresholds[3];

        var foods = new List<(int p, int f, int s, int v, int c)>();
        for (int i = 0; i < N; i++)
        {
            var food = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foods.Add((food[0], food[1], food[2], food[3], food[4]));
        }

        int minCost = int.MaxValue;
        List<int> bestCombination = null;

        for (int mask = 1; mask < (1 << N); mask++)
        {
            int totalProtein = 0, totalFat = 0, totalCarb = 0, totalVitamin = 0, totalCost = 0;
            var currentCombination = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if ((mask & (1 << i)) > 0)
                {
                    totalProtein += foods[i].p;
                    totalFat += foods[i].f;
                    totalCarb += foods[i].s;
                    totalVitamin += foods[i].v;
                    totalCost += foods[i].c;
                    currentCombination.Add(i + 1);
                }
            }

            if (totalProtein >= MP && totalFat >= MF && totalCarb >= MS && totalVitamin >= MV)
            {
                if (totalCost < minCost || (totalCost == minCost && IsSmaller(currentCombination, bestCombination)))
                {
                    minCost = totalCost;
                    bestCombination = currentCombination;
                }
            }
        }

        if (minCost == int.MaxValue)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(minCost);
            Console.WriteLine(string.Join(" ", bestCombination));
        }
    }

    static bool IsSmaller(List<int> current, List<int> best)
    {
        if (best == null) return true;
        for (int i = 0; i < Math.Min(current.Count, best.Count); i++)
        {
            if (current[i] < best[i]) return true;
            if (current[i] > best[i]) return false;
        }
        return current.Count < best.Count;
    }
}
