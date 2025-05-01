using System;
using System.IO;
using System.Text;

public class No_24040
{
    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int t = int.Parse(sr.ReadLine());

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < t; i++)
        {
            var n = long.Parse(sr.ReadLine());

            if (n % 9 == 0) sb.AppendLine("TAK");
            else if (n % 3 == 2) sb.AppendLine("TAK");
            else sb.AppendLine("NIE");
        }

        sw.WriteLine(sb.ToString());
    }
}