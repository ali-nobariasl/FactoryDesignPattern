using FactoryDesignPattern.Interfaces;
using FactoryDesignPattern.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    internal class ShapeFactory : IShapeFactory
    {
        public IShape GetShape(ShapesEnum shapes)
        {
            switch (shapes)
            {
                case ShapesEnum.RECTANGLE:
                    return new Triangle();
                case ShapesEnum.SQUARE:
                    return new Square();
                case ShapesEnum.CIRCLE:
                    return new Circle();
                default:
                    return null;
            }
        }
    }
}
