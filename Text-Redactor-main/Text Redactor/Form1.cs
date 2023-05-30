using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Redactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }
            richTextBox.Clear();
        }

        private void сервисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select(); // выравнивание только выделенного текста
            richTextBox.SelectAll(); //выделение всего текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.DeselectAll(); //Отмена выделения
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox.Text = null;
        }

        private void buttonColour_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox.ForeColor = MyDialog.Color;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonCut_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }
            richTextBox.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }
        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.DeselectAll();
        }

        private void слеваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.DeselectAll();
        }

        private void справаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox.DeselectAll();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }
        private void настройкиПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog2.ShowDialog();
        }

        private void ПредварительныйпросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void buttonTet_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBox.Font;
            fontDialog1.Color = richTextBox.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.Font = fontDialog1.Font;
                richTextBox.ForeColor = fontDialog1.Color;
            }
        }
    }
}
