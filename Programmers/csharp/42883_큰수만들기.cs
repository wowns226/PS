using System.Text;

namespace Programmers
{
    class No_42883
    {
        static void Main()
        {
            TestCase("1924", 2, "94");
            TestCase("1231234", 3, "3234");
            TestCase("4177252841", 4, "775841");
        }

        static void TestCase(string number, int k, string answer)
        {
            var testCaseValue = Solution(number, k);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static string Solution(string number, int k)
        {
            string answer = "";
            StringBuilder sb = new StringBuilder();

            int n = number.Length - k;

            //자리수 만큼 반복 
            for(int i = 0, idx = -1 ; i < n ; i++)
            {
                char max = '0';
                // idx 다음 인덱스부터 k+i와 작거나 같을 때 까지 반복한다. 
                for(int j = idx + 1 ; j <= k + i ; j++)
                {
                    //비교해서 max값 넣어주기
                    if(max < number[j])
                    {
                        max = number[j];
                        idx = j;
                    }
                }
                sb.Append(max); //StringBuilder에 추가한다.
            }

            answer = sb.ToString();

            return answer;
        }
    }
}