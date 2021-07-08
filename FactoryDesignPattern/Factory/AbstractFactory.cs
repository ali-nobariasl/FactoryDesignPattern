using FactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    internal class AbstractFactory : IAbstractFactory
    {
        public IColor GetColor(ColorsEnum color)
        {
            ColorFactory colorFactory = new ColorFactory();
            return colorFactory.GetColor(color);
        }

        public IShape GetShape(ShapesEnum shape)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            return shapeFactory.GetShape(shape);
        }
    }
}
