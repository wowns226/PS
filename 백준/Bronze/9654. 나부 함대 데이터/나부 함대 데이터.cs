using System.Text;

namespace BOJ_9654
{
    class Program
    {
        static void Main()
        {
            using StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SHIP NAME      CLASS          DEPLOYMENT IN SERVICE");
            sb.AppendLine("N2 Bomber      Heavy Fighter  Limited    21        ");
            sb.AppendLine("J-Type 327     Light Combat   Unlimited  1         ");
            sb.AppendLine("NX Cruiser     Medium Fighter Limited    18        ");
            sb.AppendLine("N1 Starfighter Medium Fighter Unlimited  25        ");
            sb.AppendLine("Royal Cruiser  Light Combat   Limited    4         ");

            sw.Write(sb);
        }
    }
}
