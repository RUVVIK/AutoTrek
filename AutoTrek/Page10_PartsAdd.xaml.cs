using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AutoTrek
{
    // Класс данных (ОБЪЯВЛЯЕМ ОТДЕЛЬНО ОТ СТРАНИЦЫ)
    public class CatalogPart
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public string Unit { get; set; }
        public string Price { get; set; }
        public string Sum { get; set; }
    }

    public partial class Page10_PartsAdd : Page
    {
        public ObservableCollection<CatalogPart> PartsList { get; set; }

        public Page10_PartsAdd()
        {
            InitializeComponent();
            DataContext = this;

            // Инициализация данных
            PartsList = new ObservableCollection<CatalogPart>
            {
                new CatalogPart { Id = 1, Article = "BR-1024", Name = "Колодки тормозные перед/зад", Qty = 4, Unit = "шт", Price = "1 200", Sum = "4 800" },
                new CatalogPart { Id = 2, Article = "FL-201", Name = "Фильтр масляный", Qty = 2, Unit = "шт", Price = "450", Sum = "900" },
                new CatalogPart { Id = 3, Article = "OIL-5W40", Name = "Масло моторное 5W-40 (канистра)", Qty = 10, Unit = "л", Price = "650", Sum = "6 500" }
            };
        }

        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void BtnClose_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page07_Mechanic());
    }
}