using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawer
{
    class Point
    {
        private int X, Y;
        public Point(int x, int y)
        {
            setX(x);
            setY(y);
        }

        public void setX(int x)
        {
            this.X = x;
        }

        public void setY(int y)
        {
            this.Y = y;
        }

        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
    }
}
