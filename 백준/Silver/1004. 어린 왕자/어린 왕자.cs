using System.Text;

namespace BOJ_1004
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            
            int testCase = int.Parse(Console.ReadLine());
            int[] inputs;
            int planetCount, r, count;
            (int, int) start, end, circle;

            while (testCase-- > 0)
            {
                count = 0;
                inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                start = (inputs[0], inputs[1]);
                end = (inputs[2], inputs[3]);

                planetCount = int.Parse(Console.ReadLine());

                for (int i = 0; i < planetCount; i++)
                {
                    inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    circle = (inputs[0], inputs[1]);
                    r = inputs[2];
                    
                    // 원 중심에서 start까지의 거리가
                    // r보다 큰 경우 start는 해당 원 밖에 있다.
                    // r보다 작은 경우 start는 해당 원 안에 있다.
                    bool isStart = IsSmallThanR(start, circle, r);
                    // end도 마찬가지
                    bool isEnd = IsSmallThanR(end, circle, r);

                    // start, end 밖에 있는 경우
                    
                    // start, end 둘다 안에 있는 경우
                    
                    // start, end 하나만 안에 있는 경우
                    if((isStart && !isEnd) || (!isStart && isEnd))
                    {
                        count++;
                    }
                }

                sb.AppendLine(count.ToString());
            }

            Console.Write(sb);
        }

        static bool IsSmallThanR((int,int) point, (int,int) circlePoint, int r)
        {
            int a = point.Item1 - circlePoint.Item1;
            int b = point.Item2 - circlePoint.Item2;

            return a * a + b * b < r * r;
        }
    }
}
