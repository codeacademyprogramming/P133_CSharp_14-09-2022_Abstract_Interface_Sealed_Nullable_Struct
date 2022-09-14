using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed.Models
{
    class Student : Human
    {
        public string Education;
        public double Grade;

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} {Grade} {Education}";
        }
    }
}
