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
using System.Collections.ObjectModel;

namespace EMIASS
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Appointment> Appointments { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Appointments = new ObservableCollection<Appointment>();
            AppointmentsListView.ItemsSource = Appointments;
        }

        private void BookAppointment_Click(object sender, RoutedEventArgs e)
        {
            BookAppointmentWindow bookAppointmentWindow = new BookAppointmentWindow(this);
            bookAppointmentWindow.ShowDialog();
        }

        public void AddAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
        }
    }
}



