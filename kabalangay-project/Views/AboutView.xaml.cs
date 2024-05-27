using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace kabalangay_project.Views
{
    public partial class AboutView : UserControl
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void OfficialsButton_Click(object sender, RoutedEventArgs e)
        {
            // Update the display text when Officials button is clicked
            DisplayText.Text = "Information about officials";
        }

        private void PersonnelButton_Click(object sender, RoutedEventArgs e)
        {
            // Update the display text when Personnel button is clicked
            DisplayText.Text = "Information about personnel";
        }

        private void ZoneButton_Click(object sender, RoutedEventArgs e)
        {
            // Update the display text when Zone button is clicked
            DisplayText.Text = "Information about zones";
        }

    }
}
