using FactoryDesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory abstractFactory = new AbstractFactory();
            var shape = abstractFactory.GetShape(ShapesEnum.CIRCLE);
            var color = abstractFactory.GetColor(ColorsEnum.BLUE);
            shape.Draw();
            color.Fill();
            Console.ReadLine();
        }
    }
}
