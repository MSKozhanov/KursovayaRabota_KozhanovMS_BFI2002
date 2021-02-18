using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Form1_3_3 : Form
    {
        public Form1_3_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Content f = new Content();
            this.Hide();
            f.ShowDialog();
        }
    }
}
