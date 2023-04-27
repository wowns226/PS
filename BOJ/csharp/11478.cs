namespace BOJ
{
    class No_11478
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            HashSet<string> hashSet = new HashSet<string>();

            string s = input.ReadLine();


            string tempString;
            for(int i = 0 ; i < s.Length ; i++)
            {
                tempString = "";
                for(int j = i ; j < s.Length ; j++)
                {
                    tempString += s[j];
                    hashSet.Add(tempString);
                }
            }

            output.Write(hashSet.Count);
        }
    }
}