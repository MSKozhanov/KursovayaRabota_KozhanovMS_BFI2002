using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Form1_2_3_1 : Form
    {
        public Form1_2_3_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Content f = new Content();
            this.Hide();
            f.ShowDialog();
        }

 

        private void Form1_2_3_1_Load(object sender, EventArgs e)
        {

        }
    }
}
