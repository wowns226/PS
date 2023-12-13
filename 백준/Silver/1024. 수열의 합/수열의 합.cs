using System.Text;

namespace BOJ_16918
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            StringBuilder sb = new StringBuilder();
            int[] inputs = sr.ReadLine().Split().Select(int.Parse).ToArray();
            int N = inputs[0];
            int L = inputs[1];

            while (true)
            {
                int G = N - ((L - 1) * L) / 2;

                var Gx = G / L;
                var Rx = G % L;
                
                if (Gx < 0 || L > 100)
                {
                    sb.Append("-1");
                    break;
                }
                
                if (Rx != 0)
                {
                    L++;
                }
                else
                {
                    for (int i = (int)Gx; i < (int)Gx + L; i++)
                    {
                        sb.Append($"{i} ");
                    }

                    break;
                }
               
            }
            
            sw.Write(sb);
        }
    }
}

