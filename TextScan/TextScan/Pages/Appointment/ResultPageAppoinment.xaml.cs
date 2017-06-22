using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using TextScan.Pages;
using Windows.ApplicationModel.Appointments;

namespace TextScan
{
    public sealed partial class ResultPageAppoinment : Page
    {
        string startTime;
        string subject;
        string details;
        int year;
        int month;
        int day;
        int hours;
        int min;

        public ResultPageAppoinment()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string result = Convert.ToString(e.Parameter);
            var res = result.Split(new char[] { '^' });
            DateText.Text = res[0] + " " + res[1];
            SubjectText.Text = res[2];
            DetailsText.Text = res[3];
            startTime = res[0];
            subject = res[1];
            details = res[2];
            var dateTime = res[0].Split(new char[] { '.' });
            var timeDate = res[1].Split(new char[] { ':' });
            year = Convert.ToInt16(dateTime[2]);
            month = Convert.ToInt16(dateTime[1]);
            day = Convert.ToInt16(dateTime[0]);
            hours = Convert.ToInt16(timeDate[0]);
            min = Convert.ToInt16(timeDate[1]);
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SelectTextAppoinmentPage));
        }

        private async void DoneClick(object sender, RoutedEventArgs e)
        {
            var appointment = new Appointment();
            var timeZoneOffset = TimeZoneInfo.Local.GetUtcOffset(DateTime.Now);

            appointment.StartTime = new DateTimeOffset(year, month, day, hours, min, 0, timeZoneOffset);
            appointment.Subject = subject;
            appointment.Details = details;
            var rect = new Rect();
            string appointmentId = await 
                AppointmentManager.ShowAddAppointmentAsync(appointment, rect, Windows.UI.Popups.Placement.Default);
            Frame.Navigate(typeof(PageStart));
        }

        private object GetElementRect(FrameworkElement frameworkElement)
        {
            throw new NotImplementedException();
        }
    }
}
