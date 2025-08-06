using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appka
{
    public partial class Form8 : Form
    {
        private Form1 form1;
        public Form8(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
