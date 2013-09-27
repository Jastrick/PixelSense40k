using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Surface.Presentation.Input;

namespace PixelSense40k
{
    public class Bike : Unit
    {
        public Bike(String n, int t)
        {
            Name = n;
            UnitID = t;
            MaxMove = 12;
        }
    }
}
