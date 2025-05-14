using System;
using System.IO;
using System.Linq;
using System.Text;

public class No_20546
{
    const string A = "BNP";
    const string B = "TIMING";
    const string C = "SAMESAME";

    public static void Main()
    {
        using var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        using var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int m = int.Parse(sr.ReadLine());
        int[] arr = sr.ReadLine().Split().Select(int.Parse).ToArray();

        int a = BNP(m, arr);
        int b = TIMING(m, arr);

        if (a > b) sw.WriteLine(A);
        else if (a < b) sw.WriteLine(B);
        else sw.WriteLine(C);
    }

    static int BNP(int curMoney, int[] stockPrices)
    {
        int stockCount = 0;
        for (int i = 0; i < stockPrices.Length; i++)
        {
            int stockPrice = stockPrices[i];
            if (stockPrice <= curMoney)
            {
                int buyStockCount = curMoney / stockPrice;
                if(buyStockCount > 0)
                {
                    curMoney %= stockPrice;
                    stockCount += buyStockCount;
                }
            }
        }

        return curMoney + stockCount * stockPrices[^1];
    }

    static int TIMING(int curMoney, int[] stockPrices)
    {
        int stockCount = 0;
        int up = 0, down = 0;
        for (int i = 1; i < stockPrices.Length; i++)
        {
            int beforeStockPrice = stockPrices[i - 1];
            int stockPrice = stockPrices[i];
            if (beforeStockPrice < stockPrice)
            {
                down = 0;
                if (++up >= 3)
                {
                    if(stockCount > 0)
                    {
                        curMoney += stockCount * stockPrice;
                        stockCount = 0;
                    }
                }
            }
            else if (beforeStockPrice > stockPrice)
            {
                up = 0;
                if (++down >= 3)
                {
                    int buyStockCount = curMoney / stockPrice;
                    if(buyStockCount > 0)
                    {
                        curMoney %= stockPrice;
                        stockCount += buyStockCount;
                    }
                }
            }
            else
            {
                up = down = 0;
            }
        }

        return curMoney + stockCount * stockPrices[stockPrices.Length - 1];
    }
}