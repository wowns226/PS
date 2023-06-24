namespace Programmers
{
    class No_42746
    {
        static void Main()
        {
            TestCase(new int[] {6,10,2 }, "6210");
            TestCase(new int[] { 3, 30, 34, 5, 9 }, "9534330");
        }

        static void TestCase(int[] numbers, string answer)
        {
            var testCaseValue = Solution(numbers);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static string Solution(int[] numbers)
        {
            Array.Sort(numbers, (x, y) =>
            {
                Console.WriteLine("");
                string XY = x.ToString() + y.ToString();
                string YX = y.ToString() + x.ToString();

                foreach(var i in numbers) Console.WriteLine(i);
                return YX.CompareTo(XY);
            });

            

            if (numbers.Where(x => x == 0).Count() == numbers.Length) return "0";
            else return string.Join("", numbers);
        }
    }
}