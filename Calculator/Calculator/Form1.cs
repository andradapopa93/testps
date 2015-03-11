using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;

            try 
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                suma = a + b;

                Form2 rez = new Form2(suma.ToString());
                rez.Show();
            }
            catch(Exception exceptie)
            {
                MessageBox.Show("Datele introduse nu sunt corecte!");
            }
        }
    }
}
