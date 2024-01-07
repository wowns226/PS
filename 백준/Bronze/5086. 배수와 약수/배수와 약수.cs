using System.Text;

namespace BOJ
{
    class No_5086
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            
            while (true)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int x = inputs[0];
                int y = inputs[1];

                if (IsExit(x, y))
                {
                    break;
                }
                
                if (IsFactor(x, y))
                {
                    sb.AppendLine("factor");
                } 
                else if (IsMultiple(x, y))
                {
                    sb.AppendLine("multiple");
                }
                else
                {
                    sb.AppendLine("neither");
                }
            }

            Console.Write(sb);
        }

        static bool IsMultiple(int x, int y) => x % y == 0;
    
        static bool IsFactor(int x, int y) => x * (y / x) == y;
    
        static bool IsExit(int x, int y) => x == 0 && y == 0;
    }
}