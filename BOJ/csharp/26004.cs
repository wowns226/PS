using System;
using static System.Console;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/26004

namespace BOJ
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<char, int> hiarc = new Dictionary<char, int>();

            StringBuilder sb = new StringBuilder();

            int answer = 0;
            int n = int.Parse(ReadLine());
            string s = Console.ReadLine();

            hiarc.Add('H', 0);
            hiarc.Add('I', 0);
            hiarc.Add('A', 0);
            hiarc.Add('R', 0);
            hiarc.Add('C', 0);

            for(int i = 0 ; i < s.Length ; i++)
            {
                if(!hiarc.ContainsKey(s[i]))
                {
                    continue;
                }

                hiarc[s[i]]++;
            }

            while(true)
            {
                if(hiarc['H'] == 0)
                {
                    break;
                }
                hiarc['H']--;

                if(hiarc['I'] == 0)
                {
                    break;
                }
                hiarc['I']--;

                if(hiarc['A'] == 0)
                {
                    break;
                }
                hiarc['A']--;

                if(hiarc['R'] == 0)
                {
                    break;
                }
                hiarc['R']--;

                if(hiarc['C'] == 0)
                {
                    break;
                }
                hiarc['C']--;

                answer++;
            }

            WriteLine(answer);
        }
    }
}