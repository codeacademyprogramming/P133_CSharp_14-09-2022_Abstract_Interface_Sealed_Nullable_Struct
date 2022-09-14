using System;
using System.Collections.Generic;
using System.Text;

namespace Stuct
{
    struct Area
    {
        public int A;
        public int B;

        public int C { get; set; }
        public int CalculateArea()
        {
            return A * B;
        }
    }
}
