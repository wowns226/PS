namespace cs
{
    class MainApp
    {
        static void Main()
        {            
            Console.WriteLine(TestCase(5, new int[] { 2, 4 }, new int[] { 1, 3, 5 }, 5));
            Console.WriteLine(TestCase(5, new int[] { 2, 4 }, new int[] { 3 }, 4));
            Console.WriteLine(TestCase(3, new int[] { 3 }, new int[] { 1 }, 2));
        }

        static string TestCase(int n, int[] lost, int[] reserve, int returnValue)
        {
            if(Solution(n, lost, reserve) == returnValue)
                return "성공";

            return "실패";
        }

        static int Solution(int n, int[] lost, int[] reserve)
        {
            // 전체학생에서 체육복 없는 학생 빼기
            int answer = n;

            // 전체 학생이 체육복을 하나씩 가지고 있음
            int[] students = new int[n];
            Array.Fill(students, 1);

            // 체육복을 잃어버린 학생
            for(int i = 0 ; i < lost.Length ; i++)
                students[lost[i] - 1]--;

            // 여벌의 체육복을 챙긴 학생
            for(int i = 0 ; i < reserve.Length ; i++)
                students[reserve[i] - 1]++;

            // 전체 학생 탐색
            for(int i=0 ;i<students.Length ;i++)
            {
                // 체육복을 잃어버린 학생이라면
                if(students[i] == 0)
                {
                    // 앞의 학생에게 빌려보기
                    // 앞의 학생의 인덱스가 0 이상이여야 하고
                    // 앞의 학생의 체육복 개수가 2이상이여야함
                    if(i-1 >= 0 && students[i-1] > 1)
                    {
                        // 앞의 학생 체육복 빌리기
                        students[i - 1]--;
                        students[i]++;
                    }
                    // 뒤의 학생에게 빌려보기
                    // 뒤의 학생의 인덱스가 students.Length보다 작아야하고
                    // 뒤의 학생의 체육복 개수가 2이상이여야함
                    else if(i+1<students.Length && students[i+1] > 1)
                    {
                        // 뒤의 학생 체육복 빌리기
                        students[i + 1]--;
                        students[i]++;
                    }

                    // 앞, 뒤의 학생들에게 빌릴 수 없다면
                    else
                        answer--;
                }
            }
            return answer;
        }
    }
}