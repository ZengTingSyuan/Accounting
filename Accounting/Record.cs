using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public class Record
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }      // 收入 或 支出
        public string Category { get; set; }  // 食物、交通...
        public decimal Amount { get; set; }
        public string Note { get; set; }
    }

}
