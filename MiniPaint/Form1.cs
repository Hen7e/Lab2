using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDrawer
{
    public partial class Form1 : Form
    {

        public Bitmap mainBitMap;
        bool mouseDown = false;
        PaintEventHandler paintEvent;

        LineDrawer lineDrawer;
        RectangleDrawer rectangleDrawer;
        SquareDrawer squareDrawer;
        EllipseDrawer ellipseDrawer;
        CircleDrawer circleDrawer;
        FigureDrawer figureDrawer;

        MouseEventHandler[] mouseEvents = new MouseEventHandler[3];

        public Form1()
        {
            InitializeComponent();
            Graphics g = panel.CreateGraphics();
            mainBitMap = new Bitmap(panel.Width, panel.Height);
            lineDrawer = new LineDrawer();
            rectangleDrawer = new RectangleDrawer();
            squareDrawer = new SquareDrawer();
            ellipseDrawer = new EllipseDrawer();
            circleDrawer = new CircleDrawer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeleteMouseEvensts()
        {
            if (mouseEvents[0] != null)
            {
                panel.MouseDown -= mouseEvents[0];
                panel.MouseMove -= mouseEvents[1];
                panel.MouseUp -= mouseEvents[2];
                panel.Paint -= paintEvent;
            }
        }

        private void AddMouseEvents()
        {
            panel.MouseDown += mouseEvents[0];
            panel.MouseMove += mouseEvents[1];
            panel.MouseUp += mouseEvents[2];
            panel.Paint += paintEvent;
        }

        private void ChangeMouseEvents(MouseEventHandler mouseDown, MouseEventHandler mouseMove, MouseEventHandler mouseUp, PaintEventHandler paint)
        {
            mouseEvents[0] = mouseDown;
            mouseEvents[1] = mouseMove;
            mouseEvents[2] = mouseUp;
            this.paintEvent = paint;
        }

        private void panelForDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelForDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panelForDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                panel.Refresh();
                panel.Update();
            }
        }

        private void AddNewDrawer(FigureDrawer drawer)
        {
            if (figureDrawer != null)
                mainBitMap = figureDrawer.getMainBitmap();
            figureDrawer = drawer;
            drawer.setBmp(mainBitMap);
            DeleteMouseEvensts();
            ChangeMouseEvents(drawer.OnMouseDown, drawer.OnMouseMove, drawer.OnMouseUp, drawer.OnPaint);
            AddMouseEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                AddNewDrawer(lineDrawer);
            else
             if (radioButton2.Checked == true)
                AddNewDrawer(rectangleDrawer);
            else
                if (radioButton3.Checked == true)
                AddNewDrawer(squareDrawer);
            else
                if (radioButton4.Checked == true)
                AddNewDrawer(ellipseDrawer);
            else
                if (radioButton5.Checked == true)
                AddNewDrawer(circleDrawer);
        }
    }
}
