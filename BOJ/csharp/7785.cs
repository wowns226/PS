namespace BOJ
{
    class No_7785
    {
        static void Main()
        {
            using StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            using StreamWriter output = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(input.ReadLine());

            HashSet<string> hashSet = new HashSet<string>();

            while(n-->0)
            {
                string[] inputs = input.ReadLine().Split();

                if(inputs[1].Equals("enter"))
                    hashSet.Add(inputs[0]);
                else
                    hashSet.Remove(inputs[0]);
            }

            var list = hashSet.OrderByDescending(x => x).ToList();

            foreach(var i in list)
                output.WriteLine(i);
        }
    }
}