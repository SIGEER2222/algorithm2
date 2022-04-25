using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.奇怪的东西 {
    internal class String池 {
        void Test() {
            int[] a1 = { };
            int[] a2 = new int[] { };
            int[] a3 = new int[5] { 0, 1, 1, 1, 1, };
            int[] a4 = new int[] { 0, 1, 1, 1, 1, };
            string s3 = "1";
            string s1 = "1";
            object s2 = "1";
            StringBuilder a = new StringBuilder("1");
            string s7 = a.ToString(); ;
            string s4 = "11";
            string s5 = s1 + s2;
            string s6 = "1" + "1";
            string s8 = new string("1");
            Console.WriteLine(object.ReferenceEquals(s1, s2));
            Console.WriteLine(object.ReferenceEquals(s1, s3));
            Console.WriteLine(object.ReferenceEquals(s4, s5));
            Console.WriteLine(object.ReferenceEquals(s4, s6));
            Console.WriteLine(object.ReferenceEquals(s1, s7));
            Console.WriteLine(object.ReferenceEquals(s1, s8));
        }
    }
}
