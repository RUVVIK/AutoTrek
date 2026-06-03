using System.Windows;
using System.Windows.Controls;
namespace AutoTrek
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Page01_Login());
        }
        public static void Navigate(Page page)
        {
            if (Application.Current.MainWindow is MainWindow mw)
                mw.MainFrame.Navigate(page);
        }
    }
}