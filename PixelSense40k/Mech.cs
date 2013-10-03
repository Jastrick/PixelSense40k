using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Surface.Presentation.Input;

namespace PixelSense40k
{
    public class Mech : Unit
    {
        private int fA, sA, rA, hP;

        public int HP
        {
            get { return hP; }
            set { hP = value; }
        }

        public int RA
        {
            get { return rA; }
            set { rA = value; }
        }

        public int SA
        {
            get { return sA; }
            set { sA = value; }
        }

        public int FA
        {
            get { return fA; }
            set { fA = value; }
        }

        public Mech(String n, int t)
        {
            Name = n;
            UnitID = t;
            MaxMove = 6;
        }
    }
}
