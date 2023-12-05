using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        public double width, height, x, y;
        public Rectangle(double width, double height, double x, double y) 
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }        
        public void CalculateArea()
        {
            double area = Math.Abs(width * height);
            Console.WriteLine($"Obsah obdélníku je {area}");
        }
        public void CalculateAspectRatio()
        {
            double ratio = Math.Abs(width / height);
            if (ratio > 1)
            {
                Console.WriteLine("Obdélník je široký");
            }
            else if (ratio < 1)
            {
                Console.WriteLine("Obdélník je vysoký");
            }
            else if (ratio == 1) 
            {
                Console.WriteLine("Je to čtverec");
            }
        }
        public void ContainsPoint()
        {
            double pointX = Convert.ToDouble(Console.ReadLine());
            double pointY = Convert.ToDouble(Console.ReadLine());
            if (width >= 0)
            {
                if (height >= 0)
                {
                    if ((pointX >= x) && (pointY >= y) && (pointX <= width + x) && (pointY <= height + y))
                    {
                        Console.WriteLine("Bod se nachází v obdélníku");
                    }
                    else
                    {
                        Console.WriteLine("Bod se nenachází v obdélníku");
                    }
                }
                else
                {
                    if ((pointX >= x) && (pointY <= y) && (pointX <= width + x) && (pointY >= height - y))
                    {
                        Console.WriteLine("Bod se nachází v obdélníku");
                    }
                    else
                    {
                        Console.WriteLine("Bod se nenachází v obdélníku");
                    }
                }
            }
            else
            {
                if (height >= 0)
                {
                    if ((pointX <= x) && (pointY >= y) && (pointX >= width - x) && (pointY <= height + y))
                    {
                        Console.WriteLine("Bod se nachází v obdélníku");
                    }
                    else
                    {
                        Console.WriteLine("Bod se nenachází v obdélníku");
                    }
                }
                else
                {
                    if ((pointX <= x) && (pointY <= y) && (pointX >= width - x) && (pointY >= height - y))
                    {
                        Console.WriteLine("Bod se nachází v obdélníku");
                    }
                    else
                    {
                        Console.WriteLine("Bod se nenachází v obdélníku");
                    }
                }
            }
        }
    }
}
