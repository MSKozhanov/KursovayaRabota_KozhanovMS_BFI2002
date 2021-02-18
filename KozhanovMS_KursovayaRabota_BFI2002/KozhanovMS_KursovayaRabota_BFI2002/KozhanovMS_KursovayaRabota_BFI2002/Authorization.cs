using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Authorization : Form
    {
        private string placeholderText = "Логин";
        private string placeholderText2 = "Пароль";
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string log = "Admin";
                string pass = "Admin";

                
            
                if ((textBox1.Text == log) && (textBox2.Text == pass))
                {
                    MessageBox.Show("Вы ввели правильный пароль... Доступ предоставлен", "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Content f = new Content();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неправильный пароль... В доступе отказано", "Пароль", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            
            
        }

        // Появляение подсказки места для ввода ответа
        private void Autorization_Load(object sender, EventArgs e)
        {

            textBox1.Text = placeholderText;
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = placeholderText2;
            textBox2.ForeColor = Color.Gray;

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
        // Исчезновение подсказки места для ввода ответа после нажатия не textBox
        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '•';
            if (textBox2.Text == placeholderText2)
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }

        }

        // Появляение подсказки места для ввода ответа после нажатия на другую область экрана
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.Gray;
                textBox2.Text = placeholderText2;
            }
        }

       

        
    }
}
