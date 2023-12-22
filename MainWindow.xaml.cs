using System.Linq;
using System.Windows;
using WpfApp.Data;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private readonly Database dbContext; // Replace YourDbContext with your actual DbContext class

        public MainWindow()
        {
            InitializeComponent();
            dbContext = new Database(); // Initialize your DbContext
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string enteredUsername = txtUsername.Text; // Retrieve the entered username from TextBox
            string enteredPassword = txtPassword.Password; // Retrieve the entered password from TextBox

            var user = dbContext.Users.FirstOrDefault(u => u.UserName == enteredUsername && u.Password == enteredPassword);

            if (user != null)
            {
                MessageBox.Show("Login successful!");
                AuthWindow loggedInWindow = new AuthWindow(enteredUsername);
                loggedInWindow.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }

        private void txtUsername_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
