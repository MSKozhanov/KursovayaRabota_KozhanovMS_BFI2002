using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Question8 : Form
    {
        public Question8()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (KozhanovLibrary.Class1.que8(checkedListBox1, textBox1) == true)
            {
                Program.AddResult("quest8", textBox1.Text);
                Question9 f = new Question9();
                this.Hide();
                f.ShowDialog();
            }
            
            
        }
    }
}
