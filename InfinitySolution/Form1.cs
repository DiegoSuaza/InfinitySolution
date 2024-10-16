using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinitySolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 registro = new Form2();
            registro.Show();
            this.Dispose(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 panel = new Form3();
            panel.Show();
            this.Dispose(false);
        }
    }
}
