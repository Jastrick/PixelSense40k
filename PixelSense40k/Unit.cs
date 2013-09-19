﻿using System;
using Microsoft.Surface.Presentation.Input;

public class Unit
{
    private int unitID;
    private int maxMove;
    private String name;
    private int faction;
    private int ws, bs, s, t, w, i, a, ld, sv, svType;

    public Unit()
	{
	}

    public int UnitID
    {
        get { return unitID; }
        set { unitID = value; }
    }

    public int MaxMove
    {
        get { return maxMove; }
        set { maxMove = value; }
    }
    
    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Faction
    {
        get { return faction; }
        set { faction = value; }
    }

    public int SvType
    {
        get { return svType; }
        set { svType = value; }
    }

    public int Sv
    {
        get { return sv; }
        set { sv = value; }
    }

    public int Ld
    {
        get { return ld; }
        set { ld = value; }
    }

    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int I
    {
        get { return i; }
        set { i = value; }
    }

    public int W
    {
        get { return w; }
        set { w = value; }
    }

    public int T
    {
        get { return t; }
        set { t = value; }
    }

    public int S
    {
        get { return s; }
        set { s = value; }
    }

    public int BS
    {
        get { return bs; }
        set { bs = value; }
    }

    public int WS
    {
        get { return ws; }
        set { ws = value; }
    }

}
