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
    /// Interaction logic for HorrorFilms.xaml
    /// </summary>
    public partial class HorrorFilms : Window
    {
        public string[] names { get; set; }
        public HorrorFilms()
        {
            InitializeComponent();
            names = new string[] { "Sinister", "Heloween", "The Ring", "The Texas Chainsaw Massacre ", "Hereditary", "The Conjuring" };
            DataContext = this;
        }

        private void FilmuBaze3_Click(object sender, RoutedEventArgs e)
        {
            FilmuBaze filmubaze = new FilmuBaze();
            filmubaze.Show();
            MessageBox.Show("Welcome To FilmuBaze.lt", "MY BOX");
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

        private void Ifilmus_Click(object sender, RoutedEventArgs e)
        {
           

            if (ComboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Pasirinkote Senister filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/Filmas%201.html", UriKind.Absolute);

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
                MessageBox.Show("Pasirinkote Heloween filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/FilmasHoloween.htmll", UriKind.Absolute);

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
                MessageBox.Show("Pasirinkote The Ring filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/FilmasTheRing.html", UriKind.Absolute);

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
                MessageBox.Show("Pasirinkote The Texas Chainsaw Massacre filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/FilmasTheTexasChainsawMassacre.html", UriKind.Absolute);

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
                MessageBox.Show("Pasirinkote Hereditary filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/FilmasHereditary.html", UriKind.Absolute);

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
            if (ComboBox1.SelectedIndex == 5)
            {
                MessageBox.Show("Pasirinkote The Conjuring filma");
                PirmasStulpelisframe.Source = new Uri(@"http://127.0.0.1:5500/FilmasThe%20Conjuring.html", UriKind.Absolute);

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
            HorrorSelectScreen1 horrorSelectScreen1 = new HorrorSelectScreen1();
            horrorSelectScreen1.Show();
           
        }
    }
}
