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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server =localhost;database=yemeksiparisotomasyonu;port=3308;Uid=root;Pwd=''");

        DataTable tablo = new DataTable();
        
        private void Form2_Load(object sender, EventArgs e)
        {
            MySqlCommand yeni = new MySqlCommand(@"
        CREATE TABLE IF NOT EXISTS `yemeksipariss` 
        (Id INT AUTO_INCREMENT,
         Ürün TEXT,
         Adet TEXT,
         Fiyat INT,
         PRIMARY KEY(Id));", baglanti);
 
            baglanti.Open();
            yeni.ExecuteNonQuery();
            MySqlDataAdapter adap = new MySqlDataAdapter("select * from yemeksipariss",baglanti);
            adap.Fill(tablo);
            baglanti.Close();

            MessageBox.Show("Seçmek İstediğiniz Restaurantın Üzerine Tıklayınız");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
