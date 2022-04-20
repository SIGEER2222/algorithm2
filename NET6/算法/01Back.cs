using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.算法
{
    internal class _01Back
    {
        int C, D, N;
        int[] w = new int[100];//重量
        int[] b = new int[100];//体积
        int[] v = new int[100];//价值
        int[,,] dp = new int[100, 100, 100];
        void Test()
        {
            GetBack();
            FindMax();
        }
        
        void FindMax()
        {
            for (int i = 1; i < N + 1; i++)
                for (int j = 1; j <= C; j++)
                    for (int k = 1; k <= D; k++)
                    {
                        if (w[i] <= j && b[i] <= k)  //当前物品重量小于当前容量，且体积小于容积时 ，才可以考虑装入物品的问题
                            dp[i, j, k] = dp[i - 1, j, k] > dp[i - 1, j - w[i], k - b[i]] + v[i] ? dp[i - 1, j, k] : dp[i - 1, j - w[i], k - b[i]] + v[i];
                        else dp[i, j, k] = dp[i - 1, j, k];
                    }

            Console.WriteLine("背包最大能装进" + dp[N, C, D] + "元");
        }

        void GetBack()
        {
            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            C = a[0];
            D = a[1];
            N = a[2];
            for (int i = 0; i < N; i++)
            {
                a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                w[i] = a[0];
                b[i] = a[1];
                v[i] = a[2];
            }
        }

        //public struct Back
        //{
        //    public int C;//背包容量
        //    public int D;//背包容积
        //    public int n;//商品数量
        //    public Price[] p;
        //}

        //public struct Price
        //{
        //    public int m;//商品质量
        //    public int v;//商品体积
        //    public int p;//商品价格
        //}


        //void Find(int n, int[,] Rec, int K, int[] V)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (Rec[i, K] == 1)
        //        {
        //            K = K - V[i];
        //        }
        //    }
        //}
    }
}
