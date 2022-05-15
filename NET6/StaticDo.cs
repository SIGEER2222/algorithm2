using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6 {
    public static class StaticDo {
        public static void OUT(this object value) => Console.WriteLine(value);

        public static string[] TOArray(this string s) {
            char[] chars = { ' ', ',', '，' };
            return s.Split(chars);
        }
        public static bool IsNull(this object o) => o is null;
        public static int AInt(this string s) => Convert.ToInt32(s);
        public static double ADouble(this string s) => Convert.ToDouble(s);
        public static int[] AIntArray(this string s) =>
            s.Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
        public static void AOut(this object s) => Console.WriteLine(s);


    }
}
