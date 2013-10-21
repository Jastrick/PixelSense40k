using System;
using System.Collections.Generic;
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
using Microsoft.Surface;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;
using Microsoft.Surface.Presentation.Input;

namespace PixelSense40k
{
    /// <summary>
    /// Interaction logic for PlacementCircle.xaml
    /// </summary>

    public partial class PlacementCircle : TagVisualization
    {
        private MovementDemo window;

        public MovementDemo Window
        {
            get { return window; }
            set { window = value; }
        }

        private int tagVal;

        public int TagVal
        {
            get { return tagVal; }
            set { tagVal = value; }
        }
        public PlacementCircle()
        {
            InitializeComponent();
        }

        private void lockUnlock(object sender, RoutedEventArgs e)
        {
            Unit checkunit = window.getUnit(tagVal);
            Point here = this.Center;
            if (checkunit.IsInitialPlacement)
            {
                PlacedCircle newCircle = new PlacedCircle();
                newCircle.TagVal = tagVal;
                window.addNewCircle(newCircle, here);
                window.removeTagDefinition(tagVal);
                checkunit.IsInitialPlacement = false;
            }
            else
            {
                if (window.isWithinRange(tagVal, here))
                {
                    PlacedCircle newCircle = new PlacedCircle();
                    newCircle.TagVal = tagVal;
                    window.addNewCircle(newCircle, here);
                    window.removeTagDefinition(tagVal);
                    window.removeRange(tagVal);
                }
                else
                {
                    window.FlashWarning(tagVal);
                }
            }
        }

        private void PlacementCircle_Loaded(object sender, RoutedEventArgs e)
        {
            //TODO: customize PlacementCircle's UI based on this.VisualizedTag here
        }
    }
}
