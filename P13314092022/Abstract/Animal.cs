using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Animal
    {
        public string Name;
        public byte Age;
        public bool Gender;

        public abstract void Eat();

        public virtual void Test()
        {

        }

    }
}
