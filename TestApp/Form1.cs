using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crkni!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puši kurac");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Kurčić";

                Random x = new Random();
                Random y = new Random();
                Point tocka = new Point();
                tocka.X = int.Parse(x.Next(200).ToString());
                tocka.Y = int.Parse(y.Next(200).ToString());
                button3.Location = tocka;

        }
    }
}
