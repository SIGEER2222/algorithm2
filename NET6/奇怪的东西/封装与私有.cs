using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.奇怪的东西 {
    internal class 封装与私有 {

    }
   public class Private {
        private string field = "这是一个私有变量";
        private void Method() {
            Console.WriteLine("调用私有方法");
        }

    }
    public class AccessTest {
        Private privateobj = new Private();
        
    }
}
