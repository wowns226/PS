namespace BOJ
{
    class No_2745
    {
        static void Main()
        {
            string[] inputs = Input().Split();
            string number = inputs[0];
            int formation = int.Parse(inputs[1]);
            Console.WriteLine(ConvertToInt(number, formation));
        }
        static string Input() => Console.ReadLine();

        static int ConvertToInt(string number, int formation)
        {
            int index = 0;
            int ret = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int temp = number[i] >= 'A' ? (number[i] - 'A') + 10 : int.Parse(number[i].ToString());
                ret += temp * (int)Math.Pow(formation, index);
                index++;
            }

            return ret;
        }
    }
}