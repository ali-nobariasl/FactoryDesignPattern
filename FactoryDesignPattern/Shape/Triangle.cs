using FactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Shape
{
    class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Triangle is Drawing");
        }
    }
}
