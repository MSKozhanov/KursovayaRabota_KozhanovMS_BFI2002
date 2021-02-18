using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {


            if ((!checkBox1.Checked) && (checkBox2.Checked) && (checkBox3.Checked) && (checkBox4.Checked))
            {
                MessageBox.Show("Вы ответили правильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                textBox1.Text = "1 балл";
                textBox1.Enabled = false;
                Program.AddResult("quest2", textBox1.Text);
                Question3 f = new Question3();
                this.Hide();
                f.ShowDialog();
            }
            else if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked))

                MessageBox.Show("Вы не ответили на вопрос!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
                Program.AddResult("quest2", textBox1.Text);
                Question3 f = new Question3();
                this.Hide();
                f.ShowDialog();
            }
            
        }
    }
}
