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
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Random random = new Random();
        int currentProgress = 0;

        private Form2 form2;
        private Form3 form3;
        private Form8 form8;
        private Form9 form9;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            form3 = new Form3(this);
            form8 = new Form8(this);
            form9 = new Form9(this);

            InitializeProgressBar();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void InitializeProgressBar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Visible = false;

            timer.Interval = random.Next(100, 500);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int progressStep = random.Next(1, 10);
            currentProgress += progressStep;

            if (currentProgress >= progressBar1.Maximum)
            {
                currentProgress = progressBar1.Maximum;
                timer.Stop();
                MessageBox.Show("Program jest gotowy do roboty ;)");
                progressBar1.Visible = false;
            }

            progressBar1.Value = currentProgress;

            timer.Interval = random.Next(100, 500);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form8.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentProgress = 0;
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            timer.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D1)
            {
                button1.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D2)
            {
                button2.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D3)
            {
                button3.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D4)
            {
                button4.PerformClick();
            }
        }
    }
}