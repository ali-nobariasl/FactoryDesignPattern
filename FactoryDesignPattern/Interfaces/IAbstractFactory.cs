﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Interfaces
{
    internal interface IAbstractFactory
    {
        IShape GetShape(ShapesEnum shapes);
        IColor GetColor(ColorsEnum colors);
    }
}
