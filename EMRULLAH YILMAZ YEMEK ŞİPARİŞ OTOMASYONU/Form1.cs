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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kullaniciadi = "emrullah", sifre = "12345";
        int sayac = 0;
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (kullaniciadi == textBox1.Text && sifre == textBox2.Text)
            {
                Form1.ActiveForm.Hide();
                Form2 form1 = new Form2();
                form1.Show();
            }
            else
            {
                MessageBox.Show("HATA! Kullaıcıadı yada şifre geçersizdir.Kalan deneme hakkınız = " + (2 - sayac));
                sayac++;
            }
            if (sayac == 3)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                MessageBox.Show("Program Sonlandırılıyor");
                Form2.ActiveForm.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
