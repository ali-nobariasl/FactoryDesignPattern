using FactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Red is the best color in the world");
        }
    }
}
