using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AutoTrek
{
    public partial class Page14_CostReport : Page
    {
        public class CostRow
        {
            public string Name { get; set; }
            public string Sum { get; set; }
            public string Percent { get; set; }
            public double BarWidth { get; set; }
        }

        public ObservableCollection<CostRow> CostTable { get; set; }

        public Page14_CostReport()
        {
            InitializeComponent();
            DataContext = this;

            CostTable = new ObservableCollection<CostRow>
            {
                new CostRow { Name = "ГСМ", Sum = "654 000", Percent = "52.5%", BarWidth = 95 },
                new CostRow { Name = "ТО и ремонты", Sum = "423 000", Percent = "34.0%", BarWidth = 61 },
                new CostRow { Name = "Мойка и уборка", Sum = "78 500", Percent = "6.3%", BarWidth = 11 },
                new CostRow { Name = "Страхование", Sum = "56 280", Percent = "4.5%", BarWidth = 8 },
                new CostRow { Name = "Сезонное обслуживание", Sum = "24 000", Percent = "1.9%", BarWidth = 3 },
                new CostRow { Name = "Прочие расходы", Sum = "10 000", Percent = "0.8%", BarWidth = 1 }
            };
        }

        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page13_Accountant());
    }
}