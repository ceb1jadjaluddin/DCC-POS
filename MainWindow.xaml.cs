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

namespace DCC_POS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Order screen coming soon!");
            POSScreen secondScreen = new POSScreen();
            secondScreen.Show();
            this.Close();
        }

        // For the TextBox GotFocus
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text == "Username")
            {
                UsernameTextBox.Text = ""; // Clear the placeholder text
                UsernameTextBox.Foreground = new SolidColorBrush(Colors.Black); // Change text color to black
            }
        }

        // For the TextBox LostFocus
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                UsernameTextBox.Text = "Username"; // Set placeholder text if no input
                UsernameTextBox.Foreground = new SolidColorBrush(Colors.Gray); // Change text color to gray
            }
        }

        // For the PasswordBox GotFocus
        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "Enter Password")
            {
                PasswordBox.Password = ""; // Clear the placeholder text
                PasswordBox.Foreground = new SolidColorBrush(Colors.Black); // Change text color to black
            }
        }

        // For the PasswordBox LostFocus
        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                PasswordBox.Password = "Enter Password"; // Set placeholder text if no input
                PasswordBox.Foreground = new SolidColorBrush(Colors.Gray); // Change text color to gray
            }
        }

    }
}