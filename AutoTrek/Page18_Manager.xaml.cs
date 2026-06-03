using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AutoTrek
{
    public partial class Page18_Manager : Page
    {
        public class Top5Row
        {
            public int Number { get; set; }
            public string Plate { get; set; }
            public string Model { get; set; }
            public string Cost { get; set; }
            public string PerKm { get; set; }
            public string Deviation { get; set; }
        }

        public ObservableCollection<Top5Row> Top5Table { get; set; }

        public Page18_Manager()
        {
            InitializeComponent();
            DataContext = this;

            // Данные ТОП-5
            Top5Table = new ObservableCollection<Top5Row>
            {
                new Top5Row { Number = 1, Plate = "Е345КХ77", Model = "ЛИАЗ 5292", Cost = "245 600", PerKm = "58.3", Deviation = "+8.2%" },
                new Top5Row { Number = 2, Plate = "А123ВС77", Model = "ПАЗ Vector Next", Cost = "187 300", PerKm = "44.5", Deviation = "+1.5%" },
                new Top5Row { Number = 3, Plate = "0456МР77", Model = "ПАЗ Vector Next", Cost = "165 400", PerKm = "42.1", Deviation = "-0.8%" },
                new Top5Row { Number = 4, Plate = "В234СТ77", Model = "ГАЗель NEXT", Cost = "158 900", PerKm = "39.2", Deviation = "+4.3%" },
                new Top5Row { Number = 5, Plate = "М567НВ77", Model = "ГАЗель NEXT", Cost = "156 800", PerKm = "38.9", Deviation = "+3.7%" }
            };
        }

        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnApprove_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page19_PlanFact());
        private void BtnDetails_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page19_PlanFact());
    }
}