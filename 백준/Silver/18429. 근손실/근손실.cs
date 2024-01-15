using System.Text;  
  
namespace BOJ  
{  
    static class Input<T>  
    {  
        public static T GetInput() => ConvertStringToType(Console.ReadLine());  
        public static T[] GetInputArray() => Array.ConvertAll(Console.ReadLine().Split(), Input<T>.ConvertStringToType);  
        private static T ConvertStringToType(string input) => (T)Convert.ChangeType(input, typeof(T));  
    }  
      
    class No_18429  
    {  
        static int answer = 0, n, k;  
        static int[] exerciseKits;  
        static bool[] used;  
          
        static void Main()  
        {  
            var inputs = Input<int>.GetInputArray();  
            n = inputs[0];  
            k = inputs[1];  
            exerciseKits = Input<int>.GetInputArray();  
            used = new bool[inputs[0]];  
  
            BackTracking(0, 0,500);  
  
            Console.WriteLine(answer);  
        }  
  
        static void BackTracking(int depth, int count, int curHp)  
        {  
            // 현재 값이 500보다 낮아진 경우  
            if (curHp < 500)  
            {  
                return;  
            }  
              
            if (count == n)  
            {  
                answer++;  
  
                return;  
            }  
              
            // 백트래킹  
            for (int i = 0; i < n; i++)  
            {  
                if (used[i] == false)  
                {  
                    count++;  
                    used[i] = true;  
                    BackTracking(i + 1, count, curHp - k + exerciseKits[i]);  
                    used[i] = false;  
                    count--;  
                }  
            }  
        }  
    }  
}