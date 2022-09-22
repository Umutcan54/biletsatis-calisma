using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.OleDb;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        static public int id;
        static public string k__adi;
        static public string sifre, k_adi;       
        int sayac;
        OleDbConnection baglanti = new OleDbConnection("provider = microsoft.ace.oledb.12.0;data source =uygulama.accdb");
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            sayac = 0;
            if (textBox1.Text == "")
            {
                sayac++;
                MessageBox.Show("Lütfen boş bırakmayınız");
            }
            else if (passwordBox1.Password == "")
            {
                sayac++;
                MessageBox.Show("Lütfen boş bırakmayınız");
            }
            else
            {
                bool kullanıcıvarmi = false;
                baglanti.Open();
                OleDbCommand veri = new OleDbCommand("select * from bilet where k_adi='" + textBox1.Text + "'and sifre='" + passwordBox1.Password + "'", baglanti);
                OleDbDataReader oku = veri.ExecuteReader();
                while (oku.Read())
                {
                    k__adi = textBox1.Text;
                   
                    kullanıcıvarmi = true;
                    id = Convert.ToInt32(oku["id"]);

                }
                baglanti.Close();
                if (kullanıcıvarmi)
                {
                    MessageBox.Show("GİRİŞ BAŞARILI", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window5 h = new Window5();
                    h.Show();
                    this.Close();

                }
                else
                {

                    MessageBox.Show("GİRİŞ BAŞARISIZ", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                    textBox1.Clear();
                    passwordBox1.Clear();

                }

            }
            if (sayac >= 3)
            {
                MessageBox.Show("3 ' ten fazla boş bıraktınız bu yüzden anasayfaya yönlendiriyoruz", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                MainWindow eeeee = new MainWindow();
                eeeee.Show();
            }

            

           
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
        }
           

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void button2_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow ö = new MainWindow();
            ö.Show();
            this.Close();
        }

        private void image2_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            k__adi = textBox1.Text;
           
    

        }
    }
}
