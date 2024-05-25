using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace kabalangay_project.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement your login logic here.
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (username == "admin" && password == "password") // Sample login check
            {
                // If login is successful, open the MainWindow
                MainWindow mainWindow = new MainWindow();
                Application.Current.MainWindow = mainWindow;
                mainWindow.Show();

                // Close the login window
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }


}
