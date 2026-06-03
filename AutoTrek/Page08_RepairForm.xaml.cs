using System.Windows;
using System.Windows.Controls;
namespace AutoTrek
{
    public partial class Page08_RepairForm : Page
    {
        public Page08_RepairForm() => InitializeComponent();
        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page07_Mechanic());
    }
}