﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public class Record
    {
        //Record類別是自己打的
        public DateTime 日期 { get; set; }
        public string 分類 { get; set; }      // 收入 支出
        public string 類型 { get; set; }  // 食物、交通等
        public decimal 金額 { get; set; }
        public string 備註 { get; set; }
        public string 使用者 { get; set; } //username
    }

}
