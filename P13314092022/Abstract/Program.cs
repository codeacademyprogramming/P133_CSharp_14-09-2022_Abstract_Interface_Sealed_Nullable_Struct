using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            //Bird bird = new Bird();

            Eagle eagle = new Eagle();
            Toyuq toyuq = new Toyuq();
            Shark shark = new Shark();

            eagle.Eat();
            toyuq.Eat();
            shark.Eat();
        }
    }
}
