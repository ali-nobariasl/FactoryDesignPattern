using FactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Blue is the best color in the world");
        }
    }
}

