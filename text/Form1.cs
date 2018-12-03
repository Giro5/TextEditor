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

        string LastUsedFont = "Arial";
        float LastUsedSize = 14f;
        string NameTitle = "TextEditor", path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Parent = panel2;
            comboBox1.Items.AddRange(FontFamily.Families.Select(x => x.Name).ToArray<object>());
            comboBox1.Text = richTextBox1.Font.Name;
            ColorBtn.BackColor = richTextBox1.ForeColor;
            comboBox2.Text = Convert.ToInt32(richTextBox1.Font.Size).ToString();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int ibegin = richTextBox1.SelectionStart, len = richTextBox1.SelectionLength;
            label1.Text = $"{ibegin} : {len}";
            LastUsedFont = comboBox1.SelectedItem.ToString();
            for (int i = ibegin; i < ibegin + len; i++)
            {
                richTextBox1.Select(i, 1);
                richTextBox1.SelectionFont = new Font(LastUsedFont, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style/*, GraphicsUnit.Point, ((byte)(204))*/);
            }
            if (richTextBox1.SelectedText == "")
            {
                richTextBox1.SelectionFont = new Font(LastUsedFont, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style/*, GraphicsUnit.Point, ((byte)(204))*/);
            }
            richTextBox1.Select(ibegin, len);
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            float tmp = LastUsedSize;
            if (float.TryParse(comboBox2.Text, out LastUsedSize) && LastUsedSize != 0f && LastUsedSize < 1639f)
            {
                int ibegin = richTextBox1.SelectionStart, len = richTextBox1.SelectionLength;
                label1.Text = $"{ibegin} : {len}";
                for (int i = ibegin; i < ibegin + len; i++)
                {
                    richTextBox1.Select(i, 1);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, LastUsedSize, richTextBox1.SelectionFont.Style/*, GraphicsUnit.Point, ((byte)(204))*/);
                }
                if (richTextBox1.SelectedText == "")
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, LastUsedSize, richTextBox1.SelectionFont.Style/*, GraphicsUnit.Point, ((byte)(204))*/);
                richTextBox1.Select(ibegin, len);
            }
            else
            {
                LastUsedSize = tmp;
                comboBox2.Text = tmp.ToString();
            }
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
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
        {
            richTextBox1.Undo();
        }

        private void RedoBtn_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.CanRedo)
                return;
            richTextBox1.Redo();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                label1.Text = LastUsedFont;
                comboBox1.Text = LastUsedFont;
            }
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                ColorBtn.BackColor = colorDialog1.Color;
            }
        }

        private void BackColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog2.Color;
                BackColorBtn.BackColor = colorDialog2.Color;
            }
        }

        private void ChangeFontStyle_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            FontStyle fs = FontStyle.Regular;
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
            {
                richTextBox1.Select(i, 1);

                FontStyle fss = richTextBox1.SelectionFont.Style | FontStyle.Regular;
                if (b.FlatStyle == FlatStyle.Flat)
                {
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
                {
                    if (b.Text == "B")
                        fss ^= FontStyle.Bold;
                    else if (b.Text == "I")
                        fss ^= FontStyle.Italic;
                    else if (b.Text == "U")
                        fss ^= FontStyle.Underline;
                    else if (b.Text == "ab")
                        fss ^= FontStyle.Strikeout;
                }
                 richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, fss/*, GraphicsUnit.Point, ((byte)(204))*/);
            }
            if (richTextBox1.SelectedText == "")
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, fs/*, GraphicsUnit.Point, ((byte)(204))*/);
            if (b.FlatStyle == FlatStyle.Flat)
                b.FlatStyle = FlatStyle.Popup;
            else if (b.FlatStyle == FlatStyle.Popup)
                b.FlatStyle = FlatStyle.Flat;
            richTextBox1.Select(ibegin, len);
        }

        private void ChangeAlignment_Click(object sender, EventArgs e)
        {
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
        {
            path = "";
            richTextBox1.Clear();
            Text = NameTitle;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = path.Split('\\').Last();
            saveFileDialog1.Filter = "Rich Text Format (*.rtf;)|*.rtf;";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                path = saveFileDialog1.FileName;//сохраняет путь и имя выбранного файла
                richTextBox1.SaveFile(path);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        {
            if (path != "")
                richTextBox1.SaveFile(path);
            else
                saveAsToolStripMenuItem.PerformClick();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2_Leave(new object(), new EventArgs());
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Update();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
