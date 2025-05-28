using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public class User
    {
        public string Username { get; set; }
        
        public override string ToString()
        {
            return Username; // 讓 ComboBox 顯示名字
        }
    }
}
