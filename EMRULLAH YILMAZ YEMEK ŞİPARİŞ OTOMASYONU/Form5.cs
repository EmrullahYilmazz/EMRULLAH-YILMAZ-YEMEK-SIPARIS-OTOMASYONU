using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace EMRULLAH_YILMAZ_YEMEK_ŞİPARİŞ_OTOMASYONU
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int birinciucret, birinciadet, ikinciucret, ikinciadet, ucuncuucret, ucuncuadet, t1, t2, t3, t4;
        MySqlConnection baglanti = new MySqlConnection("Server =localhost;database=yemeksiparisotomasyonu;port=3308;Uid=root;Pwd=''");

        DataTable tablo = new DataTable();
        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";

            t1 = Convert.ToInt32(textBox1.Text);
            t2 = Convert.ToInt32(textBox2.Text);
            t3 = Convert.ToInt32(textBox3.Text);
            t4 = Convert.ToInt32(textBox4.Text);
            baglanti.Open();
            MySqlDataAdapter adap = new MySqlDataAdapter("Select * from yemeksipariss", baglanti);
            adap.Fill(tablo);
            baglanti.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            t1 = Convert.ToInt32(textBox1.Text);
            t2 = Convert.ToInt32(textBox2.Text);
            t3 = Convert.ToInt32(textBox3.Text);
            t4 = Convert.ToInt32(textBox4.Text);
            if (t1 > 0)
            {

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into yemeksipariss(Ürün,Adet,Fiyat) values ('" + label8.Text + "','" + textBox1.Text + "','" + t1 * 10 + "')", baglanti);
                komut.ExecuteNonQuery();
                tablo.Clear();
                baglanti.Close();
                t4 = Convert.ToInt32(textBox4.Text);


            }
            if (t2 > 0)
            {

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into yemeksipariss(Ürün,Adet,Fiyat) values ('" + label9.Text + "','" + textBox2.Text + "','" + t2 * 10 + "')", baglanti);
                komut.ExecuteNonQuery();
                tablo.Clear();
                baglanti.Close();


            }
            if (t3 > 0)
            {

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into yemeksipariss(Ürün,Adet,Fiyat) values ('" + label10.Text + "','" + textBox3.Text + "','" + t3 * 10 + "')", baglanti);
                komut.ExecuteNonQuery();
                tablo.Clear();
                baglanti.Close();
            }
            Form5.ActiveForm.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            if (ucuncuadet < 1)
            {
                MessageBox.Show("Adet Değeri 0 Dan küçük olamaz");
                textBox1.Text = String.Empty;
                
            }
            else if (ucuncuadet>0)
            {
                ucuncuucret = ucuncuucret - 10;
                ucuncuadet = ucuncuadet - 1;
                textBox3.Text = ucuncuadet.ToString();
                t4 = birinciucret + ikinciucret + ucuncuucret;
                textBox4.Text = t4.ToString();
                label10.Text = ucuncuadet.ToString() + ("*DİYET SANDWİCH");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucuncuucret = ucuncuucret + 10;
            ucuncuadet = ucuncuadet + 1;
            textBox3.Text = ucuncuadet.ToString();
            t4 = birinciucret + ikinciucret + ucuncuucret;
            textBox4.Text = t4.ToString();
            label10.Text = ucuncuadet.ToString() + ("*DİYET SANDWİCH");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ikinciadet < 1)
            {
                MessageBox.Show("Adet Değeri 0 Dan küçük olamaz");
                textBox1.Text = String.Empty;
                
            }
            else if (ikinciadet>0)
            {
                ikinciucret = ikinciucret - 10;
                ikinciadet = ikinciadet - 1;
                textBox2.Text = ikinciadet.ToString();
                t4 = birinciucret + ikinciucret + ucuncuucret;
                textBox4.Text = t4.ToString();
                label9.Text = ikinciadet.ToString() + ("*SUBWAY SANDWİCH");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ikinciucret = ikinciucret + 10;
            ikinciadet = ikinciadet + 1;
            textBox2.Text = ikinciadet.ToString();
            t4 = birinciucret + ikinciucret + ucuncuucret;
            textBox4.Text = t4.ToString();
            label9.Text = ikinciadet.ToString() + ("*UZUN KARIŞIK SANDWİCH");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (birinciadet < 1)
            {
                MessageBox.Show("Adet Değeri 0 Dan küçük olamaz");
                textBox1.Text = String.Empty;
               
            }
            else if (birinciadet>0)
            {
                birinciucret = birinciucret - 15;
                birinciadet = birinciadet - 1;
                textBox1.Text = birinciadet.ToString();
                t4 = birinciucret + ikinciucret + ucuncuucret;
                textBox4.Text = t4.ToString();
                label8.Text = birinciadet.ToString() + ("*SUBWAY MENÜ");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            birinciucret = birinciucret + 15;
            birinciadet = birinciadet + 1;
            textBox1.Text = birinciadet.ToString();
            t4 = birinciucret + ikinciucret + ucuncuucret;
            textBox4.Text = t4.ToString();
            label8.Text = birinciadet.ToString() + ("*SUBWAY MENÜ");

        }
    }
}
