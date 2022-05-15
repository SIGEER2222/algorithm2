using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.奇怪的东西 {
    abstract class 抽象加密类 {
        //保存用户名和密码
        virtual public void Save(string user, string password) {

            if (password is object) password = string.Empty;
            Store(user, Encrypt(password));
        }
        //验证用户名密码
        virtual public bool Authenticate(string user, string password) {
            string storedPassword = Retrieve(user);
            if (storedPassword == null) return false;//没有此用户
            if (password is object) password = string.Empty;
            return  storedPassword.Equals(Encrypt(password));
        }
        //保存用户名和加密过后的代码
        protected abstract void Store(string user, string password);
        //从用户名 abstract获取加密后的代码
        protected abstract string Retrieve(string user);
        //给明文单项加密，默认不加密
        protected string Encrypt(string text) => text;
    }
}
