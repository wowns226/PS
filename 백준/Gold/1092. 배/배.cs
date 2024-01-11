namespace BOJ
{
    class No_1092
    {
        static void Main()
        {
            int craneCount = InputToInt(); // 최대 50
            List<int> craneList = InputToList(); // 크레인 리스트
            int boxCount = InputToInt(); // 최대 10,000
            List<int> boxList = InputToList(); // 박스 리스트
            
            craneList.Sort(Comparer<int>.Create((x, y) => y - x));
            boxList.Sort(Comparer<int>.Create((x, y) => y - x));

            if (boxList.First() > craneList.First())
            {
                Console.WriteLine("-1");
                return;
            }

            int answer = CalculateRounds(craneList, boxList);
            Console.WriteLine(answer);
        }
        
        static int CalculateRounds(List<int> craneList, List<int> boxList)
        {
            int rounds = 0;

            while (boxList.Count > 0)
            {
                rounds++;

                for (int craneIndex = 0; craneIndex < craneList.Count; craneIndex++)
                {
                    int boxIndex = FindHeaviestBox(craneList[craneIndex], boxList);

                    if (boxIndex != -1)
                    {
                        boxList.RemoveAt(boxIndex);
                    }
                }
            }

            return rounds;
        }

        static int FindHeaviestBox(int craneCapacity, List<int> boxList)
        {
            for (int i = 0; i < boxList.Count; i++)
            {
                if (craneCapacity >= boxList[i])
                {
                    return i;
                }
            }

            return -1;
        }
        
        static int InputToInt() => int.Parse(Console.ReadLine());
        static List<int> InputToList() => Array.ConvertAll(Console.ReadLine().Split(), int.Parse).ToList();
    }
}