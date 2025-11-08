using System;
using System.IO;

public class BOJ
{
    // https://www.acmicpc.net/problem/2529

    static readonly int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    static readonly bool[] used = new bool[nums.Length];

    static int K;
    static string[] ops;
    static char[] selected;
    static string maxAns = "";
    static string minAns = "";
    static bool IsValid(int a, int b, string op) => op == "<" ? a < b : a > b;

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int k = int.Parse(sr.ReadLine());
        string s = sr.ReadLine();

        K = k;
        ops = s.Split();
        selected = new char[K + 1];

        Dfs(0);

        sw.WriteLine(maxAns);
        sw.WriteLine(minAns);
    }

    static void Dfs(int depth)
    {
        if (depth == K + 1)
        {
            string number = new string(selected, 0, K + 1);
            if (maxAns == "" || string.CompareOrdinal(number, maxAns) > 0) maxAns = number;
            if (minAns == "" || string.CompareOrdinal(number, minAns) < 0) minAns = number;
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i]) continue;

            if (depth == 0 || IsValid(selected[depth - 1] - '0', i, ops[depth - 1]))
            {
                used[i] = true;
                selected[depth] = (char)('0' + i);
                Dfs(depth + 1);
                used[i] = false;
            }
        }
    }
}