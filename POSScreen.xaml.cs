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

namespace DCC_POS
{
    /// <summary>
    /// Interaction logic for POSScreen.xaml
    /// </summary>
    public partial class POSScreen : Window
    {
        public POSScreen()
        {
            InitializeComponent();
        }

        // Logout button click event handler
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle logout action, e.g., closing the current window and returning to login
            MessageBox.Show("Logging out...");
            this.Close();  // Closes the POS screen

            // Optionally, show the login window again (MainWindow)
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
        }

        // Handle Item Addition to the Order List
        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            // Assuming MenuList has selected items
            var selectedItem = MenuList.SelectedItem as ListBoxItem;
            if (selectedItem != null)
            {
                OrderList.Items.Add(selectedItem.Content);
                UpdateTotal();
            }
        }

        // Update Total Price Calculation
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (var item in OrderList.Items)
            {
                // Assuming each item has a price format like "ItemName - ₱Price"
                var price = item.ToString().Split('₱')[1];
                total += decimal.Parse(price);
            }
            TotalPrice.Text = $"Total: ₱{total:F2}";
        }

        // Handle Checkout
        private void CheckoutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Total amount: {TotalPrice.Text}\nProceeding to payment.");
        }

        // Handle Discount (Optional)
        private void ApplyDiscountButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Discount Applied!");
            // You can implement the discount logic here
        }

        // Cancel Current Order
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Clear();
            TotalPrice.Text = "Total: ₱0.00";
        }
    }
}
