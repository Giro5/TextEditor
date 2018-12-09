namespace text
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.JustifyAl = new System.Windows.Forms.Button();
            this.RightAl = new System.Windows.Forms.Button();
            this.CenterAl = new System.Windows.Forms.Button();
            this.LeftAl = new System.Windows.Forms.Button();
            this.StrikeBtn = new System.Windows.Forms.Button();
            this.UnderBtn = new System.Windows.Forms.Button();
            this.ItalicBtn = new System.Windows.Forms.Button();
            this.BoldBtn = new System.Windows.Forms.Button();
            this.BackColorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RedoBtn = new System.Windows.Forms.Button();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new ADV.AdvRichTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.JustifyAl);
            this.panel1.Controls.Add(this.RightAl);
            this.panel1.Controls.Add(this.CenterAl);
            this.panel1.Controls.Add(this.LeftAl);
            this.panel1.Controls.Add(this.StrikeBtn);
            this.panel1.Controls.Add(this.UnderBtn);
            this.panel1.Controls.Add(this.ItalicBtn);
            this.panel1.Controls.Add(this.BoldBtn);
            this.panel1.Controls.Add(this.BackColorBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RedoBtn);
            this.panel1.Controls.Add(this.UndoBtn);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.ColorBtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 2;
            // 
            // JustifyAl
            // 
            this.JustifyAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.JustifyAl.FlatAppearance.BorderSize = 0;
            this.JustifyAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JustifyAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JustifyAl.Image = global::text.Properties.Resources.icons8_Align_Justify_20px;
            this.JustifyAl.Location = new System.Drawing.Point(371, 30);
            this.JustifyAl.Name = "JustifyAl";
            this.JustifyAl.Size = new System.Drawing.Size(23, 23);
            this.JustifyAl.TabIndex = 14;
            this.JustifyAl.Tag = "justify";
            this.JustifyAl.UseVisualStyleBackColor = false;
            this.JustifyAl.Click += new System.EventHandler(this.ChangeAlignment_Click);
            // 
            // RightAl
            // 
            this.RightAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RightAl.FlatAppearance.BorderSize = 0;
            this.RightAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightAl.Image = global::text.Properties.Resources.icons8_Align_Right_20px;
            this.RightAl.Location = new System.Drawing.Point(342, 30);
            this.RightAl.Name = "RightAl";
            this.RightAl.Size = new System.Drawing.Size(23, 23);
            this.RightAl.TabIndex = 13;
            this.RightAl.Tag = "right";
            this.RightAl.UseVisualStyleBackColor = false;
            this.RightAl.Click += new System.EventHandler(this.ChangeAlignment_Click);
            // 
            // CenterAl
            // 
            this.CenterAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CenterAl.FlatAppearance.BorderSize = 0;
            this.CenterAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CenterAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CenterAl.Image = global::text.Properties.Resources.icons8_Align_Center_20px;
            this.CenterAl.Location = new System.Drawing.Point(313, 30);
            this.CenterAl.Name = "CenterAl";
            this.CenterAl.Size = new System.Drawing.Size(23, 23);
            this.CenterAl.TabIndex = 12;
            this.CenterAl.Tag = "center";
            this.CenterAl.UseVisualStyleBackColor = false;
            this.CenterAl.Click += new System.EventHandler(this.ChangeAlignment_Click);
            // 
            // LeftAl
            // 
            this.LeftAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LeftAl.FlatAppearance.BorderSize = 0;
            this.LeftAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftAl.Image = global::text.Properties.Resources.icons8_Align_Left_20px;
            this.LeftAl.Location = new System.Drawing.Point(284, 30);
            this.LeftAl.Name = "LeftAl";
            this.LeftAl.Size = new System.Drawing.Size(23, 23);
            this.LeftAl.TabIndex = 11;
            this.LeftAl.Tag = "left";
            this.LeftAl.UseVisualStyleBackColor = false;
            this.LeftAl.Click += new System.EventHandler(this.ChangeAlignment_Click);
            // 
            // StrikeBtn
            // 
            this.StrikeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StrikeBtn.FlatAppearance.BorderSize = 0;
            this.StrikeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StrikeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StrikeBtn.Location = new System.Drawing.Point(197, 30);
            this.StrikeBtn.Name = "StrikeBtn";
            this.StrikeBtn.Size = new System.Drawing.Size(23, 23);
            this.StrikeBtn.TabIndex = 10;
            this.StrikeBtn.Tag = "";
            this.StrikeBtn.Text = "ab";
            this.StrikeBtn.UseVisualStyleBackColor = false;
            this.StrikeBtn.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // UnderBtn
            // 
            this.UnderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UnderBtn.FlatAppearance.BorderSize = 0;
            this.UnderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnderBtn.Location = new System.Drawing.Point(168, 30);
            this.UnderBtn.Name = "UnderBtn";
            this.UnderBtn.Size = new System.Drawing.Size(23, 23);
            this.UnderBtn.TabIndex = 9;
            this.UnderBtn.Tag = "";
            this.UnderBtn.Text = "U";
            this.UnderBtn.UseVisualStyleBackColor = false;
            this.UnderBtn.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // ItalicBtn
            // 
            this.ItalicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ItalicBtn.FlatAppearance.BorderSize = 0;
            this.ItalicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItalicBtn.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItalicBtn.Location = new System.Drawing.Point(139, 30);
            this.ItalicBtn.Name = "ItalicBtn";
            this.ItalicBtn.Size = new System.Drawing.Size(23, 23);
            this.ItalicBtn.TabIndex = 8;
            this.ItalicBtn.Tag = "";
            this.ItalicBtn.Text = "I";
            this.ItalicBtn.UseVisualStyleBackColor = false;
            this.ItalicBtn.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // BoldBtn
            // 
            this.BoldBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BoldBtn.FlatAppearance.BorderSize = 0;
            this.BoldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoldBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoldBtn.Location = new System.Drawing.Point(110, 30);
            this.BoldBtn.Name = "BoldBtn";
            this.BoldBtn.Size = new System.Drawing.Size(23, 23);
            this.BoldBtn.TabIndex = 7;
            this.BoldBtn.Tag = "";
            this.BoldBtn.Text = "B";
            this.BoldBtn.UseVisualStyleBackColor = false;
            this.BoldBtn.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // BackColorBtn
            // 
            this.BackColorBtn.BackColor = System.Drawing.Color.White;
            this.BackColorBtn.FlatAppearance.BorderSize = 0;
            this.BackColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackColorBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackColorBtn.Location = new System.Drawing.Point(226, 30);
            this.BackColorBtn.Name = "BackColorBtn";
            this.BackColorBtn.Size = new System.Drawing.Size(23, 23);
            this.BackColorBtn.TabIndex = 6;
            this.BackColorBtn.Text = "A";
            this.BackColorBtn.UseVisualStyleBackColor = false;
            this.BackColorBtn.Click += new System.EventHandler(this.BackColorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.label1.Location = new System.Drawing.Point(608, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // RedoBtn
            // 
            this.RedoBtn.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.RedoBtn.Location = new System.Drawing.Point(56, 3);
            this.RedoBtn.Name = "RedoBtn";
            this.RedoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RedoBtn.Size = new System.Drawing.Size(48, 30);
            this.RedoBtn.TabIndex = 4;
            this.RedoBtn.Text = "";
            this.RedoBtn.UseVisualStyleBackColor = true;
            this.RedoBtn.Click += new System.EventHandler(this.RedoBtn_Click);
            // 
            // UndoBtn
            // 
            this.UndoBtn.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.UndoBtn.Location = new System.Drawing.Point(3, 3);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(48, 30);
            this.UndoBtn.TabIndex = 3;
            this.UndoBtn.Text = "";
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.comboBox2.Location = new System.Drawing.Point(326, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(68, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            this.comboBox2.Leave += new System.EventHandler(this.comboBox2_Leave);
            // 
            // ColorBtn
            // 
            this.ColorBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ColorBtn.FlatAppearance.BorderSize = 2;
            this.ColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorBtn.Location = new System.Drawing.Point(255, 30);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(23, 23);
            this.ColorBtn.TabIndex = 1;
            this.ColorBtn.UseVisualStyleBackColor = false;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 627);
            this.panel2.TabIndex = 3;
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.White;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(267, 13);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.SelectionAlignment = ADV.TextAlign.Left;
            this.richTextBox1.Size = new System.Drawing.Size(630, 600);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 751);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TextEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button RedoBtn;
        private System.Windows.Forms.Button UndoBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackColorBtn;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button UnderBtn;
        private System.Windows.Forms.Button ItalicBtn;
        private System.Windows.Forms.Button BoldBtn;
        private System.Windows.Forms.Button StrikeBtn;
        private System.Windows.Forms.Button JustifyAl;
        private System.Windows.Forms.Button RightAl;
        private System.Windows.Forms.Button CenterAl;
        private System.Windows.Forms.Button LeftAl;
        private ADV.AdvRichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

