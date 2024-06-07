using System.Text;
using System.Windows;
using kabalangay_project.Views;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kabalangay_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadHomeView();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            LoadHomeView();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            LoadAboutView();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            LoadRegisterView();
        }

        private void LoadHomeView()
        {
            MainContentControl.Content = new HomeView();
        }
        private void LoadAboutView()
        {
            MainContentControl.Content = new AboutView();
        }
        private void LoadRegisterView()
        {
            MainContentControl.Content = new RegisterView();
        }
    }
}