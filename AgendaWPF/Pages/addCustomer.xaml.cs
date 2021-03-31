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
    /// Logique d'interaction pour addCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Page
    {
        private AgendaContext db = new AgendaContext();
        public AddCustomer()
        {
            InitializeComponent();
            var brokersList = db.af458_brokers.ToList();
            brokers_list.ItemsSource = brokersList;
        }

        private void Button_Validation(object sender, RoutedEventArgs e)
        {
            bool formError = false;
            af458_customers customer = new af458_customers();
            if (lastname_input.Text != "")
            {
                customer.lastname = lastname_input.Text;
                lastname_error.Text = "";
            }
            else
            {
                lastname_error.Text = "Veuillez renseigner le nom du client.";
                formError = true;
            }
            if (firstname_input.Text != "")
            {
                customer.firstname = firstname_input.Text;
                firstname_error.Text = "";
            }
            else
            {
                firstname_error.Text = "Veuillez renseigner le prénom du client.";
                formError = true;
            }
            if (mail_input.Text != "")
            {
                customer.mail = mail_input.Text;
                mail_error.Text = "";
            }
            else
            {
                mail_error.Text = "Veuillez renseigner l'adresse mail du client.";
                formError = true;
            }
            if (phoneNumber_input.Text != "")
            {
                customer.phoneNumber = phoneNumber_input.Text;
                phoneNumber_error.Text = "";
            }
            else
            {
                phoneNumber_error.Text = "Veuillez renseigner le numétro de téléphone du client.";
                formError = true;
            }
            if (budget_input.Text != "")
            {
                bool convert = Int32.TryParse(budget_input.Text, out int intBudget);
                if (convert)
                {
                    customer.budget = intBudget;
                    budget_error.Text = "";
                }
                else
                {
                    budget_error.Text = "Veuillez renseigner le budget du client de façon correcte.";
                    formError = true;
                }
            }
            else
            {
                budget_error.Text = "Veuillez renseigner le budget du client.";
                formError = true;
            }
            af458_brokers broker = (af458_brokers)brokers_list.SelectedItem;
            if (broker != null)
            {
                customer.id_af458_brokers = broker.id;
                broker_error.Text = "";
            }
            else
            {
                broker_error.Text = "Veuillez renseigner le courtier du client.";
                formError = true;
            }
            if (!formError)
            {
                try
                {
                    db.af458_customers.Add(customer);
                    db.SaveChanges();
                    query_message.Foreground = Brushes.Green;
                    query_message.Text = "L'enregistrement a bien été effectué.";
                }
                catch (DbEntityValidationException)
                {
                    query_message.Foreground = Brushes.Red;
                    query_message.Text = "L'enregistrement n'a pas pu être effectué. (1)";
                }
                catch (DbUpdateException)
                {
                    query_message.Foreground = Brushes.Red;
                    query_message.Text = "L'enregistrement n'a pas pu être effectué. (2)";
                }
            }
            else
            {
                query_message.Foreground = Brushes.Red;
                query_message.Text = "L'enregistrement n'a pas pu être effectué, des erreurs dans le formulaire sont présentes.";
            }
        }
        private void Button_Abort(object sender, RoutedEventArgs e)
        {
            MainWindow main = Application.Current.MainWindow as MainWindow;
            ListCustomer listCustomerPage = new ListCustomer();
            main.MainFrame.Navigate(listCustomerPage);
        }
    }
}
