using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Content : Form
    {
        public Content()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_1_1 f = new Form1_1_1();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1_2_1 f = new Form1_2_1();
            this.Hide();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1_2_1_1 f = new Form1_2_1_1();
            this.Hide();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1_2_2_1 f = new Form1_2_2_1();
            this.Hide();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1_2_3_1 f = new Form1_2_3_1();
            this.Hide();
            f.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1_3_1 f = new Form1_3_1();
            this.Hide();
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1_3_2 f = new Form1_3_2();
            this.Hide();
            f.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1_3_3 f = new Form1_3_3();
            this.Hide();
            f.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1_4 f = new Form1_4();
            this.Hide();
            f.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены, что хотите начать тест? ","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Question1 f = new Question1();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
