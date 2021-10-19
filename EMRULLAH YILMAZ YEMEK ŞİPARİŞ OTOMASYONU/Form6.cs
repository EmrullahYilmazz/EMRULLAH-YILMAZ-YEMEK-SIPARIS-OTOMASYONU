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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int birinciucret, birinciadet, ikinciucret, ikinciadet, ucuncuucret, ucuncuadet, t1, t2, t3, t4;
        MySqlConnection baglanti = new MySqlConnection("Server =localhost;database=yemeksiparisotomasyonu;port=3308;Uid=root;Pwd=''");

        DataTable tablo = new DataTable();
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
                MySqlCommand komut = new MySqlCommand("insert into yemeksipariss(Ürün,Adet,Fiyat) values ('" + label9.Text + "','" + textBox2.Text + "','" + t2 * 15 + "')", baglanti);
                komut.ExecuteNonQuery();
                tablo.Clear();
                baglanti.Close();


            }
            if (t3 > 0)
            {

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into yemeksipariss(Ürün,Adet,Fiyat) values ('" + label10.Text + "','" + textBox3.Text + "','" + t3*12 + "')", baglanti);
                komut.ExecuteNonQuery();
                tablo.Clear();
                baglanti.Close();
            }
            Form6.ActiveForm.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (ucuncuadet < 1)
            {
                MessageBox.Show("Adet Değeri 0 Dan küçük olamaz");
                textBox1.Text = String.Empty;
                
            }
            else if (ucuncuadet>0)
            {
                ucuncuucret = ucuncuucret - 12;
                ucuncuadet = ucuncuadet - 1;
                textBox3.Text = ucuncuadet.ToString();
                t4 = birinciucret + ikinciucret + ucuncuucret;
                textBox4.Text = t4.ToString();
                label10.Text = ucuncuadet.ToString() + ("*ZURNA DÖNER");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucuncuucret = ucuncuucret + 12;
            ucuncuadet = ucuncuadet + 1;
            textBox3.Text = ucuncuadet.ToString();
            t4 = birinciucret + ikinciucret + ucuncuucret;
            textBox4.Text = t4.ToString();
            label10.Text = ucuncuadet.ToString() + ("*ZURNA DÖNER");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ikinciadet < 1)
            {
                MessageBox.Show("Adet Değeri 0 Dan küçük olamaz");
                textBox1.Text = String.Empty;
               
            }
            else if (ikinciadet>0)
            {
                ikinciucret = ikinciucret - 15;
                ikinciadet = ikinciadet - 1;
                textBox2.Text = ikinciadet.ToString();
                t4 = birinciucret + ikinciucret + ucuncuucret;
                textBox4.Text = t4.ToString();
                label9.Text = ikinciadet.ToString() + ("*İSKENDER");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ikinciucret = ikinciucret + 15;
            ikinciadet = ikinciadet + 1;
            textBox2.Text = ikinciadet.ToString();
            t4 = birinciucret + ikinciucret + ucuncuucret;
            textBox4.Text = t4.ToString();
            label9.Text = ikinciadet.ToString() + ("*İSKENDER");
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
                birinciucret = birinciucret - 10;
                birinciadet = birinciadet - 1;
                textBox1.Text = birinciadet.ToString();
                t4 = birinciucret + ikinciucret + ucuncuucret;
                textBox4.Text = t4.ToString();
                label8.Text = birinciadet.ToString() + ("*DÜRÜM DÖNER");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            birinciucret = birinciucret + 10;
            birinciadet = birinciadet + 1;
            textBox1.Text = birinciadet.ToString();
            t4 = birinciucret + ikinciucret + ucuncuucret;
            textBox4.Text = t4.ToString();
            label8.Text = birinciadet.ToString() + ("*DÜRÜM DÖNER");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6.ActiveForm.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
