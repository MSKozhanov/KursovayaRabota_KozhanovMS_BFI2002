﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Question10 : Form
    {
        public Question10()
        {
            InitializeComponent();
        }

       

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = string.Format("Номер на картинке {0}", hScrollBar1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KozhanovLibrary.Class1.que10(hScrollBar1, textBox1);
            Program.AddResult("quest10", textBox1.Text);
            Question11 f = new Question11();
            this.Hide();
            f.ShowDialog();
        }
    }
}
