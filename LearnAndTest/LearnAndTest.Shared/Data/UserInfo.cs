using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace LearnAndTest.Shared.Data
{
    public class UserInfo
    {
        [DisplayName("自动编号")]
        public int Id { get; set; }
        [DisplayName("名字")]

        public string Name { get; set; }
        [DisplayName("地址")]

        public string Address { get; set; }
        [DisplayName("年龄")]


        public int Age { get; set; }
        [DisplayName("手机号")]
        public string Mobile { get; set; }
    }
}
