using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaeblo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                if (x > 0 && y > 0)
                {
                    MessageBox.Show("Точка лежит в I координатной четверти");
                }
                else if (x > 0 && y < 0)
                    MessageBox.Show("Точка лежит в IV координатной четверти");
                else if (x < 0 && y > 0)
                    MessageBox.Show("Точка лежит в II координатной четверти");
                else if (x < 0 && y < 0)
                    MessageBox.Show("Точка лежит в III координатной четверти");
                else if (x == 0 && y == 0)
                {
                    MessageBox.Show("Вы в центре системы координат");
                }
                else if (x == 0 && y > 0)
                {
                    MessageBox.Show("Точка между 1 и 2 координатной четвертью");
                }
                else if (x < 0 && y == 0)
                {
                    MessageBox.Show("Точка между 2 и 3  координатной четвертью");
                }
                else if (x == 0 && y < 0)
                {
                    MessageBox.Show("Точка между 3 и  4 координатной четвертью");
                }
                else if (x > 0 && y == 0)
                {
                    MessageBox.Show("Точка между 1 и  4 координатной четвертью");
                }
            }
        }
    }
}