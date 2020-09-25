using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int random_number, trys = 1, user_number;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearAll()
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            random_number = 0; trys = 1; user_number = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll();
            button1.Text = "Сбос";
            button2.Enabled = true;
            textBox2.Enabled = true;
            Random rnd = new Random();
            random_number = 0 + rnd.Next(100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                user_number = Convert.ToInt32(textBox2.Text);
                if (user_number > random_number)
                {
                    textBox2.Clear();
                    textBox4.Text = "Выше число больше. Попытка №" + trys;
                }
                else if (user_number < random_number)
                {
                    textBox2.Clear();
                    textBox4.Text = "Выше число меньше. Попытка №" + trys;
                }
                else
                {
                    MessageBox.Show("Поздравляю! Вы угадали с " + trys + " попытки!");
                    button1.Text = "Начать игру";
                    button2.Enabled = false;
                    textBox2.Enabled = false;
                    ClearAll();
                }
                trys++;
            }
            catch (Exception q)
            {

            }
        }
    }
}
