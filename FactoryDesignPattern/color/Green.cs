using FactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Green is the best color in the world");
        }
    }
}
