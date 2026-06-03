using System.Windows;
using System.Windows.Controls;

namespace AutoTrek
{
    public partial class Page16_Analytics : Page
    {
        public Page16_Analytics() => InitializeComponent();

        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page13_Accountant());
        private void BtnBack_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page13_Accountant());

        private void BtnApply_Click(object s, RoutedEventArgs e)
        {
            // Применение фильтра
        }

        private void BtnCompare_Click(object s, RoutedEventArgs e)
        {
            // Сравнение с парком
        }

        private void BtnRefresh_Click(object s, RoutedEventArgs e)
        {
            // Обновление данных
        }

        private void BtnDetails_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page17_AnalyticsDetails());
    }
}