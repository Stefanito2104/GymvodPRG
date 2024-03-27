namespace Malování
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Elipse = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Erase = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.Pencil = new System.Windows.Forms.Button();
            this.DrawBoard = new System.Windows.Forms.PictureBox();
            this.ColorChoose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.ColorChoose);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Line);
            this.panel1.Controls.Add(this.Elipse);
            this.panel1.Controls.Add(this.Rectangle);
            this.panel1.Controls.Add(this.Erase);
            this.panel1.Controls.Add(this.Fill);
            this.panel1.Controls.Add(this.Pencil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 117);
            this.panel1.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1029, 64);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(116, 34);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1029, 20);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(116, 35);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Line
            // 
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.Location = new System.Drawing.Point(838, 13);
            this.Line.Margin = new System.Windows.Forms.Padding(4);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(88, 93);
            this.Line.TabIndex = 6;
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Elipse
            // 
            this.Elipse.Image = ((System.Drawing.Image)(resources.GetObject("Elipse.Image")));
            this.Elipse.Location = new System.Drawing.Point(742, 13);
            this.Elipse.Margin = new System.Windows.Forms.Padding(4);
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(88, 93);
            this.Elipse.TabIndex = 5;
            this.Elipse.UseVisualStyleBackColor = true;
            this.Elipse.Click += new System.EventHandler(this.Elipse_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.Location = new System.Drawing.Point(646, 13);
            this.Rectangle.Margin = new System.Windows.Forms.Padding(4);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(88, 93);
            this.Rectangle.TabIndex = 4;
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Erase
            // 
            this.Erase.Image = ((System.Drawing.Image)(resources.GetObject("Erase.Image")));
            this.Erase.Location = new System.Drawing.Point(550, 13);
            this.Erase.Margin = new System.Windows.Forms.Padding(4);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(88, 93);
            this.Erase.TabIndex = 3;
            this.Erase.UseVisualStyleBackColor = true;
            this.Erase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // Fill
            // 
            this.Fill.Image = ((System.Drawing.Image)(resources.GetObject("Fill.Image")));
            this.Fill.Location = new System.Drawing.Point(454, 13);
            this.Fill.Margin = new System.Windows.Forms.Padding(4);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(88, 93);
            this.Fill.TabIndex = 2;
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // Pencil
            // 
            this.Pencil.Image = ((System.Drawing.Image)(resources.GetObject("Pencil.Image")));
            this.Pencil.Location = new System.Drawing.Point(358, 13);
            this.Pencil.Margin = new System.Windows.Forms.Padding(4);
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(88, 93);
            this.Pencil.TabIndex = 1;
            this.Pencil.UseVisualStyleBackColor = true;
            this.Pencil.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // DrawBoard
            // 
            this.DrawBoard.BackColor = System.Drawing.Color.White;
            this.DrawBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawBoard.Location = new System.Drawing.Point(0, 0);
            this.DrawBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawBoard.Name = "DrawBoard";
            this.DrawBoard.Size = new System.Drawing.Size(1182, 653);
            this.DrawBoard.TabIndex = 1;
            this.DrawBoard.TabStop = false;
            this.DrawBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBoard_Paint);
            this.DrawBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawBoard_MouseClick);
            this.DrawBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawBoard_MouseDown);
            this.DrawBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawBoard_MouseMove);
            this.DrawBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawBoard_MouseUp);
            // 
            // ColorChoose
            // 
            this.ColorChoose.Image = ((System.Drawing.Image)(resources.GetObject("ColorChoose.Image")));
            this.ColorChoose.Location = new System.Drawing.Point(262, 13);
            this.ColorChoose.Margin = new System.Windows.Forms.Padding(4);
            this.ColorChoose.Name = "ColorChoose";
            this.ColorChoose.Size = new System.Drawing.Size(88, 93);
            this.ColorChoose.TabIndex = 10;
            this.ColorChoose.UseVisualStyleBackColor = true;
            this.ColorChoose.Click += new System.EventHandler(this.ColorChoose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DrawBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox DrawBoard;
        private System.Windows.Forms.Button Pencil;
        private System.Windows.Forms.Button Erase;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Elipse;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button ColorChoose;
    }
}

