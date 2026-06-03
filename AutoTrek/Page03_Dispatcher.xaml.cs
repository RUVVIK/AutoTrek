using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AutoTrek
{
    public partial class Page03_Dispatcher : Page
    {
        public class Record
        {
            public int Id { get; set; }
            public string Date { get; set; }
            public string Plate { get; set; }
            public string Type { get; set; }
            public string Value { get; set; }
            public string Status { get; set; }
        }

        public ObservableCollection<Record> Records { get; set; }

        public Page03_Dispatcher()
        {
            InitializeComponent();
            DataContext = this;
            Records = new ObservableCollection<Record>
            {
                new Record { Id = 1, Date = "30.03.2026", Plate = "А123СМ 31", Type = "Путевой", Value = "220 км", Status = "Выполнено" },
                new Record { Id = 2, Date = "20.03.2026", Plate = "А123СМ 13", Type = "Заправка", Value = "65.5 л", Status = "Отказ" },
                new Record { Id = 3, Date = "28.10.2026", Plate = "А123СМ 31", Type = "Путевой", Value = "185 км", Status = "Выполнено" }
            };
        }

        private void BtnExit_Click(object s, RoutedEventArgs e) => MainWindow.Navigate(new Page01_Login());
        private void Nav_Click(object s, RoutedEventArgs e)
        {
            if (s is Button b && b.Tag is string t)
            {
                var type = Type.GetType($"AutoTrek.{t}");
                if (type != null) MainWindow.Navigate((Page)Activator.CreateInstance(type));
            }
        }
    }
}