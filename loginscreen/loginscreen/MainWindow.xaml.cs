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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace loginscreen
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

        private void Ijungiam(object sender, RoutedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            loginScreen.Focus();
            this.Close();
            this.Focus();
        }

       
        private void Prijungiam(object sender, RoutedEventArgs e)
        {
            SignUpScreen signUpScreen = new SignUpScreen();
            signUpScreen.Show();
            signUpScreen.Focus();
            this.Close();
            this.Focus();
        }

        private void Image_Click(object sender, RoutedEventArgs e)
        {
            PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/FilmuBaze.html", UriKind.Absolute);
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            MessageBox.Show("Pirmiausiai Uzsiregistruokite", "MY BOX");
        }
    }
}
