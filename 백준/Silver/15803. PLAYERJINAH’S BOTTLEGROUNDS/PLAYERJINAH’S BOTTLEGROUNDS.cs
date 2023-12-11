namespace BOJ_15803
{
    class Program
    {
        static void Main()
        {
            List<(int, int)> list = new List<(int, int)>();
            
            for (int i = 0; i < 3; i++)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                list.Add((inputs[0], inputs[1]));
            }

            list.Sort();

            int dx1 = list[2].Item1 - list[1].Item1;
            int dy1 = list[2].Item2 - list[1].Item2;

            int dx2 = list[1].Item1 - list[0].Item1;
            int dy2 = list[1].Item2 - list[0].Item2;

            if (dy1 * dx2 == dy2 * dx1)
            {
                Console.WriteLine("WHERE IS MY CHICKEN?");
            }
            else
            {
                Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
            }
        }
    }
}
