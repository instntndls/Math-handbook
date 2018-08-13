using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проектная_работа
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            f2.Show();
            System.Threading.Thread.Sleep(2000);
            this.Opacity = 100;
            f2.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Вы уверены что хотите выйти?";
            string caption = "Закрытие";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons);
            if (result == DialogResult.No) e.Cancel = true;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void дискримиантToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control & e.KeyCode == Keys.Q) this.Close();
            if (e.Control & e.KeyCode == Keys.D) f3.Show();
            if (e.Control & e.KeyCode == Keys.R) f4.Show();
            if (e.Control & e.KeyCode == Keys.F) f5.Show();
        }

        private void вычислениеКорнейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void формулыСокращённогоУмноженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.Show();     
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Michail Farnosov \n12.08.2018 \nVersion 0.1");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    myStream.Close();
                }
            }
        }
    }
}
