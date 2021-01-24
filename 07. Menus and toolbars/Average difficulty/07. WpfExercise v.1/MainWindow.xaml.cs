using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _07._WpfExercise_v._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // colour 1 handlers
        private void mnuColour1Blue_Click(object sender, RoutedEventArgs e)
        {
            ColourGradient(0, Colors.Blue, "blue");
        }
        private void mnuColour1Red_Click(object sender, RoutedEventArgs e)
        {
            ColourGradient(0, Colors.Red, "red");
        }
        private void mnuColour1Yellow_Click(object sender, RoutedEventArgs e)
        {
            ColourGradient(0, Colors.Yellow, "yellow");
        }
        private void mnuColour1Grey_Click(object sender, RoutedEventArgs e)
        {
            ColourGradient(0, Colors.Gray, "gray");
        }

        // colour 2 handlers
        private void mnuColour2Blue_Click(object sender, RoutedEventArgs e)
        {
            ColourGradient(1, Colors.Blue, "blue");
        }
        private void mnuColour2Red_Click(object sender, RoutedEventArgs e)
        {
            ColourGradient(1, Colors.Red, "red");
        }
        private void mnuColour2Yellow_Click(object sender, RoutedEventArgs e)
        {
            ColourGradient(1, Colors.Yellow, "yellow");
        }
        private void mnuColour2Grey_Click(object sender, RoutedEventArgs e)
        {
            ColourGradient(1, Colors.Gray, "gray");
        }


        void ColourGradient(int StopNumber, Color Colour, string ColourName)
        {

            // get at current gradient brush for border control
            LinearGradientBrush lb = (LinearGradientBrush)bdr.Background;

            // change its first or second colour
            lb.GradientStops[StopNumber].Color = Colour;

            // uncheck all other colours - first find out which menu this is
            MenuItem thisMenu;

            if (StopNumber == 0)
            {
                thisMenu = mnuColour1;
            }
            else
            {
                thisMenu = mnuColour2;
            }

            // loop over all of the items in this menu
            foreach (var Item in thisMenu.Items)
            {
                MenuItem thisMenuItem = Item as MenuItem;

                // the error trap will mean we ignore separator rows
                try
                {
                    // if the menu name doesn't end with the right colour ...
                    if (!thisMenuItem.Name.ToLower().EndsWith(ColourName.ToLower()))
                    {
                        // ... uncheck it
                        thisMenuItem.IsChecked = false;
                    }
                }
                catch
                {
                }
            }

        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            toolbarColour(Colors.Blue);
        }
        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            toolbarColour(Colors.Green);
        }
        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            toolbarColour(Colors.Red);
        }
        private void btnGrey_Click(object sender, RoutedEventArgs e)
        {
            toolbarColour(Colors.Gray);
        }

        private void toolbarColour(Color c)
        {

            // get at current gradient brush for border control
            LinearGradientBrush lb = (LinearGradientBrush)bdr.Background;

            // set all colours to one required
            foreach (GradientStop gs in lb.GradientStops)
            {
                gs.Color = c;
            }

        }
    }
}
