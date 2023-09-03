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
            name = new TextBox();
            btn_find = new Button();
            label1 = new Label();
            r_movie = new RadioButton();
            r_series = new RadioButton();
            label3 = new Label();
            combo_date = new ComboBox();
            ListX = new CheckedListBox();
            panel1 = new Panel();
            btn_fav = new Button();
            btn_wt = new Button();
            btn_unwt = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btn_watch = new Button();
            btn_search = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // name
            // 
            name.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(250, 52);
            name.Name = "name";
            name.Size = new Size(158, 30);
            name.TabIndex = 0;
            // 
            // btn_find
            // 
            btn_find.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_find.Location = new Point(250, 88);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(158, 29);
            btn_find.TabIndex = 1;
            btn_find.Text = "Find";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += button1_Click;
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
            // r_movie
            // 
            r_movie.AutoSize = true;
            r_movie.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            r_movie.ForeColor = SystemColors.Window;
            r_movie.Location = new Point(250, 123);
            r_movie.Name = "r_movie";
            r_movie.Size = new Size(77, 27);
            r_movie.TabIndex = 4;
            r_movie.TabStop = true;
            r_movie.Text = "Movie";
            r_movie.UseVisualStyleBackColor = true;
            r_movie.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // r_series
            // 
            r_series.AutoSize = true;
            r_series.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            r_series.ForeColor = SystemColors.Window;
            r_series.Location = new Point(333, 123);
            r_series.Name = "r_series";
            r_series.Size = new Size(75, 27);
            r_series.TabIndex = 5;
            r_series.TabStop = true;
            r_series.Text = "Series";
            r_series.UseVisualStyleBackColor = true;
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
            // combo_date
            // 
            combo_date.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            combo_date.FormattingEnabled = true;
            combo_date.Items.AddRange(new object[] { "1970", "1980", "1990", "2000", "2010", "2020" });
            combo_date.Location = new Point(250, 214);
            combo_date.Name = "combo_date";
            combo_date.Size = new Size(158, 31);
            combo_date.TabIndex = 8;
            // 
            // ListX
            // 
            ListX.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ListX.FormattingEnabled = true;
            ListX.HorizontalScrollbar = true;
            ListX.Location = new Point(6, 9);
            ListX.Name = "ListX";
            ListX.Size = new Size(528, 454);
            ListX.TabIndex = 0;
            ListX.KeyDown += List_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(btn_fav);
            panel1.Controls.Add(btn_wt);
            panel1.Controls.Add(btn_unwt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 513);
            panel1.TabIndex = 10;
            // 
            // btn_fav
            // 
            btn_fav.BackColor = Color.DarkViolet;
            btn_fav.FlatAppearance.BorderColor = Color.DarkViolet;
            btn_fav.FlatStyle = FlatStyle.Flat;
            btn_fav.Font = new Font("Microsoft YaHei Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fav.ForeColor = SystemColors.Window;
            btn_fav.Location = new Point(3, 290);
            btn_fav.Name = "btn_fav";
            btn_fav.Size = new Size(223, 48);
            btn_fav.TabIndex = 5;
            btn_fav.Text = "Favorite List";
            btn_fav.UseVisualStyleBackColor = false;
            // 
            // btn_wt
            // 
            btn_wt.BackColor = Color.DarkViolet;
            btn_wt.FlatAppearance.BorderColor = Color.DarkViolet;
            btn_wt.FlatStyle = FlatStyle.Flat;
            btn_wt.Font = new Font("Microsoft YaHei Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_wt.ForeColor = SystemColors.Window;
            btn_wt.Location = new Point(3, 236);
            btn_wt.Name = "btn_wt";
            btn_wt.Size = new Size(223, 48);
            btn_wt.TabIndex = 3;
            btn_wt.Text = "Watched List";
            btn_wt.UseVisualStyleBackColor = false;
            btn_wt.Click += btn_wt_Click;
            // 
            // btn_unwt
            // 
            btn_unwt.BackColor = Color.DarkViolet;
            btn_unwt.FlatAppearance.BorderColor = Color.DarkViolet;
            btn_unwt.FlatStyle = FlatStyle.Flat;
            btn_unwt.Font = new Font("Microsoft YaHei Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_unwt.ForeColor = SystemColors.Window;
            btn_unwt.Location = new Point(3, 182);
            btn_unwt.Name = "btn_unwt";
            btn_unwt.Size = new Size(223, 48);
            btn_unwt.TabIndex = 2;
            btn_unwt.Text = "Unwatched List";
            btn_unwt.UseVisualStyleBackColor = false;
            btn_unwt.Click += btn_unwt_Click;
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
            // btn_watch
            // 
            btn_watch.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_watch.Location = new Point(250, 268);
            btn_watch.Name = "btn_watch";
            btn_watch.Size = new Size(77, 70);
            btn_watch.TabIndex = 11;
            btn_watch.Text = "Watch";
            btn_watch.UseVisualStyleBackColor = true;
            btn_watch.Click += btn_watch_Click;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Microsoft YaHei Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Location = new Point(333, 268);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(77, 70);
            btn_search.TabIndex = 12;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(ListX);
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
            Controls.Add(btn_search);
            Controls.Add(btn_watch);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(combo_date);
            Controls.Add(r_series);
            Controls.Add(r_movie);
            Controls.Add(label1);
            Controls.Add(btn_find);
            Controls.Add(name);
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

        private TextBox name;
        private Button btn_find;
        private Label label1;
        private RadioButton r_movie;
        private RadioButton r_series;
        private Label label3;
        private ComboBox combo_date;
        private CheckedListBox ListX;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btn_unwt;
        private Button btn_fav;
        private Button btn_wt;
        private Button btn_watch;
        private Button btn_search;
        private Panel panel2;
    }
}