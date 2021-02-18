using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Question9 : Form
    {
        public Question9()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (KozhanovLibrary.Class1.que9(comboBox1, textBox1) == true)
            {


                Program.AddResult("quest9", textBox1.Text);
                Question10 f = new Question10();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
