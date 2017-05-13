using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FigureDrawer
{
    class CircleDrawer : FigureDrawer
    {
        private Circle circle;
        private bool ownMouseDown = false;
        
        public override void OnPaint(object sender, PaintEventArgs e)
        {
            tempBitmap = (Bitmap)bitmap.Clone();
            Graphics temp = Graphics.FromImage(tempBitmap);
            temp.DrawEllipse(Pens.Green, circle.GetFirstPoint().getX(), circle.GetFirstPoint().getY(), circle.getSize(), circle.getSize());
            e.Graphics.DrawImageUnscaled(tempBitmap, 0, 0);
            temp.Dispose();
        }

        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {
                circle.setSize(e.X - circle.GetFirstPoint().getX());
            }
        }

        public override void OnMouseUp(Object sender, MouseEventArgs e)
        {
            ownMouseDown = false;
            bitmap = (Bitmap)tempBitmap.Clone();
            setMainBitmap(bitmap);            
        }

        public override void OnMouseDown(Object sender, MouseEventArgs e)
        {
            circle = new Circle(new Point(e.X, e.Y), 0);
            ownMouseDown = true;
        }
    }
}
