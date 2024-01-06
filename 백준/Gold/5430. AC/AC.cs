using System.Data;
using System.Text;

namespace BOJ
{
    class No_5430
    {        
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int testCase = InputToInt();

            while (testCase-- > 0)
            {
                bool reverse = false;
                bool flag = true;
                string s = Input();
                int n = InputToInt();
                string temp = Input();
                temp = temp.Substring(1, temp.Length - 2);
                var list = n == 0 ? new List<int>() : Array.ConvertAll(temp.Split(','), int.Parse).ToList();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'R')
                    {
                        reverse = !reverse;
                    }
                    else
                    {
                        if (list.Count == 0)
                        {
                            flag = false;
                            
                            break;
                        }

                        if (reverse == true)
                        {
                            list.RemoveAt(list.Count - 1);
                        }
                        else
                        {
                            list.RemoveAt(0);
                        }
                    }
                }

                if (flag == true)
                {
                    sb.Append('[');
                    if (reverse == true)
                    {
                        for (int i = list.Count-1; i >= 0; i--)
                        {
                            if (i == 0)
                            {
                                sb.Append($"{list[i]}");   
                            }
                            else
                            {
                                sb.Append($"{list[i]},");    
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (i == list.Count - 1)
                            {
                                sb.Append($"{list[i]}");   
                            }
                            else
                            {
                                sb.Append($"{list[i]},");    
                            }
                        }
                    }
                    sb.Append(']');
                    sb.AppendLine();
                }
                else
                {
                    sb.AppendLine("error");
                }
            }

            Console.Write(sb);
        }
        
        static int InputToInt() => int.Parse(Console.ReadLine());
        static string Input() => Console.ReadLine();
    }
}