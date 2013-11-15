using System;
using System.Windows;
using System.Windows.Media;
using System.Collections.ObjectModel;
using Microsoft.Surface.Presentation.Input;

public class Squad
{
    private int squadNo;
    private bool isMoving;
    private PointCollection unitLocs;
    private Collection<Unit> units;
    private bool firstUnitPlaced;
    private bool fullSquadPlaced;

    public bool FullSquadPlaced
    {
        get { return fullSquadPlaced; }
        set { fullSquadPlaced = value; }
    }

    public bool FirstUnitPlaced
    {
        get { return firstUnitPlaced; }
        set { firstUnitPlaced = value; }
    }
    
    public Collection<Unit> Units
    {
        get { return units; }
        set { units = value; }
    }

    public Squad(int sn, int numUnits)
	{
        isMoving = false;
        squadNo = sn;
        unitLocs = new PointCollection();
        units = new Collection<Unit>();
        fullSquadPlaced = false;
        firstUnitPlaced = false;
	}

    public int SquadNo
    {
        get { return squadNo; }
        set { squadNo = value; }
    }

    public bool IsMoving
    {
        get { return isMoving; }
        set { isMoving = value; }
    }

    public PointCollection UnitLocs
    {
        get { return unitLocs; }
        set { unitLocs = value; }
    }
}
