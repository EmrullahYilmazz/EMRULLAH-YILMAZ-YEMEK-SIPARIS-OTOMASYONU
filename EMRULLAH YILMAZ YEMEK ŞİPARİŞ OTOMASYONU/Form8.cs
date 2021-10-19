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
    public partial class Form8 : Form
    {
        public Form8()
        {
            
            InitializeComponent();
        }
        
        int t1, t2;
        MySqlCommand command = new MySqlCommand();

        MySqlConnection baglanti = new MySqlConnection("Server =localhost;database=yemeksiparisotomasyonu;port=3308;Uid=root;Pwd=''");

        DataTable tablo = new DataTable();
        

            
        private void button4_Click(object sender, EventArgs e)
        {
            
            Form8.ActiveForm.Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }
        private void Form8_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from yemeksiparis", baglanti);
            MySqlDataAdapter adap = new MySqlDataAdapter("select * from yemeksipariss", baglanti);
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            



        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            //command.CommandText = "DELETE FROM musteri WHERE id = '" + dataGridView1.CurrentRow.Cells["ŞiparişId"].Value.ToString() + "'";
            //command.ExecuteNonQuery();


            Form8.ActiveForm.Hide();
            Form9 form9 = new Form9();
            form9.Show();
            
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8.ActiveForm.Hide();
        }

        

        
    }
        
}
