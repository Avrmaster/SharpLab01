using System.Windows;

//Unused usings

namespace LeskivSharp01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Listens events from MainWindow Calendar and appropriately changes fields shown to users
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new BirthdayViewModel();
        }
        //Not MVVM. Moved to ViewModel
    }
}
