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
    /// Interaction logic for RangeCircle.xaml
    /// </summary>
    public partial class RangeCircle : UserControl
    {
        private double centerX, centerY;
        private int tagVal;
        private MovementDemo window;

        public MovementDemo Window
        {
            get { return window; }
            set { window = value; }
        }

        public int TagVal
        {
            get { return tagVal; }
            set { tagVal = value; }
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

        public RangeCircle()
        {
            InitializeComponent();
        }
    }
}
