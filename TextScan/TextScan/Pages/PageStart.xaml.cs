using TextScan.Pages.Contact;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TextScan.Pages
{
    public sealed partial class PageStart : Page
    {
        public PageStart()
        {
            this.InitializeComponent();
        }

        private void ClickCosts(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChoosePageCosts));
        }

        private void ClickContact(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChoosePageContact));
        }

        private void ClickAppointment(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChoosePageAppointment));
        }
    }
}
