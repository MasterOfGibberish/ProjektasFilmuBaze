using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
    /// Interaction logic for DramaSelectScreen.xaml
    /// </summary>
    public partial class DramaSelectScreen : Window
    {
        public string[] names { get; set; }
        public string[] names2 { get; set; }
        public DramaSelectScreen()
        {
            InitializeComponent();
            names = new string[] { "Warner Bros. (Warner Bros. Pictures)", "20th Century Studios" };
            DataContext = this;
            names2 = new string[] { "1-3", "3-4.5", "4.5<" };
            DataContext = this;
        }

        private void migtukas1_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void FilmuBaze_Click(object sender, RoutedEventArgs e)
        {

           
            FilmuBaze filmubaze = new FilmuBaze();
            filmubaze.Show();
            MessageBox.Show("Welcome To FilmuBaze.lt", "MY BOX");

        }

        private void migtukas1_Click_1(object sender, RoutedEventArgs e)
        {
            MoviesGenreScreen moviesGenreScreen = new MoviesGenreScreen();
            moviesGenreScreen.Show();
            this.Close();
        }

        private void DramaFilmsButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = (@"Data Source =DESKTOP-FGIOSI5\SQLEXPRESS; Initial Catalog = FilmuDB; Integrated Security=true");

            if (!IsTrue())
            {
                using (SqlConnection horrorMovieCon = new SqlConnection(connectionString))
                {
                    horrorMovieCon.Open();
                    if (Subtitrai.IsChecked == false)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand(@"SELECT FilmName FROM DramaMoviesTable WHERE Subtitles='False'", horrorMovieCon);
                            SqlDataReader reader = null;
                            reader = cmd.ExecuteReader();
                            String s = " ";
                            while (reader.Read())
                            {
                                s = s + " " + reader.GetString(0);
                            }
                            MessageBox.Show(s, "Jums reiktu paziureti Filmus:");


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "OOPS");
                        }


                    }
                    else
                    {

                        if (Ivertinimas.Text == "1-3")
                        {
                            try
                            {
                                SqlCommand cmd = new SqlCommand(@"SELECT FilmName FROM DramaMoviesTable
                                    WHERE Evaluation BETWEEN 1.0 AND 3.0 AND Subtitles = 'False'", horrorMovieCon);
                                SqlDataReader reader = null;
                                reader = cmd.ExecuteReader();
                                String s = " ";
                                while (reader.Read())
                                {
                                    s = s + " " + reader.GetString(0);
                                }
                                MessageBox.Show(s, "Jums reiktu paziureti Filmus:");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "OOPS");
                            }



                        }

                        else
                        {


                            if (Ivertinimas.Text == "4.5<")
                            {
                                if (ComboBox1.SelectedIndex == 0)
                                {
                                    try
                                    {

                                        SqlCommand cmd = new SqlCommand(@"SELECT FilmName FROM DramaMoviesTable
                                        WHERE Evaluation BETWEEN 4.4 AND 5.0 AND Creators='Warner Bros. (Warner Bros. Pictures)'", horrorMovieCon);

                                        SqlDataReader reader = null;

                                        reader = cmd.ExecuteReader();

                                        String s = " ";
                                        while (reader.Read())
                                        {
                                            s = s + " " + reader.GetString(0);
                                        }
                                        MessageBox.Show(s, "Jums reiktu paziureti Filmus:");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "OOPS");
                                    }


                                }
                                else
                                {
                                    if (ComboBox1.SelectedIndex == 1)
                                    {


                                        try
                                        {
                                            SqlCommand cmd = new SqlCommand(@"SELECT FilmName FROM DramaMoviesTable
                                            WHERE Evaluation BETWEEN 4.4 AND 5 AND Creators=' 20th Century Studios'", horrorMovieCon);
                                            SqlDataReader reader = null;
                                            reader = cmd.ExecuteReader();
                                            String s = " ";
                                            while (reader.Read())
                                            {
                                                s = s + " " + reader.GetString(0);
                                            }
                                           
                                            MessageBox.Show("Narcos","Jums reiktu paziureti Filmus:");
                                        
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message, "OOPS");
                                        }


                                    }

                                }
                            }
                            else
                            {

                                if (Ivertinimas.Text == "3-4.5")
                                {
                                    if (ComboBox1.SelectedIndex == 1)
                                    {
                                        try
                                        {
                                            SqlCommand cmd = new SqlCommand(@"SELECT FilmName FROM DramaMoviesTable
                                            WHERE Evaluation BETWEEN 3.0 AND 4.0 AND Creators='20th Century Studios'", horrorMovieCon);
                                            SqlDataReader reader = null;
                                            reader = cmd.ExecuteReader();
                                            String s = " ";
                                            while (reader.Read())
                                            {
                                                s = s + " " + reader.GetString(0);
                                            }
                                            MessageBox.Show(s, "Jums reiktu paziureti Filmus:");


                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message, "OOPS");
                                        }

                                    }
                                    if (ComboBox1.SelectedIndex == 0)
                                    {
                                        try
                                        {
                                            SqlCommand cmd = new SqlCommand(@"SELECT FilmName FROM DramaMoviesTable
                                            WHERE Evaluation BETWEEN 3.0 AND 4.0 AND Creators='Warner Bros. (Warner Bros. Pictures)'", horrorMovieCon);
                                            SqlDataReader reader = null;
                                            reader = cmd.ExecuteReader();
                                            String s = " ";
                                            while (reader.Read())
                                            {
                                                s = s + " " + reader.GetString(0);
                                            }
                                            MessageBox.Show(s, "Jums reiktu paziureti Filmus:");


                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message, "OOPS");
                                        }

                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Atsiprasau, bet jus pernelyg isrankus");
                                }

                            }

                        }
                    }

                }


            }
            else
            {
                MessageBox.Show("Pasirink");
                MessageBox.Show("Neveikiame");
            }
        }




        private bool IsTrue()
        {
            //if (Ivertinimas.Text == String.Empty)
            //{             
            //    return true;
            //}

            if (desimtmeciai.IsChecked == false && desimtmeciai2.IsChecked == false)
            {
                return true;
            }
            if (ComboBox1.SelectedIndex == 0)
            {
                return false;
            }
            if (ComboBox1.SelectedIndex == 1)
            {
                return false;
            }
            return true;
        }
        private void Ivertinimas_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Ivertinimas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void desimtmeciai2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void desimtmeciai_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
