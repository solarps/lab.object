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
        public struct numbers
        {
        public double a;
        };
        public numbers[] A=new numbers [3];
        //public double A1 { get => a1; set => a1 = value; }
        //public double A2 { get => a2; set => a2 = value; }
        //public double A3 { get => a3; set => a3 = value; }

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
            ComplexNumber Number = new ComplexNumber();
            Number.calculation();
            OutputA1.Text += A[0].a;
            OutputA2.Text += A[1].a;
            OutputA3.Text += A[2].a;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
