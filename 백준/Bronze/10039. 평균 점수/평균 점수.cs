using System;
using System.IO;

public class No_10039
{
    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int answer = 0;

        for (int i = 0; i < 5; i++)
        {
            int score = int.Parse(sr.ReadLine());
            answer += (score < 40 ? 40 : score);
        }

        sw.Write(answer / 5);
    }
}