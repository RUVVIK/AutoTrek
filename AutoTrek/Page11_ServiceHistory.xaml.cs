using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AutoTrek
{
    public partial class Page11_ServiceHistory : Page
    {
        public class ServiceRecord
        {
            public string Date { get; set; }
            public string Type { get; set; }
            public string Work { get; set; }
            public string Mileage { get; set; }
            public string Mechanic { get; set; }
            public string Cost { get; set; }
        }

        public ObservableCollection<ServiceRecord> History { get; set; }

        public Page11_ServiceHistory()
        {
            InitializeComponent();
            DataContext = this;

            // ВСЕ 7 ЗАПИСЕЙ КАК НА FIGMA
            History = new ObservableCollection<ServiceRecord>
            {
                new ServiceRecord { Date = "15.02.2026", Type = "Ремонт", Work = "Замена торм. колодок", Mileage = "186 500", Mechanic = "Смирнов", Cost = "6 950.00" },
                new ServiceRecord { Date = "10.02.2026", Type = "ТО-1", Work = "Замена масла/фильтров", Mileage = "185 200", Mechanic = "Смирнов", Cost = "8 500.00" },
                new ServiceRecord { Date = "28.01.2026", Type = "Ремонт", Work = "Замена стартера", Mileage = "182 500", Mechanic = "Кузнецов", Cost = "5 200.00" },
                new ServiceRecord { Date = "15.01.2026", Type = "ТО-0", Work = "Предсезонное ТО", Mileage = "179 800", Mechanic = "Смирнов", Cost = "3 200.00" },
                new ServiceRecord { Date = "25.12.2025", Type = "ТО-2", Work = "Полное ТО", Mileage = "175 200", Mechanic = "Иванов", Cost = "12 300.00" },
                new ServiceRecord { Date = "10.11.2025", Type = "Ремонт", Work = "Замена генератора", Mileage = "168 500", Mechanic = "Кузнецов", Cost = "7 800.00" },
                new ServiceRecord { Date = "01.10.2025", Type = "ТО-1", Work = "Замена масла", Mileage = "162 000", Mechanic = "Смирнов", Cost = "7 500.00" }
            };
        }

        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page07_Mechanic());
        private void BtnMore_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page12_ServiceGraph());
    }
}