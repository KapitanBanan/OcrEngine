using TextScan.Pages;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TextScan
{
    public sealed partial class ResultPageCosts : Page
    {
        public ResultPageCosts()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PageStart));
        }
    }
}
