using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmetsüa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int p = 0;
        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            textBox2.BackColor = Color.LightYellow;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.Y)
            {
                btn_kyt.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.K)
            {
                btn_kaydet.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.Z)
            {
                btn_duzelt.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.S)
            {
                btn_scsil.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.H)
            {
                btn_hsil.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.X)
            {
                btn_dosyakaydet.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            sayac.Text = dateTimePicker1.Text;
            dateTimePicker1.Enabled = false;
            this.MaximizeBox = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac.Text = "Bugün:" + DateTime.Now.ToLongDateString()+ " Saat:" + DateTime.Now.ToLongTimeString();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void btn_kyt_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                secim = MessageBox.Show("Lütfen iş adını ve açıklamasını boş geçmeyiniz!", "Tamam",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string x, y;
            x=textBox1.Text; 
            y=textBox2.Text;
            DialogResult secim = new DialogResult();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                secim = MessageBox.Show("Lütfen iş adını ve açıklamasını boş geçmeyiniz!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (checkBox1.Checked)
                {
                    listBox1.Items.Add(x + "-" + " " + y + "-" + dateTimePicker1.Text);
                }
                else
                {
                    listBox1.Items.Add(x + "-" + " " + y);
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                p++;
                label5.Text= p.ToString();
            }
        }

        private void btn_scsil_Click(object sender, EventArgs e)
        {
            int index;
            index=listBox1.SelectedIndex;
            DialogResult secim = new DialogResult();                        
            secim = MessageBox.Show("Silmek istediğinize emin misiniz", "Tamam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(secim==DialogResult.Yes)
            {
                if(index!=-1)
                {
                    listBox1.Items.RemoveAt(index);
                }
                else
                {
                    DialogResult sonuc = new DialogResult();
                    sonuc = MessageBox.Show("Lütfen bir eleman seçiniz","Tamam",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                        
                
            }             
        }

        private void btn_hsil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Hepsini silmek istediğinize emin misiniz", "Tamam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(secim == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string satir;
            string s="";
            satir=listBox1.SelectedIndex.ToString();
            for (int i = 0; i<satir.Length;i++)
            {
                if (!(satir [i] == '-'))
                {
                   s += satir[i];
                }                    
            }
            textBox1.Text = s;
        }
    }
}
