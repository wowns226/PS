using System.Text;

namespace BOJ
{
    class No_21921
    {        
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = inputs[0];
            int X = inputs[1];

            var arr = new int[250_001];
            
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            
            int sum = 0;
            for (int i = 0; i < X; i++)
            {
                sum += arr[i];
            }
            
            int answer = sum;
            int count = 1;
            for (int i = X; i < N; i++)
            {
                sum += arr[i] - arr[i - X];

                if (answer == sum)
                    count++;
                else if (answer < sum)
                {
                    answer = sum;
                    count = 1;
                }
            }

            if (answer == 0)
            {
                sb.AppendLine("SAD");
            }
            else
            {
                sb.AppendLine($"{answer}");
                sb.AppendLine($"{count}");    
            }
            
            Console.Write(sb);
        }
    }   
}