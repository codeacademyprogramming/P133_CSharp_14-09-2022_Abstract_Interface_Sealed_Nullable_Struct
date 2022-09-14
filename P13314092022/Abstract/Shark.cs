using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Shark : Baliqlar
    {
        public override void Eat()
        {
            Console.WriteLine("Eat As Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim As shar");
        }
    }
}
