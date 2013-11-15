using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PixelSense40k
{
    /// <summary>
    /// Interaction logic for PlacedCircle.xaml
    /// </summary>
    public partial class PlacedCircle : UserControl
    {
        private int tagVal;
        private double centerX, centerY;

        private MovementDemo window;

        public MovementDemo Window
        {
            get { return window; }
            set { window = value; }
        }

        public double CenterY
        {
            get { return centerY; }
            set { centerY = value; }
        }

        public double CenterX
        {
            get { return centerX; }
            set { centerX = value; }
        }

        public PlacedCircle()
        {
            InitializeComponent();
        }

        private void lockUnlock(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < window.squadGroups[window.getUnit(tagVal).SquadNo].Units.Count; i++)
            {
                if (!window.squadGroups[window.getUnit(tagVal).SquadNo].Units[i].Equals(window.getUnit(tagVal))){
                    window.circles[window.squadGroups[window.getUnit(tagVal).SquadNo].Units[i].UnitID].altRemove();
                    i--;
                }
            }
            window.getUnit(tagVal).FirstToMove = true;
            RangeCircle r = new RangeCircle();
            r.CenterX = centerX;
            r.CenterY = centerY;
            r.Width = window.getUnit(tagVal).MaxMove * 96;
            r.Height = window.getUnit(tagVal).MaxMove * 96;
            r.TagVal = tagVal;
            window.addNewRange(r);
            window.addTagDefinition(tagVal);
            window.removeCircle(tagVal);
        }

        private void initiateAttack(object sender, RoutedEventArgs e)
        {
            if (window.seekAttack == true)
            {
                if (window.attacker.Faction != window.getUnit(tagVal).Faction)
                {

                }
            }
            else
            {
                window.seekAttack = true;
                window.attacker = window.getUnit(tagVal);
            }
        }

        public void altRemove()
        {
            RangeCircle r = new RangeCircle();
            r.CenterX = centerX;
            r.CenterY = centerY;
            r.TagVal = tagVal;
            window.addNewRange(r);
            window.addTagDefinition(tagVal);
            window.removeCircle(tagVal);
        }

        public int TagVal
        {
            get { return tagVal; }
            set { tagVal = value; }
        }
    }
}
