using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Bird : Animal
    {
        public bool IsFly;

        public abstract void Fly();
    }
}
