using System;
using System.Linq;
using System.Text.RegularExpressions;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Globalization;

namespace TextScan
{
    public sealed partial class SelectTextPageCosts : Page
    {
        String date;
        String total;

        public SelectTextPageCosts()
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
            float ftotal = Convert.ToSingle(total, new CultureInfo("en-US"));
            DateTime dt = DateTime.ParseExact(date, "dd.MM.yy HH:mm", CultureInfo.InvariantCulture);
            var db = new MobileContext();
            db.Costs.Add(new Costs { Total = ftotal, Date = dt });
            db.SaveChanges();
            var list = db.Costs.ToList();
            Frame.Navigate(typeof(ResultPageCosts));
        }

        private void ClickTotal(object sender, RoutedEventArgs e)
        {
            total = ScanResult.SelectedText;
            Regex pattern = new Regex(@"\d{2,2}\.\d{2,2}\.\d{2,2}");
            var mas = ScanResult.Text.Split(new char[] { ' ' });
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (pattern.IsMatch(mas[i]) == true)
                {
                    date = mas[i] + ' ' + mas[i+1];
                }
            }
        }
    }
}

