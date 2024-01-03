using System.Text;

namespace BOJ
{
    class No_10170
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NFC West       W   L  T");
            sb.AppendLine("-----------------------");
            sb.AppendLine("Seattle        13  3  0");
            sb.AppendLine("San Francisco  12  4  0");
            sb.AppendLine("Arizona        10  6  0");
            sb.AppendLine("St. Louis      7   9  0");
            sb.AppendLine();
            sb.AppendLine("NFC North      W   L  T");
            sb.AppendLine("-----------------------");
            sb.AppendLine("Green Bay      8   7  1");
            sb.AppendLine("Chicago        8   8  0");
            sb.AppendLine("Detroit        7   9  0");
            sb.AppendLine("Minnesota      5  10  1");

            Console.WriteLine(sb);
        }
    }
}