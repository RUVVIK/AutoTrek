using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AutoTrek
{
    public partial class Page19_PlanFact : Page
    {
        public class PlanFactRow
        {
            public string Article { get; set; }
            public string Plan { get; set; }
            public string Fact { get; set; }
            public string Deviation { get; set; }
            public string Percent { get; set; }
        }

        public ObservableCollection<PlanFactRow> PlanFactTable { get; set; }

        public Page19_PlanFact()
        {
            InitializeComponent();
            DataContext = this;

            PlanFactTable = new ObservableCollection<PlanFactRow>
            {
                new PlanFactRow { Article = "ГСМ", Plan = "150 000", Fact = "162 000", Deviation = "+12 000", Percent = "108%" },
                new PlanFactRow { Article = "ТО и ремонты", Plan = "80 000", Fact = "95 000", Deviation = "+15 000", Percent = "119%" },
                new PlanFactRow { Article = "Мойка", Plan = "15 000", Fact = "12 500", Deviation = "-2 500", Percent = "83%" },
                new PlanFactRow { Article = "Страхование", Plan = "25 000", Fact = "25 000", Deviation = "0", Percent = "100%" },
                new PlanFactRow { Article = "ИТОГО:", Plan = "270 000", Fact = "294 500", Deviation = "+24 500", Percent = "109%" }
            };
        }

        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page18_Manager());
    }
}