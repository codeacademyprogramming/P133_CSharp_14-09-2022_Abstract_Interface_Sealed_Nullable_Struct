using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed.Models
{
    class Developer : Student
    {
        public string Experiance;
        public string Project;

        public sealed override string ShowInfo()
        {
            return $"{base.ShowInfo()} {Experiance} {Project}";
        }

        public virtual void Test()
        {

        }
    }
}
