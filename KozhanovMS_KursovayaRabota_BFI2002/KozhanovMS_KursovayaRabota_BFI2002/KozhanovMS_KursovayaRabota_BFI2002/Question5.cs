using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Question5 : Form
    {
        public Question5()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex == 2))
            { 
                MessageBox.Show("Вы ответили правильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Enabled = false;
                textBox1.Text = "1 балл";
                textBox1.Enabled = false;
                Program.AddResult("quest5", textBox1.Text);
                Question6 f = new Question6();
                this.Hide();
                f.ShowDialog();
            }
            else
                if ((comboBox1.SelectedIndex == -1))
                MessageBox.Show("Надо ответить на вопрос!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Enabled = false;
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
                Program.AddResult("quest5", textBox1.Text);
                Question6 f = new Question6();
                this.Hide();
                f.ShowDialog();
            }
           
        }

    }
}
