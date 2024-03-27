using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malování
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(DrawBoard.Width, DrawBoard.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            DrawBoard.Image = bm;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 20);
        int index;
        int x, y, x1, y1, xwidth, yheight;
        Color newClr;
        ColorDialog cd = new ColorDialog();
        private void DrawBoard_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            x1 = e.X;
            y1 = e.Y;
        }

        private void Elipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void DrawBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint == true)
            {
                if (index == 3)
                {
                    g.DrawEllipse(pen, x1, y1, xwidth, yheight);
                }
                if (index == 4)
                {
                    g.DrawRectangle(pen, x1, y1, xwidth, yheight);
                }
                if (index == 5)
                {
                    g.DrawLine(pen, x1, y1, x, y);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            DrawBoard.Image = bm;
            index = 0;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void DrawBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint == true)
            {
                if(index == 1)
                {
                    px = e.Location;
                    g.DrawLine(pen, px, py);
                    py = px;
                }
                if(index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
            }
            x = e.X;
            y = e.Y;
            xwidth = e.X - x1;
            yheight = e.Y - y1;
            DrawBoard.Refresh();
        }

        private void DrawBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 6)
            {
                Point point = set_Point(DrawBoard, e.Location);
                Paint1(bm, point.X, point.Y, newClr);
            }
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void ColorChoose_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            newClr = cd.Color;
            DrawBoard.BackColor = cd.Color;
            pen.Color = cd.Color;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var sfd  = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|8.jpg|(*.*)|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, DrawBoard.Width, DrawBoard.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void DrawBoard_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            if(index == 3)
            {
                g.DrawEllipse(pen, x1, y1, xwidth, yheight);
            }
            if(index == 4)
            {
                g.DrawRectangle(pen, x1, y1, xwidth, yheight);
            }
            if(index == 5)
            {
                g.DrawLine(pen, x1, y1, x, y);
            }
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void Pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        static Point set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }

        private void VAlidate(Bitmap bm, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            Color x1 = bm.GetPixel(x, y);
            if (x1 == oldColor)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, newColor);
            }
        }

        public void Paint1(Bitmap bm, int x, int y, Color newClr)
        {
            Color oldColor = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, newClr);
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    VAlidate(bm, pixel, pt.X - 1, pt.Y, oldColor, newClr);
                    VAlidate(bm, pixel, pt.X, pt.Y - 1, oldColor, newClr);
                    VAlidate(bm, pixel, pt.X + 1, pt.Y, oldColor, newClr);
                    VAlidate(bm, pixel, pt.X, pt.Y + 1, oldColor, newClr);
                }
            }
        }
    }
}
