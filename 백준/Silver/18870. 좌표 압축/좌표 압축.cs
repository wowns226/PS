namespace BOJ
{
    class No_18870
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var sortedArray = new List<int>(inputs).ToArray();
            Array.Sort(sortedArray);

            var answer = new int[n];
            var dict = new Dictionary<int, int>();

            int index = 0;
            foreach(var value in sortedArray)
                if(!dict.ContainsKey(value))
                    dict[value] = index++;
                
            for(int i = 0 ; i < n ; i++)
                answer[i] = dict[inputs[i]];

            Console.WriteLine(string.Join(" ", answer));
        }
    }
}