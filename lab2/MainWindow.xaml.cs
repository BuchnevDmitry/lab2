using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab2_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void OpenButton_click(object sender, RoutedEventArgs e)
        {
            animalPopup.IsOpen = true;
        }

        private void CloseButton_click(object sender, RoutedEventArgs e)
        {
            animalPopup.IsOpen = false;
        }


    }
}