using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADV;

namespace text
{

    public partial class Form1 : Form
    {

        string LastUsedFont = "Arial";//временно хранит шрифт
        float LastUsedSize = 14f;//временно хранит размер
        string NameTitle = "TextEditor";//имя программы
        string path = "";//путь к файлу

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Parent = panel2;
            comboBox1.Items.AddRange(FontFamily.Families.Select(x => x.Name).ToArray<object>());//заполняет комбобокс всеми шрифтами на пк
            comboBox1.Text = richTextBox1.Font.Name;//выбирает активный шрифт
            ColorBtn.BackColor = richTextBox1.ForeColor;//выбирает активный цвет
            comboBox2.Text = Convert.ToInt32(richTextBox1.Font.Size).ToString();//выбирает активный размер
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {//при открытии и выбора пункта в комбобоксе с шрифтами
            int ibegin = richTextBox1.SelectionStart, len = richTextBox1.SelectionLength;
            LastUsedFont = comboBox1.SelectedItem.ToString();
            for (int i = ibegin; i < ibegin + len; i++)
            {//при изменении шрифта выделенного текста, изменяется каждый символ по отдельности
                richTextBox1.Select(i, 1);
                richTextBox1.SelectionFont = new Font(LastUsedFont, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            }
            if (richTextBox1.SelectedText == "")
                richTextBox1.SelectionFont = new Font(LastUsedFont, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            richTextBox1.Select(ibegin, len);
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {//при смене фокуса с комбобокса с размерами
            float tmp = LastUsedSize;
            if (float.TryParse(comboBox2.Text, out LastUsedSize) && LastUsedSize > 0f && LastUsedSize < 1639f)
            {//если указанное значение число и больше нуля и меньше 1639
                int ibegin = richTextBox1.SelectionStart, len = richTextBox1.SelectionLength;
                label1.Text = $"{ibegin} : {len}";
                for (int i = ibegin; i < ibegin + len; i++)
                {//при изменении размера выделенного текста, изменяется каждый символ по отдельности
                    richTextBox1.Select(i, 1);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, LastUsedSize, richTextBox1.SelectionFont.Style);
                }
                if (richTextBox1.SelectedText == "")
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, LastUsedSize, richTextBox1.SelectionFont.Style);
                richTextBox1.Select(ibegin, len);
            }
            else
            {//иначе возвращаем все назад
                LastUsedSize = tmp;
                comboBox2.Text = tmp.ToString();
            }
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {//при отпускании кнопки на поверхности текста - определяются шрифт, размер и стили
            try
            {
                comboBox1.Text = richTextBox1.SelectionFont.Name;
            }
            catch
            {
                comboBox1.Text = "";
            }
            try
            {
                comboBox2.Text = Convert.ToInt32(richTextBox1.SelectionFont.Size).ToString();
            }
            catch
            {
                comboBox2.Text = "";
            }
            BoldBtn.FlatStyle = FlatStyle.Flat;
            ItalicBtn.FlatStyle = FlatStyle.Flat;
            UnderBtn.FlatStyle = FlatStyle.Flat;
            StrikeBtn.FlatStyle = FlatStyle.Flat;
            if (richTextBox1.SelectionFont == null)
            {
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            else
            {
                Font tmp = richTextBox1.SelectionFont;
                if (tmp.Bold)
                    BoldBtn.FlatStyle = FlatStyle.Popup;
                if (tmp.Italic)
                    ItalicBtn.FlatStyle = FlatStyle.Popup;
                if (tmp.Underline)
                    UnderBtn.FlatStyle = FlatStyle.Popup;
                if (tmp.Strikeout)
                    StrikeBtn.FlatStyle = FlatStyle.Popup;
                int ibegin = richTextBox1.SelectionStart, len = richTextBox1.SelectionLength;
                for (int i = ibegin; i < ibegin + len; i++)
                {
                    richTextBox1.Select(i, 1);
                    if (tmp.Name != richTextBox1.SelectionFont.Name)
                        comboBox1.Text = "";
                    if (tmp.Size != richTextBox1.SelectionFont.Size)
                        comboBox2.Text = "";
                }
                richTextBox1.Select(ibegin, len);
            }
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {//удаление действия
            richTextBox1.Undo();
        }

        private void RedoBtn_Click(object sender, EventArgs e)
        {//возвращение действия
            if (richTextBox1.CanRedo)
                richTextBox1.Redo();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(comboBox1.Text))//если указанного шрифта нету с списке
                comboBox1.Text = LastUsedFont;
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {//изменение цвета текста
                richTextBox1.SelectionColor = colorDialog1.Color;
                ColorBtn.BackColor = colorDialog1.Color;
            }
        }

        private void BackColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {//изменение цвета фона текста
                richTextBox1.SelectionBackColor = colorDialog2.Color;
                BackColorBtn.BackColor = colorDialog2.Color;
            }
        }

        private void ChangeFontStyle_Click(object sender, EventArgs e)
        {//смена стиля выбранного текста
            Button b = (Button)sender;//определяется какая именно нажата кнопка
            FontStyle fs = FontStyle.Regular;//конструкция далее, определит стиль шрифта с такими нажатыми кнопками
            if (BoldBtn.FlatStyle == FlatStyle.Popup)
                fs |= FontStyle.Bold;
            if (ItalicBtn.FlatStyle == FlatStyle.Popup)
                fs |= FontStyle.Italic;
            if (UnderBtn.FlatStyle == FlatStyle.Popup)
                fs |= FontStyle.Underline;
            if (StrikeBtn.FlatStyle == FlatStyle.Popup)
                fs |= FontStyle.Strikeout;
            int ibegin = richTextBox1.SelectionStart, len = richTextBox1.SelectionLength;
            label1.Text = $"{ibegin} : {len}";
            for (int i = ibegin; i < ibegin + len; i++)
            {//при изменении стиля выделенного текста, изменяется каждый символ по отдельности
                richTextBox1.Select(i, 1);
                FontStyle fss = richTextBox1.SelectionFont.Style | FontStyle.Regular;//определяет стиль для очередного символа
                if (b.FlatStyle == FlatStyle.Flat)
                {//прибавление стилей
                    if (b.Text == "B")
                        fss |= FontStyle.Bold;
                    else if (b.Text == "I")
                        fss |= FontStyle.Italic;
                    else if (b.Text == "U")
                        fss |= FontStyle.Underline;
                    else if (b.Text == "ab")
                        fss |= FontStyle.Strikeout;
                }
                else if (b.FlatStyle == FlatStyle.Popup)
                {//вычитание стилей
                    if (b.Text == "B")
                        fss ^= FontStyle.Bold;
                    else if (b.Text == "I")
                        fss ^= FontStyle.Italic;
                    else if (b.Text == "U")
                        fss ^= FontStyle.Underline;
                    else if (b.Text == "ab")
                        fss ^= FontStyle.Strikeout;
                }
                 richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, fss);
            }
            if (richTextBox1.SelectedText == "")
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, fs);
            if (b.FlatStyle == FlatStyle.Flat)
                b.FlatStyle = FlatStyle.Popup;
            else if (b.FlatStyle == FlatStyle.Popup)
                b.FlatStyle = FlatStyle.Flat;
            richTextBox1.Select(ibegin, len);
        }

