using System;
using System.Windows;
using System.Windows.Media;
using System.Collections.ObjectModel;
using Microsoft.Surface.Presentation.Input;

public class Weapon
{
    int s;
    int ap;

    public Weapon()
	{
        
	}

    public int S
    {
        get { return s; }
        set { s = value; }
    }

    public int Ap
    {
        get { return ap; }
        set { ap = value; }
    }
}
