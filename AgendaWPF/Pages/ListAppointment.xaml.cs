using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace AgendaWPF.Pages
{
    /// <summary>
    /// Logique d'interaction pour ListAppointment.xaml
    /// </summary>
    public partial class ListAppointment : Page
    {
        private AgendaContext db = new AgendaContext();
        public ListAppointment()
        {
            InitializeComponent();
            var appointments = db.af458_appointments.ToList();
            dgAppointments.ItemsSource = appointments;
            var brokersList = db.af458_brokers.ToList();
            brokers_list.ItemsSource = brokersList;
            var customersList = db.af458_customers.ToList();
            customers_list.ItemsSource = customersList;

        }

        private void dgAppointments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            af458_appointments appointment = (af458_appointments)dgAppointments.SelectedItem;
            date_input.DisplayDate = appointment.dateHour;
            subject_input.Text = appointment.subject;
            hour_input.Text = Convert.ToString(appointment.dateHour.Hour);
            minute_input.Text = Convert.ToString(appointment.dateHour.Minute);
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            af458_appointments appointment = (af458_appointments)dgAppointments.SelectedItem;
            af458_appointments af458_appointments = db.af458_appointments.Find(appointment.id);
            try
            {
                db.af458_appointments.Remove(af458_appointments);
                db.SaveChanges();
                MainWindow main = Application.Current.MainWindow as MainWindow;
                ListAppointment ListAppointmentPage = new ListAppointment();
                main.MainFrame.Navigate(ListAppointmentPage);
                error_message.Text = "Le rendez-vous a bien été supprimé";
            }
            catch (DbEntityValidationException)
            {
                error_message.Text = "Le rendez-vous n'a pas pu être supprimé";
            }
        }

        private void Edit_Button(object sender, RoutedEventArgs e)
        {
            bool formError = false;
            error_message.Text = "";
            af458_appointments appointmentToEdit = (af458_appointments)dgAppointments.SelectedItem;
            af458_appointments appointment = db.af458_appointments.Find(appointmentToEdit.id);
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
                                error_message.Text = "Les minutes du rendez-vous n'est pas de la bonne forme";
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
                        error_message.Text = "L'heure du rendez-vous n'est pas de la bonne forme";
                        formError = true;
                    }
                }
                else
                {
                    error_message.Text = "Veuillez renseigner l'heure du rendez-vous.";
                    formError = true;
                }
            }
            //else
            //{
            //    error_message.Text = "Veuillez renseigner la date du rendez-vous.";
            //    formError = true;
            //}
            if (subject_input.Text != "")
            {
                appointment.subject = subject_input.Text;
            }
            else
            {
                error_message.Text = "Veuillez renseigner le sujet du rendez-vous.";
                formError = true;
            }
            af458_brokers broker = (af458_brokers)brokers_list.SelectedItem;
            if (broker != null)
            {
                appointment.id_af458_brokers = broker.id;
            }
            af458_customers customer = (af458_customers)customers_list.SelectedItem;
            if (customer != null)
            {
                appointment.id_af458_customers = customer.id;
            }
            if (!formError)
            {
                try
                {
                    db.SaveChanges();
                    MainWindow main = Application.Current.MainWindow as MainWindow;
                    ListAppointment ListAppointmentPage = new ListAppointment();
                    main.MainFrame.Navigate(ListAppointmentPage);
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
            ListAppointment ListAppointmentPage = new ListAppointment();
            main.MainFrame.Navigate(ListAppointmentPage);
        }
    }
}
