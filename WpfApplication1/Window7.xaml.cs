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
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }
        public static string kadi;
        OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = uygulama.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {          
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            kadi = textBox1.Text;
          
            OleDbCommand veri = new OleDbCommand("select * from bilet where k_adi='"+textBox1.Text+"' ", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
    
                kadi = oku["k_adi"].ToString();
               

             Window4 a = new Window4();
             a.Show();
             Window7 ü = new Window7();
             this.Close();

            }

             baglanti.Close();
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow v = new MainWindow();
            v.Show();
            this.Close();
        }
    }
}
