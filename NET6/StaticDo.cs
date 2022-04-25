﻿using System;
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


    }
}
