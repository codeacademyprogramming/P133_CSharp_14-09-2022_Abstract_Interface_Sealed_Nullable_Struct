using System;
using System.Collections.Generic;
using System.Text;
using Interface.Interfaces;

namespace Interface.Models
{
    class Employee : Human, IWalk, ITest
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
