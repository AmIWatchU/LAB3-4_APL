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

namespace _08._WpfExercise_v._3
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            // create a list of playing card suits
            List<clsSuit> suits = new List<clsSuit>();

            // add the 4 suits
            suits.Add(new clsSuit("Spades", @"Res\" + "spade"));
            suits.Add(new clsSuit("Hearts", "Res\\" + "heart"));
            suits.Add(new clsSuit("Diamonds", "Res\\" + "diamond"));
            suits.Add(new clsSuit("Clubs", "Res\\" + "club"));

            // show list of possible suits in list box
            lstSuit.ItemsSource = suits;

        }

        private void lstSuit_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            // get at the listbox just double-clicked on
            ListBox lb = (ListBox)sender;

            // show its suit
            clsSuit suit = (clsSuit)lb.SelectedItem;

            MessageBox.Show(suit.SuitName);

        }
    }
}
