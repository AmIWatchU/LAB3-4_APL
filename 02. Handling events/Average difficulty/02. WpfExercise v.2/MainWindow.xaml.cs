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

namespace _02._WpfExercise_v._2
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

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {

            // get the name of the drink
            string DrinkName = txtDrink.Text;

            // if no drink ordered, display message
            if (DrinkName.Length == 0)
            {
                MessageBox.Show("No drink ordered");
                txtDrink.Focus();
                return;
            }

            // how many sugars
            int Sugars;

            // try converting input sugars to integer
            try
            {
                Sugars = Convert.ToInt32(txtSugars.Text);
            }
            catch
            {
                Sugars = -1;
            }

            // if no sugars ordered, display message
            if (Sugars == -1)
            {
                MessageBox.Show("You haven't ordered any sugars");
                txtSugars.Focus();
                return;
            }

            // finally, display order
            MessageBox.Show("You have ordered a " + DrinkName.ToUpper() + " with " + Sugars.ToString() + " sugars", "Order confirmation");
        }
    }
}