        private void ChangeAlignment_Click(object sender, EventArgs e)
        {//изменение выравнивания
            Button b = (Button)sender;
            if (b.Tag == (object)"left")
                richTextBox1.SelectionAlignment = TextAlign.Left;
            else if (b.Tag == (object)"center")
                richTextBox1.SelectionAlignment = TextAlign.Center;
            else if (b.Tag == (object)"right")
                richTextBox1.SelectionAlignment = TextAlign.Right;
            else if (b.Tag == (object)"justify")
                richTextBox1.SelectionAlignment = TextAlign.Justify;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {//закрытие файла
            path = "";
            richTextBox1.Clear();
            Text = NameTitle;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {//сохранение как файла
            saveFileDialog1.FileName = path.Split('\\').Last();
            saveFileDialog1.Filter = "Rich Text Format (*.rtf;)|*.rtf;";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                path = saveFileDialog1.FileName;//сохраняет путь и имя выбранного файла
                richTextBox1.SaveFile(path);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {//открытие файла
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Rich Text Format (*.rtf;)|*.rtf;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                closeToolStripMenuItem.PerformClick();
                path = openFileDialog1.FileName;//сохраняет путь и имя выбранного файла
                Text = path.Split('\\').Last() + $" - {NameTitle}";
                try
                {
                    richTextBox1.LoadFile(path);
                }
                catch
                {
                    MessageBox.Show("The process cannot access the file");
                    path = "";
                    Text = NameTitle;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {//сохранение файла
            if (path != "")//если есть путь
                richTextBox1.SaveFile(path);
            else//если нет - сохранение как
                saveAsToolStripMenuItem.PerformClick();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {//обновление текста
            richTextBox1.Update();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {//выход
            Application.Exit();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {//выбор элемента из комбобокса с размерами
            comboBox2_Leave(sender, e);
        }
    }

}
