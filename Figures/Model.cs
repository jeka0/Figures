using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Figures
{
    public class Model
    {
        private Form1 form;
        public MyDrawing drawing { get; private set; }
        private Point point1;
        private int L1,L2,OffsetL1,OffsetL2,SpeedL1,SpeedL2;
        private bool DirectionL1, DirectionL2;
        public Color color { get; set; }
        public Model(Form1 form, Point point1, int L1, bool DirectionL1, int OffsetL1, int SpeedL1, int L2, bool DirectionL2, int OffsetL2, int SpeedL2)
        {
            this.form = form;
            this.drawing = new MyDrawing(new Bitmap(form.getW(),form.getH()));
            this.point1 = point1;
            this.L1 = L1;
            this.DirectionL1 = DirectionL1;
            this.OffsetL1 = OffsetL1;
            this.SpeedL1 = SpeedL1;
            this.L2 = L2;
            this.DirectionL2 = DirectionL2;
            this.OffsetL2 = OffsetL2;
            this.SpeedL2 = SpeedL2;
            this.color = Color.Black;
        }
        public void run()
        {
            double i = 0, j=0;
            int speed1 = 100 - (SpeedL1/2+SpeedL2/2) + 1;
            double speed1Dx =  0.05+(SpeedL1 / 100) * 5, speed2Dx = 0.15 + (SpeedL2 / 10);
            int w = drawing.image.Width, h = drawing.image.Height;
            while (true)
            {
                drawing.image = new Bitmap(w, h);
                drawing.DarwLine(point1, Rotation(point1, L1, i, DirectionL1), color);
                Point centerL2 = Rotation(point1, L1 - OffsetL1, i, DirectionL1);
                drawing.DarwLine(Rotation(centerL2, L2 / 2 - OffsetL2, j+3.14, DirectionL2), Rotation(centerL2, L2 / 2 + OffsetL2, j, DirectionL2), color);
                i += speed1Dx; j += speed2Dx;
                form.setImage(drawing.image);
                Thread.Sleep(1);
            }
        }
        public Point Rotation(Point center, int R, double t, bool flag)
        {
            Point point = new Point();
            int x = (int)(R * Math.Cos(t));
            if (!flag) x *= -1;
            point.X = center.X + x;
            point.Y = center.Y + (int)(R * Math.Sin(t));
            return point;
        }
    }
}
