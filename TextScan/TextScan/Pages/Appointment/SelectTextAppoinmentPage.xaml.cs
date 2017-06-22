using System;
using System.Text.RegularExpressions;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TextScan
{
    public sealed partial class SelectTextAppoinmentPage : Page
    {
        String date;
        String subject;
        String time;
        String details = "";

        public SelectTextAppoinmentPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           ScanResult.Text = Convert.ToString(e.Parameter);
        }

        private void ClickBack(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChoosePageAppointment));
        }

        private void ClickContinue(object sender, RoutedEventArgs e)
        {
            String result = date + "^" + time + "^" + subject + "^" + details;;
            Frame.Navigate(typeof(ResultPageAppoinment), result);
        }
        
        private void ClickSubject(object sender, RoutedEventArgs e)
        {
            subject = ScanResult.SelectedText;
            Regex pattern = new Regex(@"\d{2,2}\.\d{2,2}\.\d{4,4}");
            Regex pattern1 = new Regex(@"\d{2,2}\:\d{2,2}");
            var mas = ScanResult.Text.Split(new char[] { ' ' });
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (pattern.IsMatch(mas[i])==true)
                {
                    date = mas[i];
                }
                if (pattern1.IsMatch(mas[i]) == true)
                {
                    time = mas[i];
                }
            }
            details = ScanResult.Text;
        }
    }
}
