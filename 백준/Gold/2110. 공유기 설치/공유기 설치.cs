namespace BOJ
{
    class No_2110
    {
        // 공유기를 설치할 수 있는지 판단
        static bool CanInstallRouters(int[] houses, int C, int minDistance)
        {
            int count = 1;
            int prevHouse = houses[0];

            for(int i = 1 ; i < houses.Length ; i++)
            {
                if(houses[i] - prevHouse >= minDistance)
                {
                    count++;
                    prevHouse = houses[i];
                }
            }

            return count >= C;
        }

        // 최대 거리 찾기
        static int FindMaxRouterDistance(int[] houses, int C)
        {
            Array.Sort(houses);
            int left = 1;
            int right = houses[houses.Length - 1] - houses[0];
            int result = 0;

            while(left <= right)
            {
                int mid = (left + right) / 2;

                if(CanInstallRouters(houses, C, mid))
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int C = int.Parse(input[1]);

            int[] houses = new int[N];
            for(int i = 0 ; i < N ; i++)
                houses[i] = int.Parse(Console.ReadLine());
            

            int answer = FindMaxRouterDistance(houses, C);
            Console.WriteLine(answer);
        }
    }
}