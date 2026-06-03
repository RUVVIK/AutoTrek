using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AutoTrek
{
    public partial class Page09_PartsRequest : Page
    {
        public class PartItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Qty { get; set; }
            public string Unit { get; set; }
            public string Price { get; set; }
            public string Total { get; set; }
        }

        public ObservableCollection<PartItem> Parts { get; set; }

        public Page09_PartsRequest()
        {
            InitializeComponent();
            DataContext = this;

            // Заполняем таблицу данными из Figma
            Parts = new ObservableCollection<PartItem>
            {
                new PartItem { Id = 1, Name = "Колодки тормозные\nпередние", Qty = 2, Unit = "шт", Price = "1 500", Total = "3 000" },
                new PartItem { Id = 2, Name = "Колодки тормозные\nзадние", Qty = 2, Unit = "шт", Price = "1 300", Total = "2 600" },
                new PartItem { Id = 3, Name = "Смазка высокотемп.", Qty = 1, Unit = "уп", Price = "350", Total = "350" }
            };
        }

        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page07_Mechanic());
        private void BtnAddPart_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page10_PartsAdd());
    }
}