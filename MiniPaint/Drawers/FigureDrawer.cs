using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FigureDrawer
{
    abstract class FigureDrawer : Panel
    {
        private Bitmap mainBitmap;
        public Bitmap ownBitmap, ownTempBitmap;
        
        public Bitmap bitmap
        {
            get { return ownBitmap; }
            set { ownBitmap = value; }
        }

        public Bitmap tempBitmap
        {
            get { return ownTempBitmap; }
            set { ownTempBitmap = value; }
        }

        public void setBmp(Bitmap bmp)
        {
            this.ownBitmap = bmp;
        }

        public Bitmap getMainBitmap()
        {
            return mainBitmap;
        }

        public void setMainBitmap(Bitmap mainBitmap)
        {
            this.mainBitmap = mainBitmap;
        }

        public abstract void OnPaint(Object sender, PaintEventArgs e);
        public abstract void OnMouseMove(Object sender, MouseEventArgs e);
        public abstract void OnMouseUp(Object sender, MouseEventArgs e);
        public abstract void OnMouseDown(Object sender, MouseEventArgs e);
    }
}
