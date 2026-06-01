using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        //プロパティ(P114参照)
        public int Year { get; set; }

        public int Month { get; set; }

        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }

        //5.1.2
        public bool Is21Century => 2001 <= Year && Month <= 2100;

        //5.1.3
        
        



    }
}
