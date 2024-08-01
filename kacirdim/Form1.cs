using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kacirdim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ort = Convert.ToInt32(textBox1.Text);
                int dev = Convert.ToInt32(textBox2.Text);

                if (ort >=78 && dev <= 16)
                {
                    label3.Text = "Durum: Mezun oldunuz";
                }
                else
                {
                    label3.Text = "Durum: Mezun olamadiniz";
                }
            }
            catch
            {
                MessageBox.Show(" Sayi giriniz ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbSari.Checked)
            {
                groupBox2.BackColor = Color.Yellow;
            }
            else if (rbLacivert.Checked)
            {
                groupBox2.BackColor = Color.Aqua;
            }
            else if (rbYesil.Checked)
            {
                groupBox2.BackColor= Color.Green;
            }
            else
            {
                groupBox2.BackColor = Color.Red;
                MessageBox.Show("Secim yaapiniz" );
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ilkbahar");
            listBox1.Items.Add("Yaz");
            listBox1.Items.Add("Sonbar");
            listBox1.Items.Add("Kis");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string secilen  = Convert.ToString(comboBox1.SelectedItem);
            if (secilen == "yaz")
            {
                listBox1.Items.Add("Haziran");
                listBox1.Items.Add("Temmuz");
                listBox1.Items.Add("Agustos");
            }
            else if (secilen == "Sonbahar")
            {
                listBox1.Items.Add("Eylul");
                listBox1.Items.Add("Ekim");
                listBox1.Items.Add("Kasim");
            }
            else if (secilen == "Kis")
            {
                listBox1.Items.Add("Aralik");
                listBox1.Items.Add("Ocak");
                listBox1.Items.Add("Subat");
            }
            else if (secilen == "Sonbahar")
            {
                listBox1.Items.Add("Mart");
                listBox1.Items.Add("Nisan");
                listBox1.Items.Add("Mayis");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rSayi = rnd.Next(1,100);
            listBox2.Items.Add(rSayi);
        }
    }
}
