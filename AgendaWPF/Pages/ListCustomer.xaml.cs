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
    /// Logique d'interaction pour ListCustomer.xaml
    /// </summary>
    public partial class ListCustomer : Page
    {
        private AgendaContext db = new AgendaContext();
        public ListCustomer()
        {
            InitializeComponent();
            var customers = db.af458_customers.ToList();
            dgCustomers.ItemsSource = customers;

        }

        private void dgCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            af458_customers customer = (af458_customers)dgCustomers.SelectedItem;
            lastname_input.Text = customer.lastname;
            firstname_input.Text = customer.firstname;
            mail_input.Text = customer.mail;
            phoneNumber_input.Text = customer.phoneNumber;
            budget_input.Text = Convert.ToString(customer.budget);
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            af458_customers customer = (af458_customers)dgCustomers.SelectedItem;
            af458_customers af458_customers = db.af458_customers.Find(customer.id);
            try
            {
                db.af458_customers.Remove(af458_customers);
                db.SaveChanges();
                MainWindow main = Application.Current.MainWindow as MainWindow;
                ListCustomer listCustomerPage = new ListCustomer();
                main.MainFrame.Navigate(listCustomerPage);
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
            af458_customers customerToEdit = (af458_customers)dgCustomers.SelectedItem;
            af458_customers customer = db.af458_customers.Find(customerToEdit.id);
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
            if (budget_input.Text != "")
            {
                bool convert = Int32.TryParse(budget_input.Text, out int intBudget);
                if (convert)
                {
                    customer.budget = intBudget;
                    error_message.Text = "";
                }
                else
                {
                    error_message.Text = "Veuillez renseigner le budget du client de façon correcte.";
                    formError = true;
                }
            }
            else
            {
                error_message.Text = "Veuillez renseigner le budget du client.";
                formError = true;
            }
            if (!formError)
            {
                try
                {
                    db.SaveChanges();
                    MainWindow main = Application.Current.MainWindow as MainWindow;
                    ListCustomer listCustomerPage = new ListCustomer();
                    main.MainFrame.Navigate(listCustomerPage);
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
            ListCustomer listCustomerPage = new ListCustomer();
            main.MainFrame.Navigate(listCustomerPage);
        }
    }
}
