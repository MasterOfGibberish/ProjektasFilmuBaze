using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace loginscreen
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source =DESKTOP-FGIOSI5\SQLEXPRESS; Initial Catalog = LoginDB; Integrated Security=true");
            try
            {
                if(sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                String query = " SELECT COUNT(1) From Login_Table WHERE UserName=@UserName AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", Usernameas.Text);
                cmd.Parameters.AddWithValue("@Password", Passwordas.Password);
                int cout = Convert.ToInt32(cmd.ExecuteScalar()); 
                if(cout >= 1)
                {
                    MoviesGenreScreen moviegenreScreen = new MoviesGenreScreen();
                    moviegenreScreen.Show();
                    this.Close();
                    moviegenreScreen.Focus();
                    MessageBox.Show(Usernameas.Text,"Welcome");
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect", "MY BOX");
                    Passwordas.Clear();
                    Usernameas.Clear();
                  
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
