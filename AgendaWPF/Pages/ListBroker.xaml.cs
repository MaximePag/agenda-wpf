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
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace AgendaWPF.Pages
{
    /// <summary>
    /// Logique d'interaction pour ListBroker.xaml
    /// </summary>
    public partial class ListBroker : Page
    {
        private AgendaContext db = new AgendaContext();
        public ListBroker()
        {
            InitializeComponent();
            var brokers = db.af458_brokers.ToList();
            dgBrokers.ItemsSource = brokers;

        }

        private void dgBrokers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            af458_brokers customer = (af458_brokers)dgBrokers.SelectedItem;
            lastname_input.Text = customer.lastname;
            firstname_input.Text = customer.firstname;
            mail_input.Text = customer.mail;
            phoneNumber_input.Text = customer.phoneNumber;
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            af458_brokers customer = (af458_brokers)dgBrokers.SelectedItem;
            af458_brokers af458_brokers = db.af458_brokers.Find(customer.id);
            try
            {
                db.af458_brokers.Remove(af458_brokers);
                db.SaveChanges();
                MainWindow main = Application.Current.MainWindow as MainWindow;
                ListBroker ListBrokerPage = new ListBroker();
                main.MainFrame.Navigate(ListBrokerPage);
                error_message.Text = "Le client a bien été supprimé";
            }
            catch (DbEntityValidationException)
            {
                error_message.Text = "Le client n'a pas pu être supprimé";
            }
        }

        private void Edit_Button(object sender, RoutedEventArgs e)
        {
            bool formError = false;
            af458_brokers customerToEdit = (af458_brokers)dgBrokers.SelectedItem;
            af458_brokers customer = db.af458_brokers.Find(customerToEdit.id);
            if (lastname_input.Text != "")
            {
                customer.lastname = lastname_input.Text;
                error_message.Text = "";
            }
            else
            {
                error_message.Text = "Veuillez renseigner le nom du client.";
                formError = true;
            }
            if (firstname_input.Text != "")
            {
                customer.firstname = firstname_input.Text;
                error_message.Text = "";
            }
            else
            {
                error_message.Text = "Veuillez renseigner le prénom du client.";
                formError = true;
            }
            if (mail_input.Text != "")
            {
                customer.mail = mail_input.Text;
                error_message.Text = "";
            }
            else
            {
                error_message.Text = "Veuillez renseigner l'adresse mail du client.";
                formError = true;
            }
            if (phoneNumber_input.Text != "")
            {
                customer.phoneNumber = phoneNumber_input.Text;
                error_message.Text = "";
            }
            else
            {
                error_message.Text = "Veuillez renseigner le numétro de téléphone du client.";
                formError = true;
            }
            if (!formError)
            {
                try
                {
                    db.SaveChanges();
                    MainWindow main = Application.Current.MainWindow as MainWindow;
                    ListBroker ListBrokerPage = new ListBroker();
                    main.MainFrame.Navigate(ListBrokerPage);
                }
                catch (DbEntityValidationException)
                {
                    error_message.Text = "Le client n'a pas pu être modifié";
                }
            }
        }

        private void Abort_Button(object sender, RoutedEventArgs e)
        {
            MainWindow main = Application.Current.MainWindow as MainWindow;
            ListCustomer ListCustomerPage = new ListCustomer();
            main.MainFrame.Navigate(ListCustomerPage);
        }
    }
}
