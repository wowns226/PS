using System.Text;

namespace BOJ
{
    class No_4892
    {
        static void Main(string[] args)
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            StringBuilder sb = new StringBuilder();

            int idx = 1;
            while(true)
            {
                int num = int.Parse(input.ReadLine());

                if(num == 0) break;

                sb.Append(Game(idx, num));

                idx++;
            }

            output.Write(sb);
        }

        static string Game(int idx, int num)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{idx}. ");

            // 친구에게 n1 = 3 * n0 계산을 하라고 한 뒤, 
            num *= 3;

            // n1이 짝수인지 홀수인지를 말해달라고 한다.
            // n1이 짝수라면, n2 = n1 / 2를, 홀수라면 n2 = (n1 + 1) / 2를 계산해달라고 한다.
            if(num % 2 == 0)
            {
                sb.Append("even ");
                num /= 2;
            }
            else
            {
                sb.Append("odd ");
                num = (num + 1) / 2;
            }

            // n3 = 3 * n2의 계산을 부탁한다.
            num *= 3;

            // 친구에게 n4 = n3 / 9를 계산한 뒤, 그 값을 말해달라고 한다. (n4는 나눗셈의 몫이다)
            num /= 9;
            sb.Append($"{num}\n");

            return sb.ToString();
        }
    }
}