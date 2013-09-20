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
using Microsoft.Surface;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;
using Microsoft.Surface.Presentation.Input;

namespace PixelSense40k
{
    /// <summary>
    /// Interaction logic for SurfaceWindow1.xaml
    /// </summary>
    /// 
    public partial class SurfaceWindow1 : SurfaceWindow
    {
        public Unit[] units;
        /// <summary>
        /// Default constructor.
        /// </summary>
        ///
        public SurfaceWindow1()
        {
            InitializeComponent();
            InitializeDefinitions();
            CreateUnits();
            // Add handlers for window availability events
            AddWindowAvailabilityHandlers();
        }

        public void CreateUnits(){
            units = new Unit[1];
            Infantry Seraphicus = new Infantry("Interrogator-Chaplain Seraphicus", 0);
            Seraphicus.Photo = "Resources/seraphicus.jpg";
            Seraphicus.WS = 5;
            Seraphicus.BS = 5;
            Seraphicus.S = 4;
            Seraphicus.T = 4;
            Seraphicus.W = 3;
            Seraphicus.I = 5;
            Seraphicus.A = 3;
            Seraphicus.Ld = 10;
            Seraphicus.Sv = 4;
            Seraphicus.SvType = 2;
            Seraphicus.Faction = 1;
            Seraphicus.UnitID = 0;
            units[0] = Seraphicus;
        }

        private void InitializeDefinitions()
        {
            TagVisualizationDefinition tagDef =
                    new TagVisualizationDefinition();
            // The tag value that this definition will respond to.
            tagDef.Value = 0;
            // The .xaml file for the UI
            tagDef.Source =
                new Uri("UnitVisualization.xaml", UriKind.Relative);
            // The maximum number for this tag value.
            tagDef.MaxCount = 2;
            // The visualization stays for 2 seconds.
            tagDef.LostTagTimeout = 2000.0;
            // Orientation offset (default).
            tagDef.OrientationOffsetFromTag = 0.0;
            // Physical offset (horizontal inches, vertical inches).
            tagDef.PhysicalCenterOffsetFromTag = new Vector(2.0, 2.0);
            // Tag removal behavior (default).
            tagDef.TagRemovedBehavior = TagRemovedBehavior.Fade;
            // Orient UI to tag? (default).
            tagDef.UsesTagOrientation = true;
            // Add the definition to the collection.
            MyTagVisualizer.Definitions.Add(tagDef);
        }

        private void OnVisualizationAdded(object sender, TagVisualizerEventArgs e)
        {
            UnitVisualization taggedUnit = (UnitVisualization)e.TagVisualization;
            taggedUnit.UnitName.Content = units[taggedUnit.VisualizedTag.Value].Name;
            BitmapImage testImage = new BitmapImage(new Uri(units[taggedUnit.VisualizedTag.Value].Photo, UriKind.Relative)); //Change for your PC
            taggedUnit.Photo.Source = testImage;
            if (units[taggedUnit.VisualizedTag.Value].Faction == 1)
            {
                taggedUnit.Faction.Content = "Dark Angels Space Marines";
            }
            else{
                taggedUnit.Faction.Content = "Chaos Space Marines";
            }
        }
        /// <summary>
        /// Occurs when the window is about to close. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // Remove handlers for window availability events
            RemoveWindowAvailabilityHandlers();
        }

        /// <summary>
        /// Adds handlers for window availability events.
        /// </summary>
        private void AddWindowAvailabilityHandlers()
        {
            // Subscribe to surface window availability events
            ApplicationServices.WindowInteractive += OnWindowInteractive;
            ApplicationServices.WindowNoninteractive += OnWindowNoninteractive;
            ApplicationServices.WindowUnavailable += OnWindowUnavailable;
        }

        /// <summary>
        /// Removes handlers for window availability events.
        /// </summary>
        private void RemoveWindowAvailabilityHandlers()
        {
            // Unsubscribe from surface window availability events
            ApplicationServices.WindowInteractive -= OnWindowInteractive;
            ApplicationServices.WindowNoninteractive -= OnWindowNoninteractive;
            ApplicationServices.WindowUnavailable -= OnWindowUnavailable;
        }

        /// <summary>
        /// This is called when the user can interact with the application's window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowInteractive(object sender, EventArgs e)
        {
            //TODO: enable audio, animations here
        }

        /// <summary>
        /// This is called when the user can see but not interact with the application's window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowNoninteractive(object sender, EventArgs e)
        {
            //TODO: Disable audio here if it is enabled

            //TODO: optionally enable animations here
        }

        /// <summary>
        /// This is called when the application's window is not visible or interactive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowUnavailable(object sender, EventArgs e)
        {
            //TODO: disable audio, animations here
        }

        public Unit getUnit(int i)
        {
            return units[i];
        }
    }
}