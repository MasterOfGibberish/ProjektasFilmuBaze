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
    /// Interaction logic for FilmuBaze.xaml
    /// </summary>
    public partial class FilmuBaze : Window
    {
        public FilmuBaze()
        {
            InitializeComponent();
        }

        private void migtukas3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FilmuBaze2_Click(object sender, RoutedEventArgs e)
        {
            this.Focus();
        }
        private void patikra_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string file = @"C:\Users\Namai\Desktop\ProjektasSUPER\Nusiskundimai.txt";
                using (StreamWriter sw = File.AppendText(file))
                {
                    sw.WriteLine(Nusiskundimai.Text);
                    Nusiskundimu_Laukelis.Text = ("Duomenys ivesti," +
                        " aciu uz informacija!");
                    if(Nusiskundimu_Laukelis.Text == String.Empty)
                    {
                        MessageBox.Show("Paspaskite SUBMIT ");
                    }
                    else
                    {
                       Nusiskundimai.Clear();
                    }
                }
            }
            catch (Exception en)
            {
                string path = @"C:\Users\Namai\Desktop\ProjektasSUPER\Nusiskundimai.txt";
                Nusiskundimu_Laukelis.Text = ($"Ivyko klaida{en.Message}");
                using (FileStream fileStream = File.Create(path))
                {
                    fileStream.Close();
                }
                using (StreamWriter fr = File.AppendText(@"C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt"))
                {
                    Nusiskundimu_Laukelis.Text = ("Ivyko klaida, neradome failo, todel sukureme nauja. Bandykite pakartoti is naujo.");
                }
                Nusiskundimu_Laukelis.Text = ("Failas sukuriamas");
            }
        }

        private void duomenys_Click(object sender, RoutedEventArgs es)
        {
            try
            {

                string file2 = @"C:\Users\Namai\Desktop\ProjektasSUPER\BankoDuomenys.txt";
                using (StreamWriter sw = File.AppendText(file2))
                {
                    sw.WriteLine(Paremimas.Text);
                    Paremimo_Laukelis.Text = ("Duomenys ivesti," +
                        " aciu uz parama!");
                    if (Paremimo_Laukelis.Text == String.Empty)
                    {
                        MessageBox.Show("Paspaskite SUBMIT ");
                    }
                    else
                    {
                        Paremimas.Clear();
                    }
                }
            }
            catch (Exception er)
            {
                string path2 = @"C:\Users\Namai\Desktop\ProjektasSUPER\BankoDuomenys.txt";
                Paremimo_Laukelis.Text = ($"Ivyko klaida{er.Message}");
                using (FileStream fileStream = File.Create(path2))
                {
                    fileStream.Close();
                }
                using (StreamWriter fr = File.AppendText(@"C:\Users\Namai\Desktop\ProjektasSUPER\KlaidosAtveju.txt"))
                {
                    Paremimo_Laukelis.Text=("Ivyko klaida, neradome failo, todel sukureme nauja. Bandykite pakartoti is naujo.");
                }
                Paremimo_Laukelis.Text = ("Failas sukuriamas");
            }
        }

        private void FilmuBaze2_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to FilmuBaze.lt, do not forget to donate, Thank You!!!", "WELCOME");
        }
    }
}
