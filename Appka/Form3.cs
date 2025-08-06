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
    public partial class Form3 : Form
    {

        private Form1 form1;
        private Form4 form4;
        private Form5 form5;
        private Form6 form6;
        private Form7 form7;

        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            form4 = new Form4(this);
            form5 = new Form5(this);
            form6 = new Form6(this);
            form7 = new Form7(this);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form7.Show();
        }
    }
}
