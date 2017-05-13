using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDrawer
{
    class Rectangle : Shapes
    {
        private int Width;
        private int Height;

        public Rectangle(Point firstPoint, int width, int height) : base(firstPoint)
        {
            setWidth(width);
            setHeight(height);
        }

        public void setWidth(int width)
        {
            this.Width = width;
        }

        public void setHeight(int height)
        {
            this.Height = height;
        }

        public int getWidth()
        {
            return Width;
        }

        public int getHeight()
        {
            return Height;
        }
    }
}
