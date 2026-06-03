using AutoTrek;
using System.Windows;
using System.Windows.Controls;
namespace AutoTrek
{
    public partial class Page01_Login : Page
    {
        public Page01_Login() => InitializeComponent();
        private void BtnLogin_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page02_Roles());
    }
}