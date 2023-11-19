using System.Text;

namespace BOJ_5073
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            HashSet<int> hashSet = new HashSet<int>();

            while (true)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                
                Array.Sort(inputs);

                hashSet.Clear();
                foreach (int input in inputs)
                {
                    hashSet.Add(input);
                }
                
                if (inputs.All(x => x == 0))
                {
                    break;
                }

                switch (hashSet.Count)
                {
                    case 1:
                        sb.AppendLine("Equilateral");

                        break;
                    case 2:
                        sb.AppendLine(IsTriangle(inputs[0], inputs[1], inputs[2]) ? "Isosceles" : "Invalid");

                        break;
                    case 3:
                        sb.AppendLine(IsTriangle(inputs[0], inputs[1], inputs[2]) ? "Scalene" : "Invalid");

                        break;
                }
            }

            Console.Write(sb);
        }

        static bool IsTriangle(int a, int b, int c) => a + b > c;
    }
}
