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
    /// Logique d'interaction pour addBroker.xaml
    /// </summary>
    public partial class addBroker : Page
    {
        private AgendaContext db = new AgendaContext();
        public addBroker()
        {
            InitializeComponent();
        }

        private void Button_Validation(object sender, RoutedEventArgs e)
        {
            bool formError = false;
            af458_brokers broker = new af458_brokers();
            if (lastname_input.Text != "")
            {
                broker.lastname = lastname_input.Text;
                lastname_error.Text = "";
            }
            else
            {
                lastname_error.Text = "Veuillez renseigner le nom du client.";
                formError = true;
            }
            if (firstname_input.Text != "")
            {
                broker.firstname = firstname_input.Text;
                firstname_error.Text = "";
            }
            else
            {
                firstname_error.Text = "Veuillez renseigner le prénom du client.";
                formError = true;
            }
            if (mail_input.Text != "")
            {
                broker.mail = mail_input.Text;
                mail_error.Text = "";
            }
            else
            {
                mail_error.Text = "Veuillez renseigner l'adresse mail du client.";
                formError = true;
            }
            if (phoneNumber_input.Text != "")
            {
                broker.phoneNumber = phoneNumber_input.Text;
                phoneNumber_error.Text = "";
            }
            else
            {
                phoneNumber_error.Text = "Veuillez renseigner le numétro de téléphone du client.";
                formError = true;
            }
            if (!formError)
            {
                try
                {
                    db.af458_brokers.Add(broker);
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
