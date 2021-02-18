using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Question14 : Form

    {
        private string placeholderText = "Введите ответ";

        public Question14()
        {
            InitializeComponent();
        }

       

        // Появляение подсказки места для ввода ответа
        private void Question14_Load(object sender, EventArgs e)
        {
            textBox1.Text = placeholderText;
            textBox1.ForeColor = Color.Gray;
        }

        // Исчезновение подсказки места для ввода ответа после нажатия не textBox
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == placeholderText)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        // Появляение подсказки места для ввода ответа после нажатия на другую область экрана
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = placeholderText;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            if (textBox1.Text == "тепла")
            {
                MessageBox.Show("Вы ответили правильно ", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Text = "1 балл";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                Program.AddResult("quest14", textBox2.Text);
                Results f = new Results();
                this.Hide();
                f.ShowDialog();
            }
            else
                if ((textBox1.Text == placeholderText) || (textBox1.Text.Length == 0))
                {
                    MessageBox.Show("Надо ответить на вопрос", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            else  
            {
                MessageBox.Show("Вы ответили неправильно ", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "0 баллов";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                Program.AddResult("quest14", textBox2.Text);
                Results f = new Results();
                this.Hide();
                f.ShowDialog();
            }
            
        }
    }
}
