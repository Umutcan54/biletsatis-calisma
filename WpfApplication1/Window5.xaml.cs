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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source =uygulama.accdb");
        public static int id;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = false;
            textBox2.IsEnabled = false;
            textBox3.IsEnabled = false;
            baglanti.Open();
             OleDbCommand veri = new OleDbCommand("update bilet set  soyad ='" +textBox2.Text+"', k_adi= '"+textBox3.Text+"', sifre ='"+textBox4.Text+"',telefon='"+textBox5.Text+"' where ad ='"+textBox1.Text+"'" ,baglanti);
            veri.ExecuteNonQuery();
            MessageBox.Show("kayıt güncellendi","bilgi1",MessageBoxButton.OK,MessageBoxImage.Information);
            MainWindow aaaaa = new MainWindow();
            aaaaa.Show();
            Window5 iii = new Window5();
            this.Close();
            baglanti.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {    Window5 i = new Window5();
            i.Show();
            this.Close();
   
            Window6 x = new Window6();
            x.Show();
}
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = false;
            textBox2.IsEnabled = false;
            textBox3.IsEnabled = false;

            baglanti.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from bilet where id=" + Convert.ToInt32(Window2.id), baglanti);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                string ad = oku1["ad"].ToString();
                string soyad = oku1["soyad"].ToString();
                string k_adi = oku1["k_adi"].ToString();

                textBox1.Text = ad;
                textBox2.Text = soyad;
                textBox3.Text = k_adi;
             
            } 
            baglanti.Close();
            
           
        }
    }
}
