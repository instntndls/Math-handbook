using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проектная_работа
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = (b * b) - (4 * a * c);
            label9.Text = Convert.ToString(d);
            label10.Text = Convert.ToString(-b + Math.Sqrt(d) / (2 * a));
            label11.Text = Convert.ToString(-b - Math.Sqrt(d) / (2 * a));
            if (label10.Text == "NaN" & label11.Text == "NaN")
            {
                label12.Text = "Нет корней";
            }
            else label12.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == (char)8) return;
            if (e.KeyChar == '-') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((((TextBox)sender).Text.IndexOf(',') != -1) || (((TextBox)sender).Text.Length == 0)) e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (sender.Equals(textBox1)) textBox2.Focus();
                if (sender.Equals(textBox2)) textBox3.Focus();
                if (sender.Equals(textBox3)) button1.Focus();
            }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == (char)8) return;
            if (e.KeyChar == '-') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((((TextBox)sender).Text.IndexOf(',') != -1) || (((TextBox)sender).Text.Length == 0)) e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (sender.Equals(textBox1)) textBox2.Focus();
                if (sender.Equals(textBox2)) textBox3.Focus();
                if (sender.Equals(textBox3)) button1.Focus();
            }
            e.Handled = true;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == (char)8) return;
            if (e.KeyChar == '-') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((((TextBox)sender).Text.IndexOf(',') != -1) || (((TextBox)sender).Text.Length == 0)) e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (sender.Equals(textBox1)) textBox2.Focus();
                if (sender.Equals(textBox2)) textBox3.Focus();
                if (sender.Equals(textBox3)) button1.Focus();
            }
            e.Handled = true;
        }
    }
}
