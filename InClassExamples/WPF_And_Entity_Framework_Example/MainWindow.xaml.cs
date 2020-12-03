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

namespace WPF_And_Entity_Framework_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static DB_128040_practiceEntities db = new DB_128040_practiceEntities();
        public MainWindow()
        {
            InitializeComponent();

            foreach (var customer in db.Customers)
            {
                cboOptions.Items.Add(customer.State);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("You clicked the button!");

            if (cboOptions.SelectedValue.ToString() != "")
            {
                foreach (var customer in db.Customers.OrderBy(cust => cust.LastName).Where(cust => cust.State == cboOptions.SelectedValue.ToString()))
                {
                    lstItems.Items.Add(customer);
                }
            }
            else
            {
                foreach (var customer in db.Customers)
                {
                    lstItems.Items.Add(customer);
                }
            }

            

            

        }

        private void cboOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
