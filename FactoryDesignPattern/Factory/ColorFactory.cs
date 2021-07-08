using FactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    internal class ColorFactory : IColorFactory
    {
        public IColor GetColor(ColorsEnum color)
        {
            switch (color)
            {
                case ColorsEnum.RED:
                    return new Red();
                case ColorsEnum.GREEN:
                    return new Green();
                case ColorsEnum.BLUE:
                    return new Blue();
                default:
                    return null;

            }
        }
    }
}
