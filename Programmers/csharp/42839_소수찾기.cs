namespace Programmers
{
    class No_42839
    {
        static void Main()
        {
            TestCase("17", 3);
            TestCase("011", 2);
        }

        static void TestCase(string numbers, int answer)
        {
            var testCaseValue = Solution(numbers);

            if(testCaseValue == answer)
                Console.WriteLine("성공");
            else
                Console.WriteLine("실패");
        }

        static int Solution(string numbers)
        {
            // 중복을 제거하기 위해 HashSet 자료구조 사용
            HashSet<int> primeNumbers = new HashSet<int>();

            for(int index = 0 ; index < numbers.Length ; ++index)
            {
                // index를 기준으로 가능한 모든 조합을 생성
                string[] tempNum = CombineString(index, numbers);

                for(int tempNumIndex = 0 ; tempNumIndex < tempNum.Length ; ++tempNumIndex)
                {
                    // 정수로 변환
                    int tempPrime = int.Parse(tempNum[tempNumIndex]);
                    // 소수 판단
                    if(isPrime(tempPrime))
                        primeNumbers.Add(tempPrime);
                }
            }

            return primeNumbers.Count;
        }

        static string[] CombineString(int ciphers, string numbers)
        {
            List<string> numberList = new List<string>();

            // numbers를 char 배열로 변환
            List<char> charList = new List<char>(numbers.ToCharArray());

            // 길이가 ciphers + 2인 char 배열 선언
            char[] newString = new char[ciphers + 2];

            // 맨 뒤부터
            for(int charIndex = charList.Count - 1 ; charIndex >= 0 ; --charIndex)
                // 가능한 모든 조합을 생성
                CreateStringNum(ciphers, charIndex, ref numberList, charList, newString);

            return numberList.ToArray();
        }

        static void CreateStringNum(int ciphers, int charIndex, ref List<string> numberList, List<char> charList, char[] newString)
        {
            // newstring을 string으로 만들어서 numberList에 추가
            if(ciphers < 0)
            {
                numberList.Add(new string(newString));
                return;
            }

            if(charIndex < 0)
                return;

            CreateStringNum(ciphers, charIndex - 1, ref numberList, new List<char>(charList), newString);

            // newString의 ciphers 인덱스에 charList의 charIndex 위치의 문자를 할당 후
            newString[ciphers] = charList[charIndex];
            // charList에서 해당 위치의 문자 제거
            charList.RemoveAt(charIndex);

            CreateStringNum(ciphers - 1, charList.Count - 1, ref numberList, new List<char>(charList), newString);
        }

        // 소수 판별
        static bool isPrime(int num)
        {
            if(num == 2)
                return true;

            if(num < 2 || (num & 1) == 0)
                return false;

            for(int div = 3 ; div <= Math.Sqrt(num) ; div += 2)
            {
                if(num % div == 0)
                    return false;
            }

            return true;
        }
    }
}