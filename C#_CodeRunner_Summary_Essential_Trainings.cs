using System;
using System.Windows;

namespace CodeRunner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunCode(object sender, RoutedEventArgs e)
        {
            /********************************************/
			/*Date and Time */
			
			DateTime dt = new DateTime(1991, 02, 20, 21, 45, 13);
            Output("Date and Time is " + dt.ToString("d.M.yyyy"));
            Output("Date and Time is " + dt.ToString("MMMM, d yyyy hh:mm:ss"));

            DateTime now = DateTime.Now;
            Output("Now is " + now.ToString("MMMM, d yyyy"));
            Output("Now is " + now.ToString("M/d/yyyy hh:mm:ss"));

            DateTime anotherDate = dt.AddYears(-1);
            anotherDate = anotherDate.AddMonths(2);
            anotherDate = anotherDate.AddMinutes(16);
            Output("Another date is " + anotherDate.ToString("MMMM, d yyyy hh:mm:ss"));
			
            /********************************************/
			/*Date and Time */

				

        }

        private void Output(string value)
        {
            txtOutput.Text += value + Environment.NewLine;
        }

        private void ClearOutput(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
        }
    }
}
