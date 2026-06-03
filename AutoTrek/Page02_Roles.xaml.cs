using System;
using System.Windows;
using System.Windows.Controls;
namespace AutoTrek
{
    public partial class Page02_Roles : Page
    {
        public Page02_Roles() => InitializeComponent();
        private void Role_Click(object s, RoutedEventArgs e)
        {
            if (s is Button b && b.Tag is string t)
            {
                var type = Type.GetType($"AutoTrek.{t}");
                if (type != null) MainWindow.Navigate((Page)Activator.CreateInstance(type));
            }
        }
    }
}