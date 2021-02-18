using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Question7 : Form
    {
        public Question7()
        {
            InitializeComponent();
        }



       

        private void button4_Click(object sender, EventArgs e)
        {
            if(KozhanovLibrary.Class1.que7(checkedListBox1, textBox1) == true)
            {
                Program.AddResult("quest7", textBox1.Text);
                Question8 f = new Question8();
                this.Hide();
                f.ShowDialog();
            }
            
            
        }
    }
}
