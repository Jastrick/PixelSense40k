using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelSense40k
{
    class Ranged : Weapon
    {
        bool isHeavy, isRapid, isAssault, isPistol, isCombi, hasUsedPlasma, isBlast, isGetsHot, isRending, isShred, isMelta;
        int shotCount, range;

        public Ranged()
        {
            shotCount = 1;
        }

        public bool IsHeavy
        {
            get { return isHeavy; }
            set { isHeavy = value; }
        }

        public bool IsRapid
        {
            get { return isRapid; }
            set { isRapid = value; }
        }

        public bool IsAssault
        {
            get { return isAssault; }
            set { isAssault = value; }
        }

        public bool IsPistol
        {
            get { return isPistol; }
            set { isPistol = value; }
        }

        public bool IsCombi
        {
            get { return isCombi; }
            set { isCombi = value; }
        }

        public bool HasUsedPlasma
        {
            get { return hasUsedPlasma; }
            set { hasUsedPlasma = value; }
        }

        public bool IsBlast
        {
            get { return isBlast; }
            set { isBlast = value; }
        }

        public bool IsGetsHot
        {
            get { return isGetsHot; }
            set { isGetsHot = value; }
        }

        public bool IsRending
        {
            get { return isRending; }
            set { isRending = value; }
        }

        public bool IsShred
        {
            get { return isShred; }
            set { isShred = value; }
        }

        public bool IsMelta
        {
            get { return isMelta; }
            set { isMelta = value; }
        }

        public int ShotCount
        {
            get { return shotCount; }
            set { shotCount = value; }
        }

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

    }
}
