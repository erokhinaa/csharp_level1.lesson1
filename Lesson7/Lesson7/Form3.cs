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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            
        }

       
        private void btnTry_Click(object sender, EventArgs e)
        {
            
            int num;
            num = int.Parse(boxNum.Text);

            if (num > Form1.gn) MessageBox.Show("Ваше число больше загаданного");
            else if (num < Form1.gn) MessageBox.Show("Ваше число меньше загаданного");
            else MessageBox.Show("Поздравляю! Вы угадали");
        }
    }
}
