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
using System.Collections;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
        }     
        OleDbConnection veri = new OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = uygulama.accdb");
        private void button1_Click(object sender, RoutedEventArgs e)
        {          
}  
      
       string[] dizi = new string[40];
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
         
        }       
        private void button1_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[24] == "1")
            {
                MessageBox.Show(button4.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("25 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button7.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button7.Background = Brushes.Red;
                button7.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }           
        }
        private void button79_Click(object sender, RoutedEventArgs e)
        {           
        }
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {          
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[4] == "1")
            {
               MessageBox.Show(button2.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("5 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button2.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button2.Background = Brushes.Red;
                button2.IsEnabled = false;
                veri.Close();
                

            }
            else
            {
                button2.Background = Brushes.Green;

            }
            
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[1] == "1")
            {
                MessageBox.Show(button12.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("2 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button12.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button12.Background = Brushes.Red;
                button12.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button1_Click_2(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[0] == "1")
            { 
              MessageBox.Show(button1.Content.ToString());
              MessageBox.Show(Window2.k__adi);
              veri.Open();
              MessageBox.Show("1 Numara Koltuğu Aldınız");
              OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button1.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
              oku.ExecuteNonQuery();
              button1.Background = Brushes.Red;
              button1.IsEnabled = false;
               veri.Close();
                MessageBox.Show(Window2.k__adi);
                button1.Background = Brushes.Red;
                button1.IsEnabled = false;
                

            }
            else
            {
                button1.Background = Brushes.Green;

            }
           
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
           
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();
            }
            veri.Close();
            if (dizi[8] == "1")
            {    MessageBox.Show(button3.Content.ToString());
                 MessageBox.Show(Window2.k__adi);
                 veri.Open();
                 MessageBox.Show("9 Numara Koltuğu Aldınız");
                 OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button3.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                 oku.ExecuteNonQuery();
                 button3.Background = Brushes.Red;
                 button3.IsEnabled = false;
                 veri.Close();
               

            }
            else
            {
                button3.Background = Brushes.Green;

            }

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[12] == "1")
            {
                MessageBox.Show(button4.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("13 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button4.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button4.Background = Brushes.Red;
                button4.IsEnabled = false;
                veri.Close();
                
               

            }
            else
            {
                button4.Background = Brushes.Green;

            }
          
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[16] == "1")
            {
                MessageBox.Show(button5.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("17 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button5.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button5.Background = Brushes.Red;
                button5.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[20] == "1")
            {
                MessageBox.Show(button6.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("21 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button6.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button6.Background = Brushes.Red;
                button6.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[28] == "1")
            {
                MessageBox.Show(button8.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("29 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button8.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button8.Background = Brushes.Red;
                button8.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[32] == "1")
            {
                MessageBox.Show(button9.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("33 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button9.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button9.Background = Brushes.Red;
                button9.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[5] == "1")
            {
                MessageBox.Show(button22.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("6 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button22.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button22.Background = Brushes.Red;
                button22.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
            
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[9] == "1")
            {
                MessageBox.Show(button4.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("10 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button13.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button13.Background = Brushes.Red;
                button13.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }
        private void button14_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[13] == "1")
            {
                MessageBox.Show(button14.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("14 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button14.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button14.Background = Brushes.Red;
                button14.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[17] == "1")
            {
                MessageBox.Show(button16.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("18 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button15.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button15.Background = Brushes.Red;
                button15.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[21] == "1")
            {
                MessageBox.Show(button16.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("22 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button16.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button16.Background = Brushes.Red;
                button16.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[25] == "1")
            {
                MessageBox.Show(button17.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("26 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button17.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button17.Background = Brushes.Red;
                button17.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[29] == "1")
            {
                MessageBox.Show(button18.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("30 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button18.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button18.Background = Brushes.Red;
                button18.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[33] == "1")
            {
                MessageBox.Show(button19.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("34 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button19.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button19.Background = Brushes.Red;
                button19.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {
        }

        private void button38_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[38] == "1")
            {
                MessageBox.Show(button38.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("39 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button38.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button38.Background = Brushes.Red;
                button38.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button35_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[2] == "1")
            {
                MessageBox.Show(button35.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("3 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button35.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button35.Background = Brushes.Red;
                button35.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
           

        }

        private void button34_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[6] == "1")
            {
                MessageBox.Show(button34.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("7 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button34.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button34.Background = Brushes.Red;
                button34.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
           
        }

        private void button33_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[10] == "1")
            {
                MessageBox.Show(button33.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("11 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button33.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button33.Background = Brushes.Red;
                button33.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button32_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[14] == "1")
            {
                MessageBox.Show(button32.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("15 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button32.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button32.Background = Brushes.Red;
                button32.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button31_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[18] == "1")
            {
                MessageBox.Show(button31.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("19 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button31.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button31.Background = Brushes.Red;
                button31.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

       

        private void button30_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[22] == "1")
            {
                MessageBox.Show(button30.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("23 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button30.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button30.Background = Brushes.Red;
                button30.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button28_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[26] == "1")
            {
                MessageBox.Show(button28.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("27 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button28.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button28.Background = Brushes.Red;
                button28.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button27_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[30] == "1")
            {
                MessageBox.Show(button27.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("31 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button27.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button27.Background = Brushes.Red;
                button27.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button26_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[34] == "1")
            {
                MessageBox.Show(button26.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("35 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button26.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button26.Background = Brushes.Red;
                button26.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button40_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[39] == "1")
            {
                MessageBox.Show(button40.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("35 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button40.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button40.Background = Brushes.Red;
                button40.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button25_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[3] == "1")
            {
                MessageBox.Show(button25.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("4 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button25.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button25.Background = Brushes.Red;
                button25.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
           
        }

        private void button41_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[19] == "1")
            {
                MessageBox.Show(button11.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("20 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button11.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button11.Background = Brushes.Red;
                button11.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[7] == "1")
            {
                MessageBox.Show(button24.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("8 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button24.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button24.Background = Brushes.Red;
                button24.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[11] == "1")
            {
                MessageBox.Show(button23.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("12 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button23.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button23.Background = Brushes.Red;
                button23.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button20_Click_1(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[36] == "1")
            {
                MessageBox.Show(button20.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("37 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button20.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button20.Background = Brushes.Red;
                button20.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button10_Click_1(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[37] == "1")
            {
                MessageBox.Show(button10.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("38 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button10.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button10.Background = Brushes.Red;
                button10.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[15] == "1")
            {
                MessageBox.Show(button21.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("16 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button21.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button21.Background = Brushes.Red;
                button21.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button39_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[23] == "1")
            {
                MessageBox.Show(button39.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("24 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button39.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button39.Background = Brushes.Red;
                button39.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button37_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[27] == "1")
            {
                MessageBox.Show(button37.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("28 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button37.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button37.Background = Brushes.Red;
                button37.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button36_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[31] == "1")
            {
                MessageBox.Show(button36.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("32 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button36.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button36.Background = Brushes.Red;
                button36.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }

        private void button29_Click(object sender, RoutedEventArgs e)
        {
            int sayac = 0;
            veri.Open();
            OleDbCommand veri1 = new OleDbCommand("select * from koltukno ", veri);
            OleDbDataReader oku1 = veri1.ExecuteReader();
            while (oku1.Read())
            {
                dizi[sayac] = oku1["dolu"].ToString();



            }
            veri.Close();
            if (dizi[35] == "1")
            {
                MessageBox.Show(button29.Content.ToString());
                MessageBox.Show(Window2.k__adi);
                veri.Open();
                MessageBox.Show("36 Numara Koltuğu Aldınız");
                OleDbCommand oku = new OleDbCommand("update bilet  set koltukno='" + button29.Content + "' where k_adi='" + Window2.k__adi + "' ", veri);
                oku.ExecuteNonQuery();
                button29.Background = Brushes.Red;
                button29.IsEnabled = false;
                veri.Close();



            }
            else
            {
                button4.Background = Brushes.Green;

            }
        }
    }
}
