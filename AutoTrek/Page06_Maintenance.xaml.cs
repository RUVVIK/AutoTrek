using System.Windows;
using System.Windows.Controls;
namespace AutoTrek
{
    public partial class Page06_Maintenance : Page
    {
        public Page06_Maintenance() => InitializeComponent();
        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page03_Dispatcher());
    }
}