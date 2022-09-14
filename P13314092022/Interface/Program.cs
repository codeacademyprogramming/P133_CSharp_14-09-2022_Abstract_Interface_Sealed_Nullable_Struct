using System;
using Interface.Models;
using Interface.Interfaces;
using Interface.Services;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IMath math = new Services.Math();
        }
    }
}
