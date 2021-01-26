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

// extra namespaces
using System.Configuration;
using System.Data.SqlClient; // з цим проблема в .NET, потрібно використовувати Microsoft.Data.SqlClient
using System.Data;


// https://devblogs.microsoft.com/dotnet/introducing-the-new-microsoftdatasqlclient/
// https://www.nuget.org/packages/Microsoft.Data.SqlClient/
using Microsoft.Data.SqlClient;

namespace _09._WpfExercise_v._1
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
            // create a connection to Top Trumps database
            String cs = ConfigurationManager.ConnectionStrings["csCards"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);

            try
            {

                // create a new dataset
                DataSet ds = new DataSet();

                // open the connection (not strictly necessary, as the
                // data adapter will do this when you use it anyway)
                cn.Open();

                // fill data tables
                SqlDataAdapter daCards = new SqlDataAdapter();
                daCards.SelectCommand =
                    new SqlCommand("SELECT * FROM tblCard WHERE PackId=1", cn);
                daCards.Fill(ds, "Cards");

                // now set the data context for the entire window
                this.DataContext = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close the connection whether went wrong or not
                cn.Close();

            }
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            // find out the row clicked on
            DataRowView dr = dg.SelectedItem as DataRowView;

            // get the field values for this row
            string CardTitle = (string)dr["CardTitle"];
            string CardDesc = (string)dr["Description"];

            // display choice made
            MessageBox.Show(CardDesc, CardTitle);

        }
    }
}
