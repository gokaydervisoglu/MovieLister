namespace MovieListerX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            comboBox2 = new ComboBox();
            List = new CheckedListBox();
            panel1 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(250, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 30);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(250, 88);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 1;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(280, 29);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 3;
            label1.Text = "Enter Name:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = SystemColors.Window;
            radioButton1.Location = new Point(250, 123);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 27);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Movie";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.Window;
            radioButton2.Location = new Point(333, 123);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 27);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Series";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(273, 188);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 9;
            label3.Text = "Date (?-2023)";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1970", "1980", "1990", "2000", "2010", "2020" });
            comboBox2.Location = new Point(250, 214);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(158, 31);
            comboBox2.TabIndex = 8;
            // 
            // List
            // 
            List.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            List.FormattingEnabled = true;
            List.HorizontalScrollbar = true;
            List.Location = new Point(6, 9);
            List.Name = "List";
            List.Size = new Size(528, 454);
            List.TabIndex = 0;
            List.KeyDown += List_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 513);
            panel1.TabIndex = 10;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkViolet;
            button5.FlatAppearance.BorderColor = Color.DarkViolet;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft YaHei Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Window;
            button5.Location = new Point(3, 290);
            button5.Name = "button5";
            button5.Size = new Size(223, 48);
            button5.TabIndex = 5;
            button5.Text = "Favorite List";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkViolet;
            button3.FlatAppearance.BorderColor = Color.DarkViolet;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft YaHei Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(3, 236);
            button3.Name = "button3";
            button3.Size = new Size(223, 48);
            button3.TabIndex = 3;
            button3.Text = "Unwatched List";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkViolet;
            button2.FlatAppearance.BorderColor = Color.DarkViolet;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(3, 182);
            button2.Name = "button2";
            button2.Size = new Size(223, 48);
            button2.TabIndex = 2;
            button2.Text = "Watched List";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei Light", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(78, 135);
            label2.Name = "label2";
            label2.Size = new Size(57, 30);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_149071;
            pictureBox1.Location = new Point(53, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(250, 268);
            button4.Name = "button4";
            button4.Size = new Size(77, 70);
            button4.TabIndex = 11;
            button4.Text = "Watch";
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(333, 268);
            button6.Name = "button6";
            button6.Size = new Size(77, 70);
            button6.TabIndex = 12;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(List);
            panel2.Location = new Point(452, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 473);
            panel2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MediumOrchid;
            ClientSize = new Size(995, 513);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Lister";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private ComboBox comboBox2;
        private CheckedListBox List;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button5;
        private Button button3;
        private Button button4;
        private Button button6;
        private Panel panel2;
    }
}