namespace BOJ
{
    class No_1269
    {
        static void Main()
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var hs1 = Console.ReadLine().Split().Select(int.Parse).ToHashSet();
            var hs2 = Console.ReadLine().Split().Select(int.Parse).ToHashSet();
            int answer = hs1.Count(item => hs2.Contains(item) == false) + hs2.Count(item => hs1.Contains(item) == false);
            Console.WriteLine(answer);
        }
    }
}