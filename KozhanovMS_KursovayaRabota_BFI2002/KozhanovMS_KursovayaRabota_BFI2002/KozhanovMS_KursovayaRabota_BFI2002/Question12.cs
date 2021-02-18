using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Question12 : Form
    {
        public Question12()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
                Program.AddResult("quest12", textBox1.Text);
                Question13 f = new Question13();
                this.Hide();
                f.ShowDialog();
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
                Program.AddResult("quest12", textBox1.Text);
                Question13 f = new Question13();
                this.Hide();
                f.ShowDialog();
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("Вы ответили правильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                textBox1.Text = "1 балл";
                textBox1.Enabled = false;
                Program.AddResult("quest12", textBox1.Text);
                Question13 f = new Question13();
                this.Hide();
                f.ShowDialog();
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
                Program.AddResult("quest12", textBox1.Text);
                Question13 f = new Question13();
                this.Hide();
                f.ShowDialog();
            }
            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked))
                MessageBox.Show("Надо ответить на вопрос!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }
    }
}
