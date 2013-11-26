using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelSense40k
{
    class Melee : Weapon
    {
        private bool isMult, isUnwieldy, isSpecialist, isArmorbane, isConcussive;

        public Melee()
        {

        }

        public bool IsConcussive
        {
            get { return isConcussive; }
            set { isConcussive = value; }
        }

        public bool IsMult
        {
            get { return isMult; }
            set { isMult = value; }
        }

        public bool IsUnwieldy
        {
            get { return isUnwieldy; }
            set { isUnwieldy = value; }
        }

        public bool IsSpecialist
        {
            get { return isSpecialist; }
            set { isSpecialist = value; }
        }

        public bool IsArmorbane
        {
            get { return isArmorbane; }
            set { isArmorbane = value; }
        }
    }
}
