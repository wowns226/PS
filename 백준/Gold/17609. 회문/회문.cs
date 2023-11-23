using System.Text;

namespace BOJ_17609
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string s;
            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                s = Console.ReadLine();
                sb.AppendLine(IsPalindrome(s, 0).ToString());
            }

            Console.Write(sb);
        }

        static int IsPalindrome(string s, int count)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    if (count == 0)
                    {
                        int length = right - left;

                        return IsSimilarPalindrome(s, left, length);
                    }
                    else
                    {
                        return 2;
                    }
                }
                
                left++;
                right--;
            }

            return 0;
        }

        static int IsSimilarPalindrome(string s, int left, int length)
        {
            if (IsPalindrome(s.Substring(left + 1, length), 1) == 0 ||
                IsPalindrome(s.Substring(left, length), 1) == 0)
            {
                return 1;
            }

            return 2;
        }
    }
}
