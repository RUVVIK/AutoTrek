using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AutoTrek
{
    public partial class Page15_PriceEdit : Page
    {
        public class FuelPrice
        {
            public string Type { get; set; }
            public string Supplier { get; set; }
            public string Price { get; set; }
            public string Date { get; set; }
            public string Status { get; set; }
        }

        public ObservableCollection<FuelPrice> FuelPrices { get; set; }

        public Page15_PriceEdit()
        {
            InitializeComponent();
            DataContext = this;

            // Данные строго по скриншоту Figma
            FuelPrices = new ObservableCollection<FuelPrice>
            {
                new FuelPrice { Type = "Дизель", Supplier = "Лукойл", Price = "62.50", Date = "15.02.2026", Status = "Активный" },
                new FuelPrice { Type = "Дизель", Supplier = "Газпром", Price = "61.80", Date = "10.02.2026", Status = "Активный" },
                new FuelPrice { Type = "Дизель", Supplier = "Роснефть", Price = "63.20", Date = "01.02.2026", Status = "Архивный" },
                new FuelPrice { Type = "АИ-92", Supplier = "Лукойл", Price = "54.30", Date = "15.02.2026", Status = "Активный" },
                new FuelPrice { Type = "АИ-92", Supplier = "Газпром", Price = "53.90", Date = "10.02.2026", Status = "Активный" },
                new FuelPrice { Type = "АИ-95", Supplier = "Лукойл", Price = "58.70", Date = "15.02.2026", Status = "Активный" }
            };
        }

        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page13_Accountant());
    }
}