using Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Services
{
    class Math : IMath
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Pow(int num, int pow)
        {
            int result = 1;

            for (int i = 1; i <= pow; i++)
            {
                result *= num;
            }

            return 0;
        }
    }
}
