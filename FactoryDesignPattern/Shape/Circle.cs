using FactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Shape
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle is Drawing");
        }
    }
}
