using System;
using System.Text;

// 링크 : https://www.acmicpc.net/problem/1212

namespace BOJ
{
    internal class Program
    {
        static string EightToTwo(string _s)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0 ; i < _s.Length ; i++)
            {
                if(i == 0)
                {
                    switch(_s[i])
                    {
                        case '0':
                            sb.Append("0");
                            break;
                        case '1':
                            sb.Append("1");
                            break;
                        case '2':
                            sb.Append("10");
                            break;
                        case '3':
                            sb.Append("11");
                            break;
                        case '4':
                            sb.Append("100");
                            break;
                        case '5':
                            sb.Append("101");
                            break;
                        case '6':
                            sb.Append("110");
                            break;
                        case '7':
                            sb.Append("111");
                            break;
                    }
                }
                else
                {
                    switch(_s[i])
                    {
                        case '0':
                            sb.Append("000");
                            break;
                        case '1':
                            sb.Append("001");
                            break;
                        case '2':
                            sb.Append("010");
                            break;
                        case '3':
                            sb.Append("011");
                            break;
                        case '4':
                            sb.Append("100");
                            break;
                        case '5':
                            sb.Append("101");
                            break;
                        case '6':
                            sb.Append("110");
                            break;
                        case '7':
                            sb.Append("111");
                            break;
                    }
                }              
            }

            return sb.ToString();
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string num = Console.ReadLine();

            string s = EightToTwo(num);

            Console.WriteLine(s);
        }
    }
}