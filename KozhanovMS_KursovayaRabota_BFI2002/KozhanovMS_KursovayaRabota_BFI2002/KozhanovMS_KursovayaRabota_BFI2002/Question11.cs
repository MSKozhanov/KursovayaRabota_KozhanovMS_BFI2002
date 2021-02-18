using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFI2002_KursovayaRabota_KozhanovMS
{
    public partial class Question11 : Form

    {
        bool[] vibran = new bool[3];
        public Question11()
        {
            InitializeComponent();
        }



        

        private void Question11_Load(object sender, EventArgs e)
        {
            string[] itemlist1 = new string[3];
            itemlist1[0] = "1";
            itemlist1[1] = "8";
            itemlist1[2] = "9";
            for (int j = 0; j <= 2; j++)
                listBox1.Items.Add(itemlist1[j]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vibran[0] = true;
            if (listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vibran[1] = true;
            if (listBox1.SelectedIndex == 0)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vibran[2] = true;
            if (listBox1.SelectedIndex == 0)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
            button5.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vibran.Length; i++)
            {
                if (vibran[i] == false)
                {
                    MessageBox.Show("Вы ответили не на все вопросы", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            if ((listBox2.Text == "") && (listBox3.Text == "") && (listBox4.Text == ""))
                MessageBox.Show("Надо ответить на вопрос!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                if ((listBox2.Items[0] == "1") && (listBox3.Items[0] == "8") && (listBox4.Items[0] == "9"))
                {
                    MessageBox.Show("Вы ответили правильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "1 балл";
                    textBox1.Enabled = false;
                    Program.AddResult("quest11", textBox1.Text);
                    Question12 f = new Question12();
                    this.Hide();
                    f.ShowDialog();
                }
            else
            {
                MessageBox.Show("Вы ответили неправильно!", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "0 баллов";
                textBox1.Enabled = false;
                Program.AddResult("quest11", textBox1.Text);
                Question12 f = new Question12();
                this.Hide();
                f.ShowDialog();
            }
            
        }
    }
}
