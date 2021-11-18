using System;
using System.Collections.Generic;
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
    /// Interaction logic for DramaFilms.xaml
    /// </summary>
    public partial class DramaFilms : Window
    {
        public string[] names { get; set; }
        public DramaFilms()
        {
            InitializeComponent();
            names = new string[] { "A Star Is Born", "Narcos", "Knives Out", "Godfather", "Pawn Sacrifice" };
            DataContext = this;
        }

        private void FilmuBaze3_Click(object sender, RoutedEventArgs e)
        {
            FilmuBaze filmubaze = new FilmuBaze();
            filmubaze.Show();
            MessageBox.Show("Welcome To FilmuBaze.lt", "MY BOX");
        }

        private void isjungejas3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void back3_Click(object sender, RoutedEventArgs e)
        {
            MoviesGenreScreen moviesGenreScreen = new MoviesGenreScreen();
            moviesGenreScreen.Show();
            this.Close();
        }

        private void Ifilmus_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Pasirinkote A Star Is Born filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/DramaASTARisborn.html", UriKind.Absolute);

                try
                {
                    string file = @"C:\Users\Namai\Desktop\ProjektasSUPER\FilmuPasirinkimai.txt";
                    using (StreamWriter sw = File.AppendText(file))
                    {
                        sw.WriteLine(ComboBox1.Text);
                    }
                }
                catch (Exception en)
                {
                    string path = @"‪C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt";
                    ComboBox1.Text = ($"Ivyko klaida{en.Message}");
                    using (FileStream fileStream = File.Create(path))
                    {
                        fileStream.Close();
                    }
                    using (StreamWriter fr = File.AppendText(@"C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt"))
                    {
                        ComboBox1.Text = ("Ivyko klaida, neradome failo, todel sukureme nauja. Bandykite pakartoti is naujo.");
                    }
                    ComboBox1.Text = ("Failas sukuriamas");
                }
            }

            if (ComboBox1.SelectedIndex == 1)
            {
                MessageBox.Show("Pasirinkote Narcos filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/DramaNarcos.html", UriKind.Absolute);

                try
                {
                    string file = @"C:\Users\Namai\Desktop\ProjektasSUPER\FilmuPasirinkimai.txt";
                    using (StreamWriter sw = File.AppendText(file))
                    {
                        sw.WriteLine(ComboBox1.Text);
                    }
                }
                catch (Exception en)
                {
                    string path = @"‪C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt";
                    ComboBox1.Text = ($"Ivyko klaida{en.Message}");
                    using (FileStream fileStream = File.Create(path))
                    {
                        fileStream.Close();
                    }
                    using (StreamWriter fr = File.AppendText(@"C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt"))
                    {
                        ComboBox1.Text = ("Ivyko klaida, neradome failo, todel sukureme nauja. Bandykite pakartoti is naujo.");
                    }
                    ComboBox1.Text = ("Failas sukuriamas");
                }

            }
            if (ComboBox1.SelectedIndex == 2)
            {
                MessageBox.Show("Pasirinkote Knives Out filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/DramaKnifesOut.html", UriKind.Absolute);

                try
                {
                    string file = @"C:\Users\Namai\Desktop\ProjektasSUPER\FilmuPasirinkimai.txt";
                    using (StreamWriter sw = File.AppendText(file))
                    {
                        sw.WriteLine(ComboBox1.Text);
                    }
                }
                catch (Exception en)
                {
                    string path = @"‪C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt";
                    ComboBox1.Text = ($"Ivyko klaida{en.Message}");
                    using (FileStream fileStream = File.Create(path))
                    {
                        fileStream.Close();
                    }
                    using (StreamWriter fr = File.AppendText(@"C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt"))
                    {
                        ComboBox1.Text = ("Ivyko klaida, neradome failo, todel sukureme nauja. Bandykite pakartoti is naujo.");
                    }
                    ComboBox1.Text = ("Failas sukuriamas");
                }

            }
            if (ComboBox1.SelectedIndex == 3)
            {
                MessageBox.Show("Pasirinkote Godfather filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/DramaKrikstatevis.html", UriKind.Absolute);

                try
                {
                    string file = @"C:\Users\Namai\Desktop\ProjektasSUPER\FilmuPasirinkimai.txt";
                    using (StreamWriter sw = File.AppendText(file))
                    {
                        sw.WriteLine(ComboBox1.Text);
                    }
                }
                catch (Exception en)
                {
                    string path = @"‪C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt";
                    ComboBox1.Text = ($"Ivyko klaida{en.Message}");
                    using (FileStream fileStream = File.Create(path))
                    {
                        fileStream.Close();
                    }
                    using (StreamWriter fr = File.AppendText(@"C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt"))
                    {
                        ComboBox1.Text = ("Ivyko klaida, neradome failo, todel sukureme nauja. Bandykite pakartoti is naujo.");
                    }
                    ComboBox1.Text = ("Failas sukuriamas");
                }
            }

            if (ComboBox1.SelectedIndex == 4)
            {
                MessageBox.Show("Pasirinkote Pawn Sacrifice filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/PawnSacrifise.html", UriKind.Absolute);

                try
                {
                    string file = @"C:\Users\Namai\Desktop\ProjektasSUPER\FilmuPasirinkimai.txt";
                    using (StreamWriter sw = File.AppendText(file))
                    {
                        sw.WriteLine(ComboBox1.Text);
                    }
                }
                catch (Exception en)
                {
                    string path = @"‪C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt";
                    ComboBox1.Text = ($"Ivyko klaida{en.Message}");
                    using (FileStream fileStream = File.Create(path))
                    {
                        fileStream.Close();
                    }
                    using (StreamWriter fr = File.AppendText(@"C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt"))
                    {
                        ComboBox1.Text = ("Ivyko klaida, neradome failo, todel sukureme nauja. Bandykite pakartoti is naujo.");
                    }
                    ComboBox1.Text = ("Failas sukuriamas");
                }
            }

            if (ComboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Pirmiau pasirinkite Filma");

            }
        

        }

        private void NegaliuIssrinktiHorrorMovie_Click(object sender, RoutedEventArgs e)
        {
           DramaSelectScreen dramaSelectScreen = new DramaSelectScreen();
            dramaSelectScreen.Show();
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
