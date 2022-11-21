using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/25965

namespace BOJ
{
    internal class Program
    {
        static long MissionCost(long _killCost, long _deathCost, long _assistCost, long _killCount, long _deathCount, long _assistCount)
        {
            return (_killCost * _killCount) - (_deathCost * _deathCount) + (_assistCost * _assistCount);
        }

        static void Main()
        {
            long gameCount = 0;
            long missionCount = 0;
            long killCount, deathCount, assistCount;           
            string[] inputs;
            Queue<string[]> missionCostQueue = new Queue<string[]>();

            StringBuilder sb = new StringBuilder();

            gameCount = long.Parse(Console.ReadLine());

            while(gameCount-- > 0)
            {
                missionCount = long.Parse(Console.ReadLine());
                long totalCost = 0;
                long killCost = 0;
                long deathCost = 0;
                long assistCost = 0;

                while(missionCount-- > 0)
                {
                    inputs = ReadLine().Split(' ');

                    missionCostQueue.Enqueue(inputs);
                }

                inputs = ReadLine().Split(' ');

                killCount = long.Parse(inputs[0]);
                deathCount = long.Parse(inputs[1]);
                assistCount = long.Parse(inputs[2]);

                while(missionCostQueue.Count > 0)
                {
                    inputs = missionCostQueue.Dequeue();
                        
                    killCost = long.Parse(inputs[0]);
                    deathCost = long.Parse(inputs[1]);
                    assistCost = long.Parse(inputs[2]);

                    long missionCost = MissionCost(killCost, deathCost, assistCost, killCount, deathCount, assistCount);

                    if(missionCost < 0)
                    {
                        continue;
                    }

                    totalCost += missionCost;
                }

                sb.AppendLine(totalCost.ToString());
            }

            Write(sb.ToString());
        }
    }
}