using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab.obj
{
    public partial class Form1 : Form
    {
        int seed = 1;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ComplexNumber a1 = new ComplexNumber(seed++);
            ComplexNumber a2 = new ComplexNumber(seed++);
            ComplexNumber a3 = new ComplexNumber(seed++);
            OutA1.Text = a1.PtintNum();
            OutA2.Text = a2.PtintNum();
            OutA3.Text = a3.PtintNum();
            ComplexNumber modul = a2 * a2 * a2 * a2 + (a1 - a2) / a3 * a1;
            OutModul.Text = modul.PtintNum();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void OutputA2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
