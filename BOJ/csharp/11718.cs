namespace BOJ
{
    class No_11718
    {
        public static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string answer = "";
            while(true)
            {
                string s = input.ReadLine();

                if(string.IsNullOrEmpty(s))
                    break;

                output.WriteLine(s);
            }
        }
    }
}