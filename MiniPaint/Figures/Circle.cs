using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawer
{
    class Circle : Ellipse
    {
        public Circle(Point center, int r) : base(new Point(center.getX(), center.getY()), new Point(center.getX() + r, center.getY() + r))
        {
        }

        public void setSize(int size)
        {
            setSecondPoint(new Point(GetFirstPoint().getX() + size, GetFirstPoint().getY() + size));
        }
        public int getSize()
        {
            int size = getSecondPoint().getX() - GetFirstPoint().getX();
            return size;
        }
    }
}
