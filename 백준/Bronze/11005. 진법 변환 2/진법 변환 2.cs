using System.Text;

namespace BOJ
{
    class No_11005
    {
        static Dictionary<int, string> dict = new Dictionary<int, string>();
        
        static void Main()
        {
            var sb = new StringBuilder();
            
            InitDictionary();
            
            var inputs = InputToIntArray();
            int number = inputs[0];
            int formation = inputs[1];
            
            var answer = ConvertToFormation(number, formation);
            while (answer.Count > 0)
            {
                sb.Append(answer.Pop());
            }

            Console.WriteLine(sb);
        }

        static void InitDictionary()
        {
            for (int i = 0; i < 36; i++)
            {
                dict.TryAdd(i, i < 10 ? i.ToString() : ((char)(i + 55)).ToString());
            }
        }

        static int[] InputToIntArray() => Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        static Stack<string> ConvertToFormation(int number, int formation)
        {
            Stack<string> st = new Stack<string>();

            int temp = number;
            while (temp != 0)
            {
                int g = temp / formation;
                int r = temp % formation;

                st.Push(dict[r]);

                temp = g;
            }
            
            return st;
        }
    }
}