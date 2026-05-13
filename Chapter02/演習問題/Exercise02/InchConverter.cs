using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    public class InchConverter {

        private static readonly double ratio = 0.0254;   //定数

        public static double ToMeter(double inch) {
            return inch * ratio;
        }
    }
}
