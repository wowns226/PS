using System.Text;

namespace BOJ
{

    class No_14888
    {
        static int n;
        static int myMax = int.MinValue;
        static int myMin = int.MaxValue;
        static int[] nums, oper;

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            oper = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            DFS(1, nums[0]);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(myMax.ToString());
            sb.AppendLine(myMin.ToString());
            Console.Write(sb);
        }

        static void DFS(int idx, int num)
        {
            if(idx == n)
            {
                if (num > myMax) myMax = num;
                if (num < myMin) myMin = num;
                return;
            }

            for(int i=0 ;i<4 ;i++)
            {
                if(oper[i] > 0)
                {
                    oper[i]--;
                    if(i == 0) DFS(idx + 1, num + nums[idx]);
                    else if(i == 1) DFS(idx + 1, num - nums[idx]);
                    else if(i == 2) DFS(idx + 1, num * nums[idx]);
                    else DFS(idx + 1, num / nums[idx]);
                    oper[i]++;
                }
            }
        }
    }
}


