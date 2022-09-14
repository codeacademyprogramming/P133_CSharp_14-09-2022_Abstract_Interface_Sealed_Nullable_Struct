using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed.Models
{
    class Human
    {
        public string Name;
        public string SurName;

        public virtual string ShowInfo()
        {
            return $"{Name} {SurName}";
        }
    }
}
