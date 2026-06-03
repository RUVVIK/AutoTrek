using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AutoTrek
{
    public partial class Page17_AnalyticsDetails : Page
    {
        // Структура затрат
        public class StructureItem
        {
            public string Name { get; set; }
            public string Sum { get; set; }
            public string Percent { get; set; }
        }

        // Детальная таблица
        public class DetailedItem
        {
            public string Date { get; set; }
            public string Article { get; set; }
            public string Description { get; set; }
            public string Quantity { get; set; }
            public string Price { get; set; }
            public string Sum { get; set; }
            public string Note { get; set; }
        }

        // Сравнение
        public class ComparisonItem
        {
            public string Indicator { get; set; }
            public string ThisVehicle { get; set; }
            public string FleetAverage { get; set; }
            public string Deviation { get; set; }
            public string IndicatorText { get; set; }
            public Brush IndicatorColor { get; set; }
        }

        public ObservableCollection<StructureItem> StructureTable { get; set; }
        public ObservableCollection<DetailedItem> DetailedTable { get; set; }
        public ObservableCollection<ComparisonItem> ComparisonTable { get; set; }

        public Page17_AnalyticsDetails()
        {
            InitializeComponent();
            DataContext = this;

            // Структура затрат
            StructureTable = new ObservableCollection<StructureItem>
            {
                new StructureItem { Name = "ГСМ", Sum = "162 000", Percent = "55.0%" },
                new StructureItem { Name = "ТО и ремонты", Sum = "95 000", Percent = "32.3%" },
                new StructureItem { Name = "Мойка", Sum = "12 500", Percent = "4.2%" },
                new StructureItem { Name = "Страхование", Sum = "25 000", Percent = "8.5%" },
                new StructureItem { Name = "ИТОГО:", Sum = "294 500", Percent = "100%" }
            };

            // Детальная таблица расходов
            DetailedTable = new ObservableCollection<DetailedItem>
            {
                new DetailedItem { Date = "18.02.2026", Article = "ГСМ", Description = "Лукойл", Quantity = "65.0 л", Price = "62.50", Sum = "4 062.50", Note = "" },
                new DetailedItem { Date = "15.02.2026", Article = "Ремонт", Description = "Тормозные колодки", Quantity = "", Price = "", Sum = "6 950.00", Note = "запчасти +работа" },
                new DetailedItem { Date = "10.02.2026", Article = "ТО", Description = "ТО-1", Quantity = "", Price = "", Sum = "8 500.00", Note = "масло, фильтры" },
                new DetailedItem { Date = "05.02.2026", Article = "ГСМ", Description = "Газпром", Quantity = "60.0 л", Price = "61.80", Sum = "3 708.00", Note = "" },
                new DetailedItem { Date = "28.01.2026", Article = "Ремонт", Description = "Стартер", Quantity = "", Price = "", Sum = "5 200.00", Note = "" },
                new DetailedItem { Date = "20.01.2026", Article = "ГСМ", Description = "Лукойл", Quantity = "70.0 л", Price = "62.50", Sum = "4 375.00", Note = "" }
            };

            // Сравнение со средними показателями
            ComparisonTable = new ObservableCollection<ComparisonItem>
            {
                new ComparisonItem {
                    Indicator = "Стоимость 1 км, руб",
                    ThisVehicle = "6.52",
                    FleetAverage = "5.87",
                    Deviation = "+0.65",
                    IndicatorText = "выше",
                    IndicatorColor = Brushes.Red
                },
                new ComparisonItem {
                    Indicator = "Расход топлива, л/100км",
                    ThisVehicle = "23.8",
                    FleetAverage = "22.5 (норма)",
                    Deviation = "+1.3",
                    IndicatorText = "перерасход",
                    IndicatorColor = Brushes.Red
                },
                new ComparisonItem {
                    Indicator = "Затраты на ремонт/км",
                    ThisVehicle = "2.10",
                    FleetAverage = "1.85",
                    Deviation = "+0.25",
                    IndicatorText = "выше",
                    IndicatorColor = Brushes.Orange
                },
                new ComparisonItem {
                    Indicator = "Периодичность ТО, дни",
                    ThisVehicle = "45",
                    FleetAverage = "52",
                    Deviation = "-7",
                    IndicatorText = "чаще",
                    IndicatorColor = Brushes.Green
                }
            };
        }

        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page13_Accountant());
    }
}