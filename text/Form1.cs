using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(FontFamily.Families.Select(x => x.Name).ToArray<object>());
            comboBox1.Text = richTextBox1.Font.Name;
            button1.BackColor = richTextBox1.ForeColor;
            comboBox2.Text = Convert.ToInt32(richTextBox1.Font.Size).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //richTextBox1.Font = new Font(comboBox1.SelectedItem.ToString(), (float)comboBox2.SelectedItem/*, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))*/);
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            //richTextBox1.Font = new Font(comboBox1.Text, richTextBox1.Font.Size/*, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))*/);
            //label1.Text = comboBox1.Text;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(comboBox1.SelectedItem.ToString(), richTextBox1.Font.Size/*, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))*/);
            label1.Text = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            float fl;
            if (float.TryParse(comboBox2.Text, out fl) && Convert.ToSingle(comboBox2.Text) != 0)
                richTextBox1.Font = new Font(richTextBox1.Font.Name, Convert.ToSingle(comboBox2.Text)/*, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))*/);

        }
    }
}
