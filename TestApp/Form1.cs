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
<<<<<<< HEAD
            button3.Text = "Kurčić";
            
=======
            MessageBox.Show("Licni mi jajce");
>>>>>>> origin/master
        }
    }
}
