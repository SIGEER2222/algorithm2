using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.算法 {
    internal class QuickSort {
        public IEnumerable<T> qsort1<T>(IEnumerable<T> list) where T : IComparable<T> {
            if (list.Count() <= 1) return list;

            var pivot = list.First();
            return qsort1(list.Where(x => x.CompareTo(pivot) < 0))
                .Concat(list.Where(x => x.CompareTo(pivot) == 0))
                .Concat(qsort1(list.Where(x => x.CompareTo(pivot) > 0)));
        }

        public static void qsort2<T>(T[] list) where T : IComparable<T> {
            qsort2(list, 0, list.Length-1);
        }
        public static void qsort2<T>(T[] list, int low, int high) where T : IComparable<T> {
            if (low >= high) return;
            int i = low - 1; int j = high - 1;
            T pivot = list[low];

            while (true) {
                do { ++i; } while (list[i].CompareTo(pivot) < 0);
                do { --j; } while (list[i].CompareTo(pivot) > 0);
                if (i >= j) break;
                T tmp = list[i]; list[i] = list[j]; list[j] = tmp;
            }
            qsort2(list, low, i);
            qsort2(list, j + 1, high);
        }


    }
}
