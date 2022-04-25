using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.算法
{
    internal class MaxSubArray
    {
        public static void Test()
        {
            int[] arr = { 1, -2, 4, 8, -4, 7, -1, -5 };
            MaxSubArray1(arr).OUT();

        }

        static int MaxSubArray1(int[] arr)
        {
            int n = arr.Length;
            int[] End = new int[n];
            int[] All = new int[n];
            End[n - 1] = arr[n - 1];
            All[n - 1] = arr[n - 1];
            End[0] = All[0] = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                End[i] = Math.Max(End[i - 1] + arr[i], arr[i]);
                All[i] = Math.Max(End[i], All[i - 1]);
            }
            return All[n - 1];
        }

        static int MaxSubArray2(int[] arr)
        {
            int nAll = arr[0];
            int nEnd = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                nEnd = Math.Max(nEnd + arr[i], arr[i]);
                nAll = Math.Max(nAll, nEnd);
            }
            return nAll;
        }
    }
}
