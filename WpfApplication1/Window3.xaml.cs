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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
         OleDbConnection baglanti = new OleDbConnection("provider = microsoft.ace.oledb.12.0;data source =uygulama.accdb");
         public static string kullanıci_adi, sifre , id;
         private void button1_Click(object sender, RoutedEventArgs e)
         {
             if (textBox1.Text == "" | passwordBox1.Password == "")
             {
                 MessageBox.Show("KULLANICI ADINI VEYA ŞİFREYİ BOŞ BIRAKMAYINIZ","bilgi",MessageBoxButton.OK,MessageBoxImage.Information);

             }
             else
             {

                 kullanıci_adi = textBox1.Text;



                 baglanti.Open();
                 OleDbCommand veri = new OleDbCommand("select * from yönetici where kullanıci_adi='" + textBox1.Text + "'", baglanti);
                 OleDbDataReader oku = veri.ExecuteReader();
                 while (oku.Read())
                 {
                     kullanıci_adi = oku["kullanıci_adi"].ToString();
                     sifre = oku["sifre"].ToString();


                 }
                 baglanti.Close();




                 if (textBox1.Text != kullanıci_adi | passwordBox1.Password != sifre)
                 {
                     MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞ");
                     textBox1.Clear();
                     passwordBox1.Clear();
                 }

                 else
                 {
                     MessageBox.Show("GİRİŞ BAŞARILI","bilgi",MessageBoxButton.OK,MessageBoxImage.Information);
                     Window7 i = new Window7();
                     i.Show();
                     MainWindow k = new MainWindow();
                     this.Close();


                 }
             }
             

         }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow z = new MainWindow();
            z.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
