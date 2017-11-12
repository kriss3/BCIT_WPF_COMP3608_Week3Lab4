using System.Windows;
using System.Windows.Controls;

namespace BCIT_WPF_COMP3608_Week3Lab4
{
    /// <summary>
    /// Interaction logic for RoutedEvents.xaml
    /// Krzysztof Szczurowski
    /// Repo address: https://github.com/kriss3/BCIT_WPF_COMP3608_Week3Lab4.git
    /// </summary>
    public partial class RoutedEvents : Window
    {
        public RoutedEvents()
        {
            InitializeComponent();
        }

        private void TxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by Textbox", "Event Message", MessageBoxButton.OK, MessageBoxImage.Information);
            e.Handled = (bool)rb_ForTextBox.IsChecked;
        }

        private void Grid_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by Grid", "Event Message", MessageBoxButton.OK, MessageBoxImage.Information);
            e.Handled = (bool)rb_ForGrid.IsChecked;
        }

        private void Window_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event raised by Window", "Event Message", MessageBoxButton.OK, MessageBoxImage.Information);
            e.Handled = (bool)rb_ForWindow.IsChecked;
        }
    }
}
