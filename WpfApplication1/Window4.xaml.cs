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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
        }
        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = uygulama.accdb");
        static public int id;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from bilet where k_adi='"+Window7.kadi+"'", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                string tckimlik = oku["tc_no"].ToString();
                string ad= oku["ad"].ToString();
                string soyad = oku["soyad"].ToString();
                string yas = oku["yas"].ToString();
                string telefon = oku["telefon"].ToString();
                string cinsiyet = oku["cinsiyet"].ToString();
                string nereden = oku["nereden"].ToString();
                string nereye = oku["nereye"].ToString();
                string saat = oku["saat"].ToString();
                string adet = oku["biletadeti"].ToString();
                string tarih = oku["tarih"].ToString();
                string koltukno = oku["koltukno"].ToString();

                textBox1.Text = tckimlik;
                textBox2.Text = ad;
                textBox3.Text = soyad;
                textBox9.Text = yas;
                textBox4.Text = telefon;
                textBox10.Text = cinsiyet;
                textBox11.Text = nereden;
                textBox12.Text = nereye;
                textBox13.Text = saat;
                textBox14.Text = adet;
                textBox7.Text = tarih;
                textBox8.Text = koltukno;
                label15.Content = Window7.kadi;
                
                 

  
            }

                baglanti.Close();
              
            
        }
        
        private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
        {            
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİNMİSİNİZ ?", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                baglanti.Open();
                OleDbCommand veri = new OleDbCommand("delete from bilet where  k_adi='" + textBox6.Text + "'", baglanti);
                veri.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("KAYIT SİLİNDİ");
                MainWindow j = new MainWindow();
                j.Show();
                this.Close();
               
 
            }
        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from bilet where  k_adi='" + textBox5.Text + "'", baglanti);
            OleDbDataReader oku = veri1.ExecuteReader();
            while (oku.Read())
            { 
               
                MessageBox.Show("KAYIT GÖSTERİLİYOR");
                string tckimlik = oku["tc_no"].ToString();
                string ad = oku["ad"].ToString();
                string soyad = oku["soyad"].ToString();
                string yas = oku["yas"].ToString();
                string telefon = oku["telefon"].ToString();
                string cinsiyet = oku["cinsiyet"].ToString();
                string nereden = oku["nereden"].ToString();
                string nereye = oku["nereye"].ToString();
                string saat = oku["saat"].ToString();
                string adet = oku["biletadeti"].ToString();
                string tarih = oku["tarih"].ToString();
                string koltukno = oku["koltukno"].ToString();

                textBox1.Text = tckimlik;
                textBox2.Text = ad;
                textBox3.Text = soyad;
                textBox9.Text = yas;
                textBox4.Text = telefon;
                textBox10.Text = cinsiyet;
                textBox11.Text = nereden;
                textBox12.Text = nereye;
                textBox13.Text = saat;
                textBox14.Text = adet;
                textBox7.Text = tarih;
                textBox8.Text = koltukno;
            }
            baglanti.Close();


            
        }
        private void dataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow anasayfa = new MainWindow();
            anasayfa.Show();
            this.Close();

        }
        private void listBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            label12.Visibility = Visibility.Visible;
            textBox6.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Visible;
            label11.Visibility = Visibility.Hidden;
            textBox5.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            label11.Visibility = Visibility.Visible;
            textBox5.Visibility = Visibility.Visible;
            button1.Visibility = Visibility.Visible;
            label12.Visibility = Visibility.Hidden;
            textBox6.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;


        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Window7 s = new Window7();
            s.Show();
            this.Close();
        }
    }
}
