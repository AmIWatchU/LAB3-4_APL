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

namespace _02._WpfExercise_v._1
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

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {

            // if name left blank, just exit
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("You haven't typed in a name!", "Error");
                txtName.Focus();
                return;
            }

            // otherwise, display name
            MessageBox.Show("Welcome, " + txtName.Text);

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // close form
            this.Close();

        }
    }
}
