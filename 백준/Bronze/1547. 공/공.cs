using System;
using System.Collections.Generic;
using System.IO;

public class No_1547
{
    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        sw.Write(Solve(sr));
    }

    private static string Solve(StreamReader sr)
    {
        List<int> cupNumbers = new List<int> { 1, 2, 3 };
        int m = int.Parse(sr.ReadLine());

        List<(int, int)> swapList = new List<(int, int)>();
        for (int i = 0; i < m; i++)
        {
            var inputs = sr.ReadLine().Split();
            swapList.Add((int.Parse(inputs[0]), int.Parse(inputs[1])));
        }

        Swap(swapList, cupNumbers);

        return cupNumbers[0].ToString();
    }

    static void Swap(List<(int, int)> swapList, List<int> capNumbers)
    {
        foreach((int before, int after) in swapList)
        {
            int beforeIdx = 0, afterIdx = 0;
            for(int i=0;i<capNumbers.Count;i++)
            {
                if (capNumbers[i] == before) beforeIdx = i;
                else if (capNumbers[i] == after) afterIdx = i;
            }
            capNumbers[beforeIdx] = after;
            capNumbers[afterIdx] = before;
        }
    }
}