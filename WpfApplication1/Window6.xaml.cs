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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = uygulama.accdb");
        public static int id;
        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        int sayac = 0;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("update bilet set yas='" + comboBox1.Text + "',telefon='" + textBox4.Text + "',cinsiyet='" + comboBox2.Text + "',nereden='" + comboBox3.Text + "',nereye='" + comboBox4.Text + "',saat='" + comboBox5.Text + "',biletadeti='" + comboBox6.Text + "',tarih='" + datePicker1.Text + "' where tc_no='" + textBox1.Text + "'", baglanti);
            veri.ExecuteNonQuery();
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Biletinizi almanız için boş bırakmayınız !!!", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                sayac++;
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Biletinizi almanız için boş bırakmayınız !!!", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                sayac++;
            }
            else if (comboBox2.Text == "")
            {
                sayac++;
                MessageBox.Show("Biletinizi almanız için boş bırakmayınız !!!", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (comboBox3.Text == "")
            {
                sayac++;
                MessageBox.Show("Biletinizi almanız için boş bırakmayınız !!!", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (comboBox4.Text == "")
            {
                sayac++;
                MessageBox.Show("Biletinizi almanız için boş bırakmayınız !!!", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (comboBox5.Text == "")
            {
                MessageBox.Show("Biletinizi almanız için boş bırakmayınız !!!", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                sayac++;
            }
            else if (comboBox6.Text == "")
            {
                MessageBox.Show("Biletinizi almanız için boş bırakmayınız !!!", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                sayac++;
            }
            else if (datePicker1.Text == "")
            {
                sayac++;
                MessageBox.Show("Biletinizi almanız için boş bırakmayınız !!!", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Biletiniz Alındı Bizi Tercih Ettiğiniz için Teşekkürler", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                Window8 iii = new Window8();
                iii.Show();
                Window6 u = new Window6();
                this.Close();
                
            }
            if (sayac >= 3)
            {
                MessageBox.Show("3'ten fazla boş yer bıraktınız.Ana sayfaya yönlendiriliyorsunuz","Bilgi",MessageBoxButton.OK,MessageBoxImage.Information);
                this.Close();
                MainWindow eee = new MainWindow();
                eee.Show();
            
            }
           
            baglanti.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           

            baglanti.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from bilet where id=" + Convert.ToInt32(Window2.id), baglanti);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                textBox1.Text = oku1["tc_no"].ToString();
                textBox2.Text = oku1["ad"].ToString();
                textBox3.Text = oku1["soyad"].ToString();

            }
            OleDbCommand veri6 = new OleDbCommand("select * from sehirler ", baglanti);
            OleDbDataReader oku6 = veri6.ExecuteReader();
            while (oku6.Read())
            {
                string sehirler = oku6["sehirad"].ToString();
                comboBox3.Items.Add(sehirler);

            }
           
            //OleDbCommand veri4 = new OleDbCommand("select * from sehirler", baglanti);
            // OleDbDataReader oku4 = veri4.ExecuteReader();
            // while (oku4.Read())
            // {
            //  string sehir = oku4["sehirad"].ToString();
            // comboBox3.Items.Add(sehir);

            // }

            baglanti.Close();


        }

        private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow anasayfaa = new MainWindow();
            anasayfaa.Show();
            this.Close();
        }

        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri4 = new OleDbCommand("select * from seferler where nereye='" + comboBox4.Text + "' ", baglanti);
            OleDbDataReader oku4 = veri4.ExecuteReader();
            while (oku4.Read())
            {
                string sefer1 = oku4["sefer1"].ToString();
                string sefer2 = oku4["sefer2"].ToString();
                string sefer3 = oku4["sefer3"].ToString();
                string sefer4 = oku4["sefer4"].ToString();
                string sefer5 = oku4["sefer5"].ToString();
                comboBox5.Items.Add(sefer1);
                comboBox5.Items.Add(sefer2);
                comboBox5.Items.Add(sefer3);
                comboBox5.Items.Add(sefer4);
                comboBox5.Items.Add(sefer5);
                //string nereye = oku3["nereye"].ToString();


                //comboBox4.Items.Add(nereye);
            }
            baglanti.Close();

        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //baglanti.Open();
           // OleDbCommand veri3 = new OleDbCommand("select * from seferler where nereden='" + comboBox3.Text + "' ", baglanti);
           // OleDbDataReader oku3 = veri3.ExecuteReader();
           // while (oku3.Read())
           // {
              //  string nereden = oku3["nereden"].ToString();
              //  comboBox3.Items.Add(nereden);

                //string nereye = oku3["nereye"].ToString();


                //comboBox4.Items.Add(nereye);
          //  }
          //  baglanti.Close();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            label13.Visibility = Visibility.Visible;
            label15.Visibility = Visibility.Hidden;
            comboBox4.Items.Clear();
            baglanti.Open();
            OleDbCommand veri5 = new OleDbCommand("select * from seferler where nereden ='" + comboBox3.Text + "'", baglanti);
            OleDbDataReader oku5 = veri5.ExecuteReader();
            while (oku5.Read())
            {
                string nereye = oku5["nereye"].ToString();
                comboBox4.Items.Add(nereye);

                
            }
            baglanti.Close();
        }

        private void comboBox5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           //baglanti.Open();
            //OleDbCommand veri6 = new OleDbCommand("select * from seferler where sefer saati='"+comboBox5.Text+"' ", baglanti);
            //OleDbDataReader oku6 = veri6.ExecuteReader();
           //while (oku6.Read())
           //{
               // string sefer = oku6["sefer saati"].ToString();
              
               // comboBox5.Items.Add(sefer);
               

               // }
               // baglanti.Close();
            }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            label13.Visibility = Visibility.Hidden;
            label15.Visibility = Visibility.Visible;

            comboBox5.Items.Clear();
            baglanti.Open();
            OleDbCommand veri6 = new OleDbCommand("select * from seferler where nereye ='" + comboBox4.Text + "'", baglanti);
            OleDbDataReader oku6 = veri6.ExecuteReader();
            while (oku6.Read())
            {
                string sefer1 = oku6["sefer1"].ToString();
                string sefer2 = oku6["sefer2"].ToString();
                string sefer3 = oku6["sefer3"].ToString();
                string sefer4 = oku6["sefer4"].ToString();
                string sefer5 = oku6["sefer5"].ToString();
                comboBox5.Items.Add(sefer1);
                comboBox5.Items.Add(sefer2);
                comboBox5.Items.Add(sefer3);
                comboBox5.Items.Add(sefer4);
                comboBox5.Items.Add(sefer5);

            }
            baglanti.Close();
        }
       
        }
    }

