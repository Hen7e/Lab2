using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace FigureDrawer
{
    class LineDrawer : FigureDrawer
    {
        private Line line;
        private bool ownMouseDown = false;
        
        public override void OnPaint(object sender, PaintEventArgs e)
        {
            tempBitmap = (Bitmap)bitmap.Clone();
            Graphics temp = Graphics.FromImage(tempBitmap);
            temp.DrawLine(Pens.Black, line.GetFirstPoint().getX(), line.GetFirstPoint().getY(), line.getSecondPoint().getX(), line.getSecondPoint().getY());
            e.Graphics.DrawImageUnscaled(tempBitmap, 0, 0);
            temp.Dispose();
        }

        public override void OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (ownMouseDown)
            {
                line.setSecondPoint(new Point(e.X, e.Y));
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
            line = new Line(new Point(e.X, e.Y), new Point(e.X, e.Y));
            ownMouseDown = true;
        }
    }
}
