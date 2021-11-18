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

namespace loginscreen
{
    /// <summary>
    /// Interaction logic for MoviesGenreScreen.xaml
    /// </summary>
    public partial class MoviesGenreScreen : Window
    {
        
        public MoviesGenreScreen()
        {
            InitializeComponent();
           

        }
        private void migtukas_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FilmuBaze_Click(object sender, RoutedEventArgs e)
        {

            FilmuBaze filmuBaze = new FilmuBaze();
            filmuBaze.Show();
        }

        private void SutikimasDelSLapuku_Click(object sender, RoutedEventArgs e)
        {
            if (User_Name.Text == String.Empty)
            {
                MessageBox.Show("Write Your Username!", "MY BOX");
            }
            if (Check.IsChecked != true)
            {
                MessageBox.Show("Please, Confirm that you are not a robot!", "MY BOX");
            }
            else
            {
                Vardas.Text = User_Name.Text;
            }

        }
        private bool IsTrue()
        {
            if (User_Name.Text == String.Empty)
            {
                return false;
            }
            if (Vardas.Text != User_Name.Text)
            {
                return false;
            } 
            return true;
        }

        private void migtukas_Click2(object sender, RoutedEventArgs e)
        {
           
            if(IsTrue())
            {
                DramaFilms dramaFilms = new DramaFilms();
                dramaFilms.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Accept the cookies first!", "MY BOX", MessageBoxButton.YesNoCancel);
            }
        }
        private void migtukas3_Click(object sender, RoutedEventArgs e)
        {
            if (IsTrue())
            {
                ComedyFilms comedyFilms = new ComedyFilms();
                comedyFilms.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Accept the cookies first!", "MY BOX");
            }
        }

        private void migtukas5_Click(object sender, RoutedEventArgs e)
        {
            if (IsTrue())
            {
                HorrorFilms horrorFilms = new HorrorFilms();
                horrorFilms.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Accept the cookies first!", "MY BOX");
            }
        }

        private void migtukas4_Click(object sender, RoutedEventArgs e)
        {
            if (IsTrue())
            {
                ActionMovies actionMovies = new ActionMovies();
                actionMovies.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Accept the cookies first!", "MY BOX");
            }
        }

        private void lOGOUT_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
            
        }

        //private void Pirmasis_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    if (!IsDouble(Pirmas.Text + e.Text))
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void Antrasis_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    if (!IsDouble(Antras.Text + e.Text))
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void Treciasis_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    if (!IsDouble(Trecias.Text + e.Text))
        //    {
        //        e.Handled = true;
        //    }


        //    //private void migtukas_Click(object sender, RoutedEventArgs e)
        //    //{

        //    //    usearnameas.Text = Usernameas.ToString();

        //    //}
        //}
    }
}
