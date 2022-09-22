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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider =microsoft.ace.oledb.12.0;data source=uygulama.accdb");
        int sayac = 0;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("insert into bilet(ad,soyad,tc_no,k_adi,sifre)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+passwordBox1.Password+"')", baglanti);
            veri.ExecuteNonQuery();
            if (textBox1.Text == "")
            { sayac++;
                MessageBox.Show("Lütfen kaydınızı yaparken boş bırakmayınız" ,"bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
            
            }
           else  if (textBox2.Text == "")
            { sayac++;
                MessageBox.Show("Lütfen kaydınızı yaparken boş bırakmayınız" ,"bilgi1", MessageBoxButton.OK, MessageBoxImage.Information);
            
            }
            else if (textBox3.Text == "")
            { sayac++;
                MessageBox.Show("Lütfen kaydınızı yaparken boş bırakmayınız" ,"bilgi2", MessageBoxButton.OK, MessageBoxImage.Information);
            
            }
            else if (textBox4.Text == "")
            { sayac++;
                MessageBox.Show("Lütfen kaydınızı yaparken boş bırakmayınız" ,"bilgi3", MessageBoxButton.OK, MessageBoxImage.Information);
            
            }
              else if (passwordBox1.Password == "")
            {   sayac++;
                MessageBox.Show("Lütfen kaydınızı yaparken boş bırakmayınız" ,"bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
            
            }
            else if (passwordBox2.Password == "")
            {
                sayac++;
                MessageBox.Show("Lütfen kaydınızı yaparken boş bırakmayınız", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Kayıdınız Eklendi", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                
                MainWindow a = new MainWindow();
                a.Show();
                this.Close();
            }
            if (sayac >= 3)
            {
                MessageBox.Show("3'ten fazla boş yer bıraktınız.Ana sayfaya yönlendiriliyorsunuz", "Bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                MainWindow eeee= new MainWindow();
                eeee.Show();
            }
            if (passwordBox1.Password != passwordBox2.Password)
            {
                MessageBox.Show("Şifreler uyuşmuyor lütfen doğru giriniz", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                sayac++;
               
            
            }
            if (sayac >= 3)
            {

                MessageBox.Show("3' ten fazla şifreleri yanlış girdiniz bu yüzden sizi anasayfaya yönlendiriyoruz!!! ", "bilgi", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow v = new MainWindow();
                v.Show();
                this.Close();
            }
            
           
            
            baglanti.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {      
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow v = new MainWindow();
            v.Show();
            this.Close();
        }
    }
}
