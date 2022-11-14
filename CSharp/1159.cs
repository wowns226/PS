using System;
using System.Text;

// https://www.acmicpc.net/problem/1159

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int[] playerFirstName = new int[26];
            int playerNum = int.Parse(Console.ReadLine());
            char firstName;

            for (int i = 0; i < playerNum; i++)
            {
                string s = Console.ReadLine();

                firstName = s[0];
                int temp = (int)firstName - (int)'a';
                playerFirstName[temp]++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (playerFirstName[i] >= 5)
                {
                    firstName = (char)('a' + i);
                    sb.Append(firstName);
                }
            }

            if (sb.Equals(""))
            {
                sb.Append("PREDAJA");
            }

            Console.WriteLine(sb);
        }
    }
}