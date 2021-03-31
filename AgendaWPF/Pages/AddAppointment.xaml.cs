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
using System.Text.RegularExpressions;

namespace AgendaWPF.Pages
{
    /// <summary>
    /// Logique d'interaction pour AddAppointment.xaml
    /// </summary>
    public partial class AddAppointment : Page
    {
        private AgendaContext db = new AgendaContext();
        public AddAppointment()
        {
            InitializeComponent();
            var brokersList = db.af458_brokers.ToList();
            brokers_list.ItemsSource = brokersList;

            var customersList = db.af458_customers.ToList();
            customers_list.ItemsSource = customersList;
        }

        private void Button_Validation(object sender, RoutedEventArgs e)
        {
            bool formError = false;
            hour_error.Text = "";
            subject_error.Text = "";
            broker_error.Text = "";
            customer_error.Text = "";
            af458_appointments appointment = new af458_appointments();
            if (date_input.SelectedDate != null)
            {
                DateTime date = (DateTime)date_input.SelectedDate;
                if (hour_input.Text != "")
                {
                    if (Regex.IsMatch(hour_input.Text, "^[0-1][0-9]|2[0-3]$"))
                    {
                        if (minute_input.Text != "")
                        {
                            if (Regex.IsMatch(minute_input.Text, "^[0-5][0-9]$"))
                            {
                                DateTime datehour = new DateTime(date.Year, date.Month, date.Day, Convert.ToInt32(hour_input.Text), Convert.ToInt32(minute_input.Text), 0);
                                appointment.dateHour = datehour;
                            }
                            else
                            {
                                hour_error.Text = "Les minutes du rendez-vous n'est pas de la bonne forme";
                                formError = true;
                            }
                        }
                        else
                        {
                            minute_input.Text = "00";
                            DateTime datehour = new DateTime(date.Year, date.Month, date.Day, Convert.ToInt32(hour_input.Text), Convert.ToInt32(minute_input.Text), 0);
                            appointment.dateHour = datehour;
                        }
                    }
                    else
                    {
                        hour_error.Text = "L'heure du rendez-vous n'est pas de la bonne forme";
                        formError = true;
                    }
                }
                else
                {
                    date_error.Text = "Veuillez renseigner l'heure du rendez-vous.";
                    formError = true;
                }
            }
            else
            {
                date_error.Text = "Veuillez renseigner la date du rendez-vous.";
                formError = true;
            }
            if (subject_input.Text != "")
            {
                appointment.subject = subject_input.Text;
                subject_error.Text = "";
            }
            else
            {
                subject_error.Text = "Veuillez renseigner le prénom du client.";
                formError = true;
            }
            af458_brokers broker = (af458_brokers)brokers_list.SelectedItem;
            if (broker != null)
            {
                appointment.id_af458_brokers = broker.id;
                broker_error.Text = "";
            }
            else
            {
                broker_error.Text = "Veuillez renseigner le courtier.";
                formError = true;
            }
            af458_customers customer = (af458_customers)customers_list.SelectedItem;
            if (customer != null)
            {
                appointment.id_af458_customers = customer.id;
                broker_error.Text = "";
            }
            else
            {
                broker_error.Text = "Veuillez renseigner le client.";
                formError = true;
            }
            if (!formError)
            {
                try
                {
                    db.af458_appointments.Add(appointment);
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
            ListAppointment listAppointmentPage = new ListAppointment();
            main.MainFrame.Navigate(listAppointmentPage);
        }
    }

}
