using System;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        sw.Write(Solve(sr));
    }

    private static string Solve(StreamReader sr)
    {
        var inputs = sr.ReadLine().Split().Select(long.Parse).ToArray();
        long totalGames = inputs[0], winGames = inputs[1];

        int currentWinRate = GetWinRate(totalGames, winGames);

        return IsWinRateUnchangeable(currentWinRate) ? "-1" : GetMinimumGamesToIncreaseWinRate(totalGames, winGames, currentWinRate).ToString();
    }

    private static int GetWinRate(long totalGames, long winGames)
        => (int)(winGames * 100 / totalGames);

    private static bool IsWinRateUnchangeable(int winRate)
        => winRate >= 99;

    private static int GetMinimumGamesToIncreaseWinRate(long totalGames, long winGames, int currentWinRate)
    {
        long left = 1, right = totalGames;  // 탐색 범위를 totalGames로 줄임 (너무 큰 값 불필요)
        int newWinRate = currentWinRate;

        while (left <= right)
        {
            long mid = (left + right) / 2;

            // 승률 비교를 나누기 없이 처리
            if ((winGames + mid) * 100 >= (totalGames + mid) * (currentWinRate + 1))
            {
                right = mid - 1;
                newWinRate = GetWinRate(totalGames + mid, winGames + mid);
            }
            else
            {
                left = mid + 1;
            }
        }

        return (int)left;
    }
}