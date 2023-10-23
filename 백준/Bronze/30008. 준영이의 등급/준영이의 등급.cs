using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOJ_30008
{
    class Program
    {

        static void Main()
        {
            int[] grades = { 4, 11, 23, 40, 60, 77, 89, 96, 100 };

            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = inputs[0];
            int k = inputs[1];

            
            inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for(int i=0 ;i<k ; i++)
            {
                int g = inputs[i];

                int temp = (g * 100) / n;
                for(int j=0 ;j<grades.Length ;j++)
                {
                    if(temp - grades[j] <= 0)
                    {
                        Console.Write($"{j+1} ");
                        break;
                    }
                }
            }
        }
    }
}
