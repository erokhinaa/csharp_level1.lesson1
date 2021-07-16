using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Lesson8
{
    public partial class Form1 : Form
    {
        // База данных с вопросами
        private TrueFalse database;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            string props = "";
            foreach (var prop in typeof(DateTime).GetProperties())
            {
                props += prop.Name + " ";
            }
            MessageBox.Show(props,"Свойста структуры DateTime");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("Земля круглая?", true);
                database.Save();
                nudNumber.Maximum = 1;
                nudNumber.Minimum = 1;
                nudNumber.Value = 1;
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            };
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Maximum = database.Count;
                nudNumber.Minimum = 1;
                nudNumber.Value = 1;
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database != null)
            {   
                database.Save();
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                    MessageBox.Show($"Файл {sfd.FileName} успешно сохранен", "Работа с базой данных");
            }

            else MessageBox.Show("База данных не создана!","Ошибка сохранения файла");
        }
        
        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            trueFalse.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }
        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("База данных не создана!", "Ошибка сохранения файла");
                return;
            }
            else
            {
                database.Add($"#Вопрос{database.Count + 1}", true);
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                MessageBox.Show("Данные успешно добавлены", "Работа с базой данных");
            }
        }
        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("База данных не создана!", "Ошибка сохранения файла");
                return;
            }
            if (nudNumber.Maximum == 1 || database == null) { MessageBox.Show("Нельзя удалить единственный вопрос", "Работа с базой данных"); ; return; }
            database.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum = database.Count;
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            MessageBox.Show("Данные успешно удалены", "Работа с базой данных");
            
        }
        
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("База данных не создана!", "Ошибка сохранения файла");
                return;
            }
            else
            {
                database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = trueFalse.Checked;
                MessageBox.Show("Данные успешно сохранены", "Работа с базой данных");
            }
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName.ToString() + " " +
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.ToString() + " " +
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(),"О программе");
        }

        
    }

}

