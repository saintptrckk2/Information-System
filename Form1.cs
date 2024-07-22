namespace admin
{
    using System.Data.SqlClient;
    using System.Data;
    using System.Security.Cryptography;
    using System.Text;

    public partial class loginForm : Form
    {
        Form2 mainForm = new Form2();
        
        public loginForm()
        {
            InitializeComponent();
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            userTextBox.MaxLength = 11;
        }

        private void pwTextBox_TextChanged(object sender, EventArgs e)
        {
            pwTextBox.MaxLength = 11;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            pwTextBox.UseSystemPasswordChar = !pwTextBox.UseSystemPasswordChar;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            validateLogin();
        }

        private void validateLogin()
        {
            string username = userTextBox.Text;
            string password = pwTextBox.Text;

            if(AuthenticateAdmin(username, password))
            {
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Admin User!");
            }
        }
        
        private bool AuthenticateAdmin(string username, string password)
        {
            string connectionString = "Data Source=DESKTOP-AN3VUIS\\SQLEXPRESS;Initial Catalog=Baluarte;Integrated Security=SSPI;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Password FROM Admins WHERE Username = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    string storedPassword = command.ExecuteScalar() as string;
                    if (storedPassword != null)
                    {
                        return password == storedPassword;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
       
    }
}
