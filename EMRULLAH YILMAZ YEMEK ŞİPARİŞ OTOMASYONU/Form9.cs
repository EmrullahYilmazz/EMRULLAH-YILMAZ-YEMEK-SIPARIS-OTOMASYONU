using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMRULLAH_YILMAZ_YEMEK_ŞİPARİŞ_OTOMASYONU
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        
        
        private void Form9_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty)
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox3.BackColor = Color.Red;
                textBox4.BackColor = Color.Red;
                MessageBox.Show("Kırmızı Renkli Alanları Boş Geçemezsiniz");

            }
            else
            {
                MessageBox.Show("Ödemeniz Başarıyla Gerçekleşti Program Kapanıyor");
                Form9.ActiveForm.Hide();
            }
        }
    }
}
