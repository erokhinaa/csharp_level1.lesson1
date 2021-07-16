using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblcountComm.Text = (int.Parse(lblcountComm.Text) + 1).ToString();

            if (int.Parse(lblNumber.Text) > int.Parse(lblFinish.Text))
            {
                MessageBox.Show($"Вы проиграли. Ваше число больше {lblFinish.Text}");
                Random rnd = new Random();
                int r = rnd.Next(1, 1000000);
                MessageBox.Show($"Вы должны набрать число {r}");
                lblFinish.Text = r.ToString();
                lblNumber.Text = "1";
                lblcountComm.Text = "0";
            }
            if (int.Parse(lblNumber.Text) == int.Parse(lblFinish.Text))
            {
                MessageBox.Show($"Поздравляю! Вы выиграли!");
                Random rnd = new Random();
                int r = rnd.Next(1, 1000000);
                MessageBox.Show($"Вы должны набрать число {r}");
                lblFinish.Text = r.ToString();
                lblNumber.Text = "1";
                lblcountComm.Text = "0";
            }

        }
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblcountComm.Text = (int.Parse(lblcountComm.Text) + 1).ToString();

            if(int.Parse(lblNumber.Text) > int.Parse(lblFinish.Text))
            {
                MessageBox.Show($"Вы проиграли. Ваше число больше {lblFinish.Text}");
                Random rnd = new Random();
                int r = rnd.Next(1, 1000000);
                MessageBox.Show($"Вы должны набрать число {r}");
                lblFinish.Text = r.ToString();
                lblNumber.Text = "1";
                lblcountComm.Text = "0";
            }
            if (int.Parse(lblNumber.Text) == int.Parse(lblFinish.Text))
            {
                MessageBox.Show($"Поздравляю! Вы выиграли!");
                Random rnd = new Random();
                int r = rnd.Next(1, 1000000);
                MessageBox.Show($"Вы должны набрать число {r}");
                lblFinish.Text = r.ToString();
                lblNumber.Text = "1";
                lblcountComm.Text = "0";
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblcountComm.Text = "0";
        }

        private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblcountComm.Text = "0";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 1000000);
            MessageBox.Show($"Вы должны набрать число {r}");
            lblFinish.Text = r.ToString();
            lblNumber.Text = "1";
            lblcountComm.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 1000000);
            MessageBox.Show($"Вы должны набрать число {r}");
            lblFinish.Text = r.ToString();
            lblNumber.Text = "1";
            lblcountComm.Text = "0";
        }
    }
}
