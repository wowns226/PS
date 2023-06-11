namespace cs
{
    class No_5565
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int totalCost = int.Parse(input.ReadLine());
            int bookCost = 0;
            for(int i=0 ;i<9 ;i++)
            {
                bookCost += int.Parse(input.ReadLine());
            }

            output.Write(totalCost - bookCost);
        }
    }
}