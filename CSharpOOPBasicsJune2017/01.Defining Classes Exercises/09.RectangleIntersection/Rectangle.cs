using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RectangleIntersection
{
    public class Rectangle
    {
        public string ID { get; set; }
        public double Width { get; set; }
        public double Heigth { get; set; }
        public double FirstCoord { get; set; }
        public double SecondCoord { get; set; }

        public Rectangle(string id, double weight, double height, double firstCoord, double secondCoord)
        {
            this.ID = id;
            this.Width = weight;
            this.Heigth = height;
            this.FirstCoord = firstCoord;
            this.SecondCoord = secondCoord;
        }

        public bool IsThereIntersection(Rectangle rectangle)
        {
            return rectangle.FirstCoord + rectangle.Width >= this.FirstCoord &&
                rectangle.FirstCoord <= this.FirstCoord + this.Width &&
                rectangle.SecondCoord >= this.SecondCoord - this.Heigth &&
                rectangle.SecondCoord - rectangle.Heigth <= this.SecondCoord;
        }
    }
}
