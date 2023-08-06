namespace Programmers
{
    class No_42842
    {
        static void Main()
        {
            TestCase(10, 2, new int[] { 4, 3 });
            TestCase(8, 1, new int[] { 3, 3 });
            TestCase(24, 24, new int[] { 8, 6 });
        }

        static void TestCase(int brown, int yellow, int[] answer)
        {
            var testCaseValue = Solution(brown, yellow);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int[] Solution(int brown, int yellow)
        {
            int[] answer = new int[2];

            //yellow를 기준으로 가로, 세로 길이 변수 초기화
            int width = 0, height = 0;

            //yellow를 기준으로 반복
            for(int i = 1 ; i <= yellow ; i++)
            {
                //i를 높이로 가정했을 때 넓이는 yellow/i 이므로 
                //yellow%i 나머지가 0이면 각각 넓이와 높이 설정
                if(yellow % i == 0)
                {
                    width = yellow / i;
                    height = i;

                    //카펫의 가로길이가 세로길이와 같거나 길면
                    if(height <= width)
                    {
                        //yellow의 가로, 세로 길이에 2를 더하면 brown의 가로세로 길이가 나오고
                        //brown의 가로 세로 길이를 곱하면 brown + yellow의 크기가 된다.
                        if((width + 2) * (height + 2) == brown + yellow)
                        {
                            answer = new int[] { width + 2, height + 2 };
                            return answer;
                        }
                    }
                }
            }
            return answer;
        }
    }
}