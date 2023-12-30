namespace BOJ
{
    class No_1389
    {
        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int m = inputs[1];
            
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < m; i++)
            {
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int a = inputs[0]-1;
                int b = inputs[1]-1;

                MakeFriend(a, b, dict);
            }

            int answer = 0;
            int count = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int cnt = SetFriendDistance(i, n, dict);

                if (count <= cnt) continue;
                
                count = cnt;
                answer = i + 1;
            }

            Console.WriteLine(answer);
        }

        static int SetFriendDistance(int task, int n, Dictionary<int, List<int>> dict)
        {
            int[] array = new int[n];
            // 1. dict[task]가 있다면 해당 값들 ++
            // 3. 2반복

            if (dict.ContainsKey(task) != true) return 0;
            
            foreach (var item in dict[task])
            {
                array[item] = 1;

                // 2. 반복돌면서 하위 있다면 해당 값들 ++
                FindChild(task, item, array, dict, 2);
            }

            // 4. 3번까지 한 기록 리스트의 합을 리턴
            return array.Sum();
        }

        static void FindChild(int parent, int task, int[] array, Dictionary<int, List<int>> dict, int depth)
        {
            foreach (var item in dict[task])
            {
                if (item == parent)
                {
                    continue;
                }
                
                // 2-1. 이미 체크한 값이라면 패스
                if (array[item] != 0)
                {
                    // 2-2. 더 작다면
                    if (array[item] > depth)
                    {
                        array[item] = depth; 
                        FindChild(parent, item, array, dict, depth + 1);
                    }
                    
                    continue;
                }

                array[item] = depth;

                FindChild(parent, item, array, dict, depth + 1);
            }
        }

        static void MakeFriend(int a, int b, Dictionary<int, List<int>> dict)
        {
            dict.TryAdd(a, new List<int>());
            dict.TryAdd(b, new List<int>());

            dict[a].Add(b);
            dict[b].Add(a);
        }
    }   
}