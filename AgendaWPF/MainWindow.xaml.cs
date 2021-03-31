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
using AgendaWPF.Pages;

namespace AgendaWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer addCustomerPage = new AddCustomer();
            MainFrame.Navigate(addCustomerPage);
        }
        private void CustomerList_Click(object sender, RoutedEventArgs e)
        {
            ListCustomer customerListPage = new ListCustomer();
            MainFrame.Navigate(customerListPage);
        }
        private void AddBroker_Click(object sender, RoutedEventArgs e)
        {
            addBroker addBrokerPage = new addBroker();
            MainFrame.Navigate(addBrokerPage);
        }
        private void ListBroker_Click(object sender, RoutedEventArgs e)
        {
            ListBroker ListBrokerPage = new ListBroker();
            MainFrame.Navigate(ListBrokerPage);
        }
        private void AddAppointment_Click(object sender, RoutedEventArgs e)
        {
            AddAppointment AddAppointmentPage = new AddAppointment();
            MainFrame.Navigate(AddAppointmentPage);
        }
        private void ListAppointment_Click(object sender, RoutedEventArgs e)
        {
            ListAppointment ListAppointmentPage = new ListAppointment();
            MainFrame.Navigate(ListAppointmentPage);
        }
    }
}
