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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int num;
            int r;
            Random rnd = new Random();
            r = rnd.Next(1,100);
            num = int.Parse(boxNum.Text);

            if (num > r) MessageBox.Show("Ваше число больше загаданного");
            else if (num < r) MessageBox.Show("Ваше число меньше загаданного");
            else MessageBox.Show("Поздравляю! Вы угадали");
        }
    }
}
