namespace BOJ
{
    class No_28074
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            bool[] arr = new bool[27];

            string s = input.ReadLine();

            for(int i = 0 ; i < s.Length ; i++)
                arr[s[i] - 'A'] = true;

            if(arr['M' - 'A'] && arr['O' - 'A'] && arr['B' - 'A'] && arr['I' - 'A'] && arr['S' - 'A'])
                output.Write("YES");
            else
                output.Write("NO");
        }
    }
}
