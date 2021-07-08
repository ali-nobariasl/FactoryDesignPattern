﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Interfaces
{
    internal interface IColorFactory
    {
        IColor GetColor(ColorsEnum color);
    }
}
