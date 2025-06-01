using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public class User
    {
        //User類別自己打的
        public string Username { get; set; }
        
        public override string ToString()
        {
            return Username; // 讓使用者選擇顯示每個使用者的名字
        }
    }
}
