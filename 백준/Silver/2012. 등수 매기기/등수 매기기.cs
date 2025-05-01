using System;
using System.IO;

public class No_2012
{
    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(sr.ReadLine());

        int[] students = new int[n];
        for (int i = 0; i < n; i++)
        {
            var input = int.Parse(sr.ReadLine());

            students[i] = input;
        }

        Array.Sort(students);

        long answer = 0;
        for (int i = 0; i < n; i++)
        {
            answer += Math.Abs(students[i] - (i + 1));
        }

        sw.Write(answer);
    }
}