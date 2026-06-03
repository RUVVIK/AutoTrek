using System.Windows;
using System.Windows.Controls;
namespace AutoTrek
{
    public partial class Page12_ServiceGraph : Page
    {
        public Page12_ServiceGraph() => InitializeComponent();
        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page07_Mechanic());
    }
}