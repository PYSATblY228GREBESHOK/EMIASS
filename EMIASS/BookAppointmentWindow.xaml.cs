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
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace EMIASS
{
    public partial class BookAppointmentWindow : Window
    {
        private MainWindow _mainWindow;

        public BookAppointmentWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void BookTime_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string time = button.Content.ToString();

            StackPanel parentPanel = button.Parent as StackPanel;
            StackPanel grandParentPanel = parentPanel.Parent as StackPanel;
            TextBlock doctorTextBlock = grandParentPanel.Children[0] as TextBlock;
            string doctor = doctorTextBlock.Text;

            _mainWindow.AddAppointment(new Appointment { Doctor = doctor, Time = time });
            this.Close();
        }
    }
}




