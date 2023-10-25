namespace Paint
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            panel1 = new Panel();
            btn_save = new Button();
            btn_clear = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btn_line = new Button();
            btn_color = new Button();
            btn_rect = new Button();
            btn_fill = new Button();
            btn_ellipse = new Button();
            btn_pencil = new Button();
            btn_eraser = new Button();
            pic_color = new Button();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(pic);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 512);
            panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(697, 55);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 12;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(697, 26);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(3, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 76);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btn_line);
            panel2.Controls.Add(btn_color);
            panel2.Controls.Add(btn_rect);
            panel2.Controls.Add(btn_fill);
            panel2.Controls.Add(btn_ellipse);
            panel2.Controls.Add(btn_pencil);
            panel2.Controls.Add(btn_eraser);
            panel2.Location = new Point(237, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 86);
            panel2.TabIndex = 9;
            // 
            // btn_line
            // 
            btn_line.BackColor = Color.FromArgb(64, 64, 64);
            btn_line.BackgroundImage = (Image)resources.GetObject("btn_line.BackgroundImage");
            btn_line.BackgroundImageLayout = ImageLayout.Center;
            btn_line.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btn_line.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.White;
            btn_line.Location = new Point(384, 10);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(57, 65);
            btn_line.TabIndex = 8;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = false;
            btn_line.Click += btn_line_Click;
            // 
            // btn_color
            // 
            btn_color.BackColor = Color.FromArgb(64, 64, 64);
            btn_color.BackgroundImage = (Image)resources.GetObject("btn_color.BackgroundImage");
            btn_color.BackgroundImageLayout = ImageLayout.Center;
            btn_color.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btn_color.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.Location = new Point(6, 11);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(57, 65);
            btn_color.TabIndex = 10;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = false;
            btn_color.Click += btn_color_Click;
            // 
            // btn_rect
            // 
            btn_rect.BackColor = Color.FromArgb(64, 64, 64);
            btn_rect.BackgroundImage = (Image)resources.GetObject("btn_rect.BackgroundImage");
            btn_rect.BackgroundImageLayout = ImageLayout.Center;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btn_rect.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.White;
            btn_rect.Location = new Point(321, 11);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(57, 65);
            btn_rect.TabIndex = 7;
            btn_rect.Text = "Rect";
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = false;
            btn_rect.Click += btn_rect_Click;
            // 
            // btn_fill
            // 
            btn_fill.BackColor = Color.FromArgb(64, 64, 64);
            btn_fill.BackgroundImage = (Image)resources.GetObject("btn_fill.BackgroundImage");
            btn_fill.BackgroundImageLayout = ImageLayout.None;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.White;
            btn_fill.Location = new Point(69, 10);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(57, 65);
            btn_fill.TabIndex = 3;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = false;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_ellipse
            // 
            btn_ellipse.BackColor = Color.FromArgb(64, 64, 64);
            btn_ellipse.BackgroundImage = (Image)resources.GetObject("btn_ellipse.BackgroundImage");
            btn_ellipse.BackgroundImageLayout = ImageLayout.Center;
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = Color.White;
            btn_ellipse.Location = new Point(258, 10);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(57, 65);
            btn_ellipse.TabIndex = 6;
            btn_ellipse.Text = "Ellipse";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = false;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.BackColor = Color.FromArgb(64, 64, 64);
            btn_pencil.BackgroundImage = (Image)resources.GetObject("btn_pencil.BackgroundImage");
            btn_pencil.BackgroundImageLayout = ImageLayout.None;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.White;
            btn_pencil.Location = new Point(132, 11);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(57, 65);
            btn_pencil.TabIndex = 4;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = false;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.BackColor = Color.FromArgb(64, 64, 64);
            btn_eraser.BackgroundImage = (Image)resources.GetObject("btn_eraser.BackgroundImage");
            btn_eraser.BackgroundImageLayout = ImageLayout.None;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.White;
            btn_eraser.Location = new Point(195, 10);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(57, 65);
            btn_eraser.TabIndex = 5;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = false;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(181, 26);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(50, 48);
            pic_color.TabIndex = 1;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Location = new Point(0, 107);
            pic.Name = "pic";
            pic.Size = new Size(784, 392);
            pic.TabIndex = 0;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Paint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(784, 511);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Paint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pic;
        private Button pic_color;
        private Button btn_fill;
        private Button btn_line;
        private Button btn_rect;
        private Button btn_ellipse;
        private Button btn_eraser;
        private Button btn_pencil;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btn_color;
        private Button btn_save;
        private Button btn_clear;
    }
}