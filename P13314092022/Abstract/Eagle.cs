using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat As Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly As Eagle");
        }
    }
}
