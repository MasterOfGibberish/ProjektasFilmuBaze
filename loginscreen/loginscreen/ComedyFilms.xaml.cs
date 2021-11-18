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
    /// Interaction logic for ComedyFilms.xaml
    /// </summary>
    public partial class ComedyFilms : Window
    {
        public string[] names { get; set; }
        public ComedyFilms()
        {
            InitializeComponent();
            names = new string[] { "MR Bean", "Chaplin (film)", "Pink Panther ", "Simpsons"};
            DataContext = this;
        }

        private void FilmuBaze3_Click(object sender, RoutedEventArgs e)
        {
            FilmuBaze filmubaze = new FilmuBaze();
            filmubaze.Show();
            MessageBox.Show("Welcome To FilmuBaze.lt", "MY BOX");
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                
        }

        private void Ifilmus_Click(object sender, RoutedEventArgs e)
        {
           
            if (ComboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Pasirinkote MR Bean filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/ComedyMRBEAN.html", UriKind.Absolute);

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
                MessageBox.Show("Pasirinkote Chaplin (film) filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/Chaplin.html", UriKind.Absolute);

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
                MessageBox.Show("Pasirinkote Pink Panther filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/ComedyPanther.html", UriKind.Absolute);

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
                MessageBox.Show("Pasirinkote Simpsons filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/ComedySimpsons.html", UriKind.Absolute);

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

        private void back3_Click(object sender, RoutedEventArgs e)
        {
            MoviesGenreScreen moviesGenreScreen = new MoviesGenreScreen();
            moviesGenreScreen.Show();
            this.Close();
        }

        private void isjungejas3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NegaliuIssrinktiHorrorMovie_Click(object sender, RoutedEventArgs e)
        {
            ComedySelectScreen comedySelectScreen = new ComedySelectScreen();
            comedySelectScreen.Show();
        }
    }
}
