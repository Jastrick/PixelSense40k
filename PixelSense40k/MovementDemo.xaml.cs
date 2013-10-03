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
    /// Interaction logic for MovementDemo.xaml
    /// </summary>
    public partial class MovementDemo : SurfaceWindow
    {
        private SurfaceWindow1 parent;
        public Unit[] units;
        /// <summary>
        /// Default constructor.
        /// </summary>
        public MovementDemo()
        {
            InitializeComponent();
            InitializeDefinitions();
            CreateUnits();
            // Add handlers for window availability events
            AddWindowAvailabilityHandlers();
        }
        
        public void SetParent(SurfaceWindow1 w)
        {
            parent = w;
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            parent.Show();
            this.Hide();
        }

        private void OnVisualizationAdded(object sender, TagVisualizerEventArgs e)
        {
        }

        public void CreateUnits()
        {
            units = new Unit[0X31];
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
            units[0x00] = Seraphicus;
            Infantry Balthasar = new Infantry("Company Master Balthasar", 1);
            Balthasar.Photo = "Resources/balthasar.jpg";
            Balthasar.WS = 6;
            Balthasar.BS = 5;
            Balthasar.S = 4;
            Balthasar.T = 4;
            Balthasar.W = 3;
            Balthasar.I = 5;
            Balthasar.A = 3;
            Balthasar.Ld = 10;
            Balthasar.Sv = 4;
            Balthasar.SvType = 2;
            Balthasar.Faction = 1;
            units[0x01] = Balthasar;
            Infantry Turmiel = new Infantry("Librarian Turmiel", 2);
            Turmiel.Photo = "Resources/turmiel.jpg";
            Turmiel.WS = 5;
            Turmiel.BS = 4;
            Turmiel.S = 4;
            Turmiel.T = 4;
            Turmiel.W = 2;
            Turmiel.I = 4;
            Turmiel.A = 2;
            Turmiel.Ld = 10;
            Turmiel.Sv = 3;
            Turmiel.SvType = 1;
            Turmiel.Faction = 1;
            units[0x02] = Turmiel;
            Infantry Raphael = new Infantry("Veteran Sergeant Raphael", 3);
            Raphael.Photo = "Resources/raphael.jpg";
            Raphael.WS = 4;
            Raphael.BS = 4;
            Raphael.S = 4;
            Raphael.T = 4;
            Raphael.W = 1;
            Raphael.I = 4;
            Raphael.A = 2;
            Raphael.Ld = 9;
            Raphael.Sv = 3;
            Raphael.SvType = 1;
            Raphael.Faction = 1;
            units[0x03] = Raphael;
            Infantry Marinepc = new Infantry("Space Marine with Plasma Cannon", 4);
            Marinepc.Photo = "Resources/marinepc.jpg";
            Marinepc.WS = 4;
            Marinepc.BS = 4;
            Marinepc.S = 4;
            Marinepc.T = 4;
            Marinepc.W = 1;
            Marinepc.I = 4;
            Marinepc.A = 1;
            Marinepc.Ld = 8;
            Marinepc.Sv = 3;
            Marinepc.SvType = 1;
            Marinepc.Faction = 1;
            units[0x04] = Marinepc;
            Infantry Marinepg = new Infantry("Space Marine with Plasma Gun", 5);
            Marinepg.Photo = "Resources/marinepg.jpg";
            Marinepg.WS = 4;
            Marinepg.BS = 4;
            Marinepg.S = 4;
            Marinepg.T = 4;
            Marinepg.W = 1;
            Marinepg.I = 4;
            Marinepg.A = 1;
            Marinepg.Ld = 8;
            Marinepg.Sv = 3;
            Marinepg.SvType = 1;
            Marinepg.Faction = 1;
            units[0x05] = Marinepg;
            Infantry Marine1 = new Infantry("Space Marine 1", 6);
            Marine1.Photo = "Resources/marine15.jpg";
            Marine1.WS = 4;
            Marine1.BS = 4;
            Marine1.S = 4;
            Marine1.T = 4;
            Marine1.W = 1;
            Marine1.I = 4;
            Marine1.A = 1;
            Marine1.Ld = 8;
            Marine1.Sv = 3;
            Marine1.SvType = 1;
            Marine1.Faction = 1;
            units[0x06] = Marine1;
            Infantry Marine2 = new Infantry("Space Marine 2", 7);
            Marine2.Photo = "Resources/marine246.jpg";
            Marine2.WS = 4;
            Marine2.BS = 4;
            Marine2.S = 4;
            Marine2.T = 4;
            Marine2.W = 1;
            Marine2.I = 4;
            Marine2.A = 1;
            Marine2.Ld = 8;
            Marine2.Sv = 3;
            Marine2.SvType = 1;
            Marine2.Faction = 1;
            units[0x07] = Marine2;
            Infantry Marine3 = new Infantry("Space Marine 3", 8);
            Marine3.Photo = "Resources/marine37.jpg";
            Marine3.WS = 4;
            Marine3.BS = 4;
            Marine3.S = 4;
            Marine3.T = 4;
            Marine3.W = 1;
            Marine3.I = 4;
            Marine3.A = 1;
            Marine3.Ld = 8;
            Marine3.Sv = 3;
            Marine3.SvType = 1;
            Marine3.Faction = 1;
            units[0x08] = Marine3;
            Infantry Marine4 = new Infantry("Space Marine 4", 9);
            Marine4.Photo = "Resources/marine246.jpg";
            Marine4.WS = 4;
            Marine4.BS = 4;
            Marine4.S = 4;
            Marine4.T = 4;
            Marine4.W = 1;
            Marine4.I = 4;
            Marine4.A = 1;
            Marine4.Ld = 8;
            Marine4.Sv = 3;
            Marine4.SvType = 1;
            Marine4.Faction = 1;
            units[0x09] = Marine4;
            Infantry Marine5 = new Infantry("Space Marine 5", 0x0A);
            Marine5.Photo = "Resources/marine15.jpg";
            Marine5.WS = 4;
            Marine5.BS = 4;
            Marine5.S = 4;
            Marine5.T = 4;
            Marine5.W = 1;
            Marine5.I = 4;
            Marine5.A = 1;
            Marine5.Ld = 8;
            Marine5.Sv = 3;
            Marine5.SvType = 1;
            Marine5.Faction = 1;
            units[0x0A] = Marine5;
            Infantry Marine6 = new Infantry("Space Marine 6", 0x0B);
            Marine6.Photo = "Resources/marine246.jpg";
            Marine6.WS = 4;
            Marine6.BS = 4;
            Marine6.S = 4;
            Marine6.T = 4;
            Marine6.W = 1;
            Marine6.I = 4;
            Marine6.A = 1;
            Marine6.Ld = 8;
            Marine6.Sv = 3;
            Marine6.SvType = 1;
            Marine6.Faction = 1;
            units[0x0B] = Marine6;
            Infantry Marine7 = new Infantry("Space Marine 7", 0x0C);
            Marine7.Photo = "Resources/marine37.jpg";
            Marine7.WS = 4;
            Marine7.BS = 4;
            Marine7.S = 4;
            Marine7.T = 4;
            Marine7.W = 1;
            Marine7.I = 4;
            Marine7.A = 1;
            Marine7.Ld = 8;
            Marine7.Sv = 3;
            Marine7.SvType = 1;
            Marine7.Faction = 1;
            units[0x0C] = Marine7;
            Infantry Barachiel = new Infantry("Sergeant Barachiel", 0x0D);
            Barachiel.Photo = "Resources/barachiel.jpg";
            Barachiel.WS = 4;
            Barachiel.BS = 4;
            Barachiel.S = 4;
            Barachiel.T = 4;
            Barachiel.W = 1;
            Barachiel.I = 4;
            Barachiel.A = 2;
            Barachiel.Ld = 9;
            Barachiel.Sv = 2;
            Barachiel.SvType = 1;
            Barachiel.Faction = 1;
            units[0x0D] = Barachiel;
            Infantry Termac = new Infantry("Terminator with Assault Cannon", 0x0E);
            Termac.Photo = "Resources/termac.jpg";
            Termac.WS = 4;
            Termac.BS = 4;
            Termac.S = 4;
            Termac.T = 4;
            Termac.W = 1;
            Termac.I = 4;
            Termac.A = 2;
            Termac.Ld = 9;
            Termac.Sv = 2;
            Termac.SvType = 1;
            Termac.Faction = 1;
            units[0x0E] = Termac;
            Infantry Termcf = new Infantry("Terminator with Chainfist", 0x0F);
            Termcf.Photo = "Resources/termcf.jpg";
            Termcf.WS = 4;
            Termcf.BS = 4;
            Termcf.S = 4;
            Termcf.T = 4;
            Termcf.W = 1;
            Termcf.I = 4;
            Termcf.A = 2;
            Termcf.Ld = 9;
            Termcf.Sv = 2;
            Termcf.SvType = 1;
            Termcf.Faction = 1;
            units[0x0F] = Termcf;
            Infantry Term1 = new Infantry("Terminator 1", 0x10);
            Term1.Photo = "Resources/term.jpg";
            Term1.WS = 4;
            Term1.BS = 4;
            Term1.S = 4;
            Term1.T = 4;
            Term1.W = 1;
            Term1.I = 4;
            Term1.A = 2;
            Term1.Ld = 9;
            Term1.Sv = 2;
            Term1.SvType = 1;
            Term1.Faction = 1;
            units[0x10] = Term1;
            Infantry Term2 = new Infantry("Terminator 2", 0x11);
            Term2.Photo = "Resources/term.jpg";
            Term2.WS = 4;
            Term2.BS = 4;
            Term2.S = 4;
            Term2.T = 4;
            Term2.W = 1;
            Term2.I = 4;
            Term2.A = 2;
            Term2.Ld = 9;
            Term2.Sv = 2;
            Term2.SvType = 1;
            Term2.Faction = 1;
            units[0x11] = Term2;
            Bike Arion = new Bike("Sergeant Arion", 0x12);
            Arion.Photo = "Resources/arion.jpg";
            Arion.WS = 4;
            Arion.BS = 4;
            Arion.S = 4;
            Arion.T = 5;
            Arion.W = 1;
            Arion.I = 4;
            Arion.A = 2;
            Arion.Ld = 9;
            Arion.Sv = 3;
            Arion.SvType = 1;
            Arion.Faction = 1;
            units[0x12] = Arion;
            Bike Ravenwingpg = new Bike("Ravenwing Biker with Plasma Gun", 0x13);
            Ravenwingpg.Photo = "Resources/ravenwingpg.jpg";
            Ravenwingpg.WS = 4;
            Ravenwingpg.BS = 4;
            Ravenwingpg.S = 4;
            Ravenwingpg.T = 5;
            Ravenwingpg.W = 1;
            Ravenwingpg.I = 4;
            Ravenwingpg.A = 1;
            Ravenwingpg.Ld = 9;
            Ravenwingpg.Sv = 3;
            Ravenwingpg.SvType = 1;
            Ravenwingpg.Faction = 1;
            units[0x13] = Ravenwingpg;
            Bike Ravenwingbp = new Bike("Ravenwing Biker with Bolt Pistol", 0x14);
            Ravenwingbp.Photo = "Resources/ravenwingbp.jpg";
            Ravenwingbp.WS = 4;
            Ravenwingbp.BS = 4;
            Ravenwingbp.S = 4;
            Ravenwingbp.T = 5;
            Ravenwingbp.W = 1;
            Ravenwingbp.I = 4;
            Ravenwingbp.A = 1;
            Ravenwingbp.Ld = 9;
            Ravenwingbp.Sv = 3;
            Ravenwingbp.SvType = 1;
            Ravenwingbp.Faction = 1;
            units[0x14] = Ravenwingbp;
            Infantry Kranon = new Infantry("Kranon the Relentless", 0x15);
            Kranon.Photo = "Resources/kranon.jpg";
            Kranon.WS = 6;
            Kranon.BS = 5;
            Kranon.S = 4;
            Kranon.T = 5;
            Kranon.W = 3;
            Kranon.I = 5;
            Kranon.A = 3;
            Kranon.Ld = 10;
            Kranon.Sv = 5;
            Kranon.SvType = 2;
            Kranon.Faction = 2;
            units[0x15] = Kranon;
            Mech Mortis = new Mech("Mortis Metalikus", 0x16);
            Mortis.Photo = "Resources/mortismetalkus.jpg";
            Mortis.WS = 4;
            Mortis.BS = 4;
            Mortis.S = 6;
            Mortis.FA = 12;
            Mortis.SA = 12;
            Mortis.RA = 10;
            Mortis.I = 4;
            Mortis.A = 2;
            Mortis.HP = 3;
            Mortis.Faction = 2;
            units[0x16] = Mortis;
            Infantry Draznicht = new Infantry("Draznicht, Chosen Champion", 0x17);
            Draznicht.Photo = "Resources/draznicht.jpg";
            Draznicht.WS = 4;
            Draznicht.BS = 4;
            Draznicht.S = 4;
            Draznicht.T = 4;
            Draznicht.W = 1;
            Draznicht.I = 4;
            Draznicht.A = 2;
            Draznicht.Ld = 9;
            Draznicht.Sv = 3;
            Draznicht.SvType = 1;
            Draznicht.Faction = 2;
            units[0x17] = Draznicht;
            Infantry Chosenlc = new Infantry("Chosen with Lightning Claws", 0x18);
            Chosenlc.Photo = "Resources/chosenlc.jpg";
            Chosenlc.WS = 4;
            Chosenlc.BS = 4;
            Chosenlc.S = 4;
            Chosenlc.T = 4;
            Chosenlc.W = 1;
            Chosenlc.I = 4;
            Chosenlc.A = 2;
            Chosenlc.Ld = 9;
            Chosenlc.Sv = 3;
            Chosenlc.SvType = 1;
            Chosenlc.Faction = 2;
            units[0x18] = Chosenlc;
            Infantry Chosenpa = new Infantry("Chosen with Power Axe", 0x19);
            Chosenpa.Photo = "Resources/chosenpa.jpg";
            Chosenpa.WS = 4;
            Chosenpa.BS = 4;
            Chosenpa.S = 4;
            Chosenpa.T = 4;
            Chosenpa.W = 1;
            Chosenpa.I = 4;
            Chosenpa.A = 2;
            Chosenpa.Ld = 9;
            Chosenpa.Sv = 3;
            Chosenpa.SvType = 1;
            Chosenpa.Faction = 2;
            units[0x19] = Chosenpa;
            Infantry Chosenpf = new Infantry("Chosen with Power Fist", 0x1A);
            Chosenpf.Photo = "Resources/chosenpf.jpg";
            Chosenpf.WS = 4;
            Chosenpf.BS = 4;
            Chosenpf.S = 4;
            Chosenpf.T = 4;
            Chosenpf.W = 1;
            Chosenpf.I = 4;
            Chosenpf.A = 2;
            Chosenpf.Ld = 9;
            Chosenpf.Sv = 3;
            Chosenpf.SvType = 1;
            Chosenpf.Faction = 2;
            units[0x1A] = Chosenpf;
            Infantry Chosen1 = new Infantry("Chosen 1", 0x1B);
            Chosen1.Photo = "Resources/chosen.jpg";
            Chosen1.WS = 4;
            Chosen1.BS = 4;
            Chosen1.S = 4;
            Chosen1.T = 4;
            Chosen1.W = 1;
            Chosen1.I = 4;
            Chosen1.A = 2;
            Chosen1.Ld = 9;
            Chosen1.Sv = 3;
            Chosen1.SvType = 1;
            Chosen1.Faction = 2;
            units[0x1B] = Chosen1;
            Infantry Chosen2 = new Infantry("Chosen 2", 0x1C);
            Chosen2.Photo = "Resources/chosen.jpg";
            Chosen2.WS = 4;
            Chosen2.BS = 4;
            Chosen2.S = 4;
            Chosen2.T = 4;
            Chosen2.W = 1;
            Chosen2.I = 4;
            Chosen2.A = 2;
            Chosen2.Ld = 9;
            Chosen2.Sv = 3;
            Chosen2.SvType = 1;
            Chosen2.Faction = 2;
            units[0x1C] = Chosen2;
            Infantry Anarkus = new Infantry("Anarkus, Sect Leader", 0x1D);
            Anarkus.Photo = "Resources/anarkus.jpg";
            Anarkus.WS = 3;
            Anarkus.BS = 3;
            Anarkus.S = 3;
            Anarkus.T = 3;
            Anarkus.W = 1;
            Anarkus.I = 3;
            Anarkus.A = 2;
            Anarkus.Ld = 8;
            Anarkus.Sv = 6;
            Anarkus.SvType = 1;
            Anarkus.Faction = 2;
            units[0x1D] = Anarkus;
            Infantry Anarkusfla = new Infantry("Sect Anarkus Cultist with Flamer", 0x1E);
            Anarkusfla.Photo = "Resources/anarkusfla.jpg";
            Anarkusfla.WS = 3;
            Anarkusfla.BS = 3;
            Anarkusfla.S = 3;
            Anarkusfla.T = 3;
            Anarkusfla.W = 1;
            Anarkusfla.I = 3;
            Anarkusfla.A = 1;
            Anarkusfla.Ld = 7;
            Anarkusfla.Sv = 6;
            Anarkusfla.SvType = 1;
            Anarkusfla.Faction = 2;
            units[0x1E] = Anarkusfla;
            Infantry Anarkus1 = new Infantry("Sect Anarkus Cultist 1", 0x1F);
            Anarkus1.Photo = "Resources/anarkus15.jpg";
            Anarkus1.WS = 3;
            Anarkus1.BS = 3;
            Anarkus1.S = 3;
            Anarkus1.T = 3;
            Anarkus1.W = 1;
            Anarkus1.I = 3;
            Anarkus1.A = 1;
            Anarkus1.Ld = 7;
            Anarkus1.Sv = 6;
            Anarkus1.SvType = 1;
            Anarkus1.Faction = 2;
            units[0x1F] = Anarkus1;
            Infantry Anarkus2 = new Infantry("Sect Anarkus Cultist 2", 0x20);
            Anarkus2.Photo = "Resources/anarkus26.jpg";
            Anarkus2.WS = 3;
            Anarkus2.BS = 3;
            Anarkus2.S = 3;
            Anarkus2.T = 3;
            Anarkus2.W = 1;
            Anarkus2.I = 3;
            Anarkus2.A = 1;
            Anarkus2.Ld = 7;
            Anarkus2.Sv = 6;
            Anarkus2.SvType = 1;
            Anarkus2.Faction = 2;
            units[0x20] = Anarkus2;
            Infantry Anarkus3 = new Infantry("Sect Anarkus Cultist 3", 0x21);
            Anarkus3.Photo = "Resources/anarkus34.jpg";
            Anarkus3.WS = 3;
            Anarkus3.BS = 3;
            Anarkus3.S = 3;
            Anarkus3.T = 3;
            Anarkus3.W = 1;
            Anarkus3.I = 3;
            Anarkus3.A = 1;
            Anarkus3.Ld = 7;
            Anarkus3.Sv = 6;
            Anarkus3.SvType = 1;
            Anarkus3.Faction = 2;
            units[0x21] = Anarkus3;
            Infantry Anarkus4 = new Infantry("Sect Anarkus Cultist 4", 0x22);
            Anarkus4.Photo = "Resources/anarkus34.jpg";
            Anarkus4.WS = 3;
            Anarkus4.BS = 3;
            Anarkus4.S = 3;
            Anarkus4.T = 3;
            Anarkus4.W = 1;
            Anarkus4.I = 3;
            Anarkus4.A = 1;
            Anarkus4.Ld = 7;
            Anarkus4.Sv = 6;
            Anarkus4.SvType = 1;
            Anarkus4.Faction = 2;
            units[0x22] = Anarkus4;
            Infantry Anarkus5 = new Infantry("Sect Anarkus Cultist 5", 0x23);
            Anarkus5.Photo = "Resources/anarkus15.jpg";
            Anarkus5.WS = 3;
            Anarkus5.BS = 3;
            Anarkus5.S = 3;
            Anarkus5.T = 3;
            Anarkus5.W = 1;
            Anarkus5.I = 3;
            Anarkus5.A = 1;
            Anarkus5.Ld = 7;
            Anarkus5.Sv = 6;
            Anarkus5.SvType = 1;
            Anarkus5.Faction = 2;
            units[0x23] = Anarkus5;
            Infantry Anarkus6 = new Infantry("Sect Anarkus Cultist 6", 0x24);
            Anarkus6.Photo = "Resources/anarkus26.jpg";
            Anarkus6.WS = 3;
            Anarkus6.BS = 3;
            Anarkus6.S = 3;
            Anarkus6.T = 3;
            Anarkus6.W = 1;
            Anarkus6.I = 3;
            Anarkus6.A = 1;
            Anarkus6.Ld = 7;
            Anarkus6.Sv = 6;
            Anarkus6.SvType = 1;
            Anarkus6.Faction = 2;
            units[0x24] = Anarkus6;
            Infantry Anarkus7 = new Infantry("Sect Anarkus Cultist 7", 0x25);
            Anarkus7.Photo = "Resources/anarkus78.jpg";
            Anarkus7.WS = 3;
            Anarkus7.BS = 3;
            Anarkus7.S = 3;
            Anarkus7.T = 3;
            Anarkus7.W = 1;
            Anarkus7.I = 3;
            Anarkus7.A = 1;
            Anarkus7.Ld = 7;
            Anarkus7.Sv = 6;
            Anarkus7.SvType = 1;
            Anarkus7.Faction = 2;
            units[0x25] = Anarkus7;
            Infantry Anarkus8 = new Infantry("Sect Anarkus Cultist 8", 0x26);
            Anarkus8.Photo = "Resources/anarkus78.jpg";
            Anarkus8.WS = 3;
            Anarkus8.BS = 3;
            Anarkus8.S = 3;
            Anarkus8.T = 3;
            Anarkus8.W = 1;
            Anarkus8.I = 3;
            Anarkus8.A = 1;
            Anarkus8.Ld = 7;
            Anarkus8.Sv = 6;
            Anarkus8.SvType = 1;
            Anarkus8.Faction = 2;
            units[0x26] = Anarkus8;
            Infantry Tetchvar1 = new Infantry("Sect Tetchvar Cultist 1", 0x27);
            Tetchvar1.Photo = "Resources/tetchvar14.jpg";
            Tetchvar1.WS = 3;
            Tetchvar1.BS = 3;
            Tetchvar1.S = 3;
            Tetchvar1.T = 3;
            Tetchvar1.W = 1;
            Tetchvar1.I = 3;
            Tetchvar1.A = 1;
            Tetchvar1.Ld = 7;
            Tetchvar1.Sv = 6;
            Tetchvar1.SvType = 1;
            Tetchvar1.Faction = 2;
            units[0x27] = Tetchvar1;
            Infantry Tetchvar = new Infantry("Tetchvar, Sect Leader", 0x28);
            Tetchvar.Photo = "Resources/tetchvar.jpg";
            Tetchvar.WS = 3;
            Tetchvar.BS = 3;
            Tetchvar.S = 3;
            Tetchvar.T = 3;
            Tetchvar.W = 1;
            Tetchvar.I = 3;
            Tetchvar.A = 2;
            Tetchvar.Ld = 8;
            Tetchvar.Sv = 6;
            Tetchvar.SvType = 1;
            Tetchvar.Faction = 2;
            units[0x28] = Tetchvar;
            Infantry Tetchvarhs = new Infantry("Sect Tetchvar Cultist with Heavy Stubber", 0x29);
            Tetchvarhs.Photo = "Resources/tetchvarhs.jpg";
            Tetchvarhs.WS = 3;
            Tetchvarhs.BS = 3;
            Tetchvarhs.S = 3;
            Tetchvarhs.T = 3;
            Tetchvarhs.W = 1;
            Tetchvarhs.I = 3;
            Tetchvarhs.A = 1;
            Tetchvarhs.Ld = 7;
            Tetchvarhs.Sv = 6;
            Tetchvarhs.SvType = 1;
            Tetchvarhs.Faction = 2;
            units[0x29] = Tetchvarhs;
            Infantry Tetchvar2 = new Infantry("Sect Tetchvar Cultist 2", 0x2A);
            Tetchvar2.Photo = "Resources/tetchvar26.jpg";
            Tetchvar2.WS = 3;
            Tetchvar2.BS = 3;
            Tetchvar2.S = 3;
            Tetchvar2.T = 3;
            Tetchvar2.W = 1;
            Tetchvar2.I = 3;
            Tetchvar2.A = 1;
            Tetchvar2.Ld = 7;
            Tetchvar2.Sv = 6;
            Tetchvar2.SvType = 1;
            Tetchvar2.Faction = 2;
            units[0x2A] = Tetchvar2;
            Infantry Tetchvar3 = new Infantry("Sect Tetchvar Cultist 3", 0x2B);
            Tetchvar3.Photo = "Resources/tetchvar35.jpg";
            Tetchvar3.WS = 3;
            Tetchvar3.BS = 3;
            Tetchvar3.S = 3;
            Tetchvar3.T = 3;
            Tetchvar3.W = 1;
            Tetchvar3.I = 3;
            Tetchvar3.A = 1;
            Tetchvar3.Ld = 7;
            Tetchvar3.Sv = 6;
            Tetchvar3.SvType = 1;
            Tetchvar3.Faction = 2;
            units[0x2B] = Tetchvar3;
            Infantry Tetchvar4 = new Infantry("Sect Tetchvar Cultist 4", 0x2C);
            Tetchvar4.Photo = "Resources/tetchvar14.jpg";
            Tetchvar4.WS = 3;
            Tetchvar4.BS = 3;
            Tetchvar4.S = 3;
            Tetchvar4.T = 3;
            Tetchvar4.W = 1;
            Tetchvar4.I = 3;
            Tetchvar4.A = 1;
            Tetchvar4.Ld = 7;
            Tetchvar4.Sv = 6;
            Tetchvar4.SvType = 1;
            Tetchvar4.Faction = 2;
            units[0x2C] = Tetchvar4;
            Infantry Tetchvar5 = new Infantry("Sect Tetchvar Cultist 5", 0x2D);
            Tetchvar5.Photo = "Resources/tetchvar35.jpg";
            Tetchvar5.WS = 3;
            Tetchvar5.BS = 3;
            Tetchvar5.S = 3;
            Tetchvar5.T = 3;
            Tetchvar5.W = 1;
            Tetchvar5.I = 3;
            Tetchvar5.A = 1;
            Tetchvar5.Ld = 7;
            Tetchvar5.Sv = 6;
            Tetchvar5.SvType = 1;
            Tetchvar5.Faction = 2;
            units[0x2D] = Tetchvar5;
            Infantry Tetchvar6 = new Infantry("Sect Tetchvar Cultist 6", 0x2E);
            Tetchvar6.Photo = "Resources/tetchvar26.jpg";
            Tetchvar6.WS = 3;
            Tetchvar6.BS = 3;
            Tetchvar6.S = 3;
            Tetchvar6.T = 3;
            Tetchvar6.W = 1;
            Tetchvar6.I = 3;
            Tetchvar6.A = 1;
            Tetchvar6.Ld = 7;
            Tetchvar6.Sv = 6;
            Tetchvar6.SvType = 1;
            Tetchvar6.Faction = 2;
            units[0x2E] = Tetchvar6;
            Infantry Tetchvar7 = new Infantry("Sect Tetchvar Cultist 7", 0x2F);
            Tetchvar7.Photo = "Resources/tetchvar78.jpg";
            Tetchvar7.WS = 3;
            Tetchvar7.BS = 3;
            Tetchvar7.S = 3;
            Tetchvar7.T = 3;
            Tetchvar7.W = 1;
            Tetchvar7.I = 3;
            Tetchvar7.A = 1;
            Tetchvar7.Ld = 7;
            Tetchvar7.Sv = 6;
            Tetchvar7.SvType = 1;
            Tetchvar7.Faction = 2;
            units[0x2F] = Tetchvar7;
            Infantry Tetchvar8 = new Infantry("Sect Tetchvar Cultist 8", 0x30);
            Tetchvar8.Photo = "Resources/tetchvar78.jpg";
            Tetchvar8.WS = 3;
            Tetchvar8.BS = 3;
            Tetchvar8.S = 3;
            Tetchvar8.T = 3;
            Tetchvar8.W = 1;
            Tetchvar8.I = 3;
            Tetchvar8.A = 1;
            Tetchvar8.Ld = 7;
            Tetchvar8.Sv = 6;
            Tetchvar8.SvType = 1;
            Tetchvar8.Faction = 2;
            units[0x30] = Tetchvar8;
        }
        /// <summary>
        /// Initializes the Tag definitions for the visualizer
        /// </summary>
        private void InitializeDefinitions()
        {
            for (int tagVal = 0; tagVal < 0X31; tagVal++)
            {
                TagVisualizationDefinition tagDef =
                        new TagVisualizationDefinition();
                // The tag value that this definition will respond to.
                tagDef.Value = (byte)tagVal;
                // The .xaml file for the UI
                tagDef.Source =
                    new Uri("PlacementCircle.xaml", UriKind.Relative);
                // The maximum number for this tag value.
                tagDef.MaxCount = 1;
                // The visualization stays for 2 seconds.
                tagDef.LostTagTimeout = 2000.0;
                // Orientation offset (default).
                tagDef.OrientationOffsetFromTag = 0.0;
                // Physical offset (horizontal inches, vertical inches).
                tagDef.PhysicalCenterOffsetFromTag = new Vector(0,0);
                // Tag removal behavior (default).
                tagDef.TagRemovedBehavior = TagRemovedBehavior.Fade;
                // Orient UI to tag? (default).
                tagDef.UsesTagOrientation = true;
                // Add the definition to the collection.
                MyTagVisualizer.Definitions.Add(tagDef);
            }
        }
        /// <summary>
        /// Occurs when the window is about to close. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            if (parent.CloseCall == 0)
            {
                parent.CloseCall = 3;
                parent.Close();
            }
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
    }
}