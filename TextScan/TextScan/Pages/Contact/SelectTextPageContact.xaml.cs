using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using TextScan.Pages.Contact;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace TextScan.Pages.Contact
{
    public sealed partial class SelectTextPageContact : Page
    {
        String name;
        String number;
        String mail;

        public SelectTextPageContact()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ScanResult.Text = Convert.ToString(e.Parameter);
        }

        private void ClickBack(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChoosePageContact));
        }

        private void ClickContinue(object sender, RoutedEventArgs e)
        {
            String result = name + "^" + number + "^" + mail;
            Frame.Navigate(typeof(ResultPageContact), result);
        }

        private void ClickName(object sender, RoutedEventArgs e)
        {
            name = ScanResult.SelectedText;
            Regex pattern = new Regex(@"(\d{4})(-\d{3})(-\d{2})(-\d{2})");
            Regex pattern1 = new Regex(@"(\w+)(@\w+)(.\w+)");
            var mas = ScanResult.Text.Split(new char[] { ' ' });
            for (int i = 0; i < mas.Length; i++)
            {
                if (pattern.IsMatch(mas[i]) == true)
                {
                    number = mas[i];
                }
                if (pattern1.IsMatch(mas[i]) == true)
                {
                    mail = mas[i];
                }
            }
        }

        private void ScanResult_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
