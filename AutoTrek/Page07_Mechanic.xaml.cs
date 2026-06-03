using System;
using System.Windows;
using System.Windows.Controls;
namespace AutoTrek
{
    public partial class Page07_Mechanic : Page
    {
        public Page07_Mechanic() => InitializeComponent();
        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void Nav_Click(object s, RoutedEventArgs e)
        {
            if (s is Button b && b.Tag is string t)
            {
                var type = Type.GetType($"AutoTrek.{t}");
                if (type != null) MainWindow.Navigate((Page)Activator.CreateInstance(type));
            }
        }
    }
}