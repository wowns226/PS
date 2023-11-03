using System.Text;

namespace BOJ_13752
{ 
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                int k = int.Parse(Console.ReadLine());

                for (int i = 0; i < k; i++) sb.Append("=");

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
