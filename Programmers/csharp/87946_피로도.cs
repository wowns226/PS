namespace Programmers
{
    class No_87946
    {
        static int answer = 0;
        static bool[] visit;

        static void Main()
        {
            TestCase(80, new int[,] { { 80, 20 }, { 50, 40 }, { 30, 10 } }, 3);
        }

        static void TestCase(int k, int[,] dungeons, int answer)
        {
            var testCaseValue = Solution(k, dungeons);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int Solution(int k, int[,] dungeons)
        {
            visit = new bool[dungeons.Length];

            DFS(k, dungeons, visit, 0);

            return answer;
        }

        //재귀를 위한 함수
        static int DFS(int k, int[,] dungeons, bool[] visit, int cnt)
        {
            for(int i = 0 ; i < dungeons.GetLength(0) ; i++)
            {
                if(k >= dungeons[i, 0] && !visit[i]) //현재 피로도가 최소 피로도 보다 많고 방문한적 없는 던전인지 확인
                {
                    visit[i] = true;
                    //현재 피로도를 해당 던전을 다녀왔으니 빼준다
                    //모든 던전을 돌 것이고 
                    //방문던전 수 cnt +1해준다. 
                    DFS(k - dungeons[i, 1], dungeons, visit, cnt + 1);
                    visit[i] = false; //재귀를 빠져나오면 새로운 던전 먼저 방문할것이기 때문에 false 
                }
            }
            answer = Math.Max(cnt, answer);
            return answer;
        }
    }
}