using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    public class MyDrawing
    {
        public Bitmap image { get; set; }
        public MyDrawing(Bitmap image)
        {
            this.image = image;
        }
        private void Swap(ref Point point1, ref Point point2)
        {
            Point swapPoint = point1;
            point1 = point2;
            point2 = swapPoint;
        }
        public void DarwLine(Point point1, Point point2, Color color)
        {
            bool flag = true;
            if (point1.X > point2.X) Swap(ref point1, ref point2);
            int X1 = point1.X, X2 = point2.X, Y1 = point1.Y, Y2 = point2.Y;
            if (Math.Abs(X2 - X1) < Math.Abs(Y2 - Y1)) 
            {
                flag = false;
                if (point2.Y < point1.Y) Swap(ref point1, ref point2);
                X1 = point1.Y; X2 = point2.Y;
                Y1 = point1.X; Y2 = point2.X;
            }
            for (int i = X1; i <= X2; i++)
            {
                int j = (i - X1) * (Y2 - Y1) / (X2 - X1) + Y1;
                if(flag)DrawPoint(i, j, color);else DrawPoint(j, i, color);
            }
        }
        public void Fill(Point point, Color color)
        {
            Color oldColor = image.GetPixel(point.X, point.Y);
            Queue<Point> points = new Queue<Point>(); 
            if (!inArea(point.X, point.Y)) return;
            points.Enqueue(point); image.SetPixel(point.X, point.Y, color);
            while (points.Count != 0)
            {
                Point nowPoint = points.Dequeue();
                if (isTrue(nowPoint.X - 1, nowPoint.Y, oldColor)) { image.SetPixel(nowPoint.X-1, nowPoint.Y, color); points.Enqueue(new Point(nowPoint.X - 1, nowPoint.Y)); }
                if (isTrue(nowPoint.X + 1, nowPoint.Y, oldColor)) { image.SetPixel(nowPoint.X+1, nowPoint.Y, color); points.Enqueue(new Point(nowPoint.X + 1, nowPoint.Y)); }
                if (isTrue(nowPoint.X, nowPoint.Y - 1, oldColor)) { image.SetPixel(nowPoint.X, nowPoint.Y-1, color); points.Enqueue(new Point(nowPoint.X, nowPoint.Y - 1)); }
                if (isTrue(nowPoint.X, nowPoint.Y + 1, oldColor)) { image.SetPixel(nowPoint.X, nowPoint.Y+1, color); points.Enqueue(new Point(nowPoint.X, nowPoint.Y + 1)); }
            }
        }
        private bool isTrue(int x, int y, Color oldColor)
        {
            return inArea(x, y) && image.GetPixel(x, y) == oldColor;
        }
        private bool inArea(int x,int y)
        {
            return x >= 0 && y>=0 && x < image.Width && y < image.Height;
        }
        public void DrawEllipse(Point point, int semiMajorAxis, int semiMinorAxis, Color color)
        {
            int x = 0;
            int y = semiMinorAxis;
            int a_sqr = semiMajorAxis * semiMajorAxis;
            int b_sqr = semiMinorAxis * semiMinorAxis;
            int delta = 4 * b_sqr * ((x + 1) * (x + 1)) + a_sqr * ((2 * y - 1) * (2 * y - 1)) - 4 * a_sqr * b_sqr;
            while (a_sqr * (2 * y - 1) > 2 * b_sqr * (x + 1))
            {
                DrawPoint(point.X + x, point.Y + y, color);
                DrawPoint(point.X + x, point.Y - y, color);
                DrawPoint(point.X - x, point.Y - y, color);
                DrawPoint(point.X - x, point.Y + y, color);
                if (delta < 0)
                {
                    x++;
                    delta += 4 * b_sqr * (2 * x + 3);
                }
                else 
                {
                    x++;
                    delta = delta - 8 * a_sqr * (y - 1) + 4 * b_sqr * (2 * x + 3);
                    y--;
                }
            }
            delta = b_sqr * ((2 * x + 1) * (2 * x + 1)) + 4 * a_sqr * ((y + 1) * (y + 1)) - 4 * a_sqr * b_sqr;
            while (y + 1 != 0)
            {
                DrawPoint(point.X + x, point.Y + y, color);
                DrawPoint(point.X + x, point.Y - y, color);
                DrawPoint(point.X - x, point.Y - y, color);
                DrawPoint(point.X - x, point.Y + y, color);
                if (delta < 0)
                {
                    y--;
                    delta += 4 * a_sqr * (2 * y + 3);
                }
                else
                {
                    y--;
                    delta = delta - 8 * b_sqr * (x + 1) + 4 * a_sqr * (2 * y + 3);
                    x++;
                }
            }
        }
        public void DrawCircle(Point point, int radius, Color color)
        {
            int x = 0;
            int y = radius;
            int delta = 1 - 2 * radius;
            int error = 0;
            while (y >= x)
            {
                DrawPoint(point.X + x, point.Y + y, color);
                DrawPoint(point.X + x, point.Y - y, color);
                DrawPoint(point.X - x, point.Y + y, color);
                DrawPoint(point.X - x, point.Y - y, color);
                DrawPoint(point.X + y, point.Y + x, color);
                DrawPoint(point.X + y, point.Y - x, color);
                DrawPoint(point.X - y, point.Y + x, color);
                DrawPoint(point.X - y, point.Y - x, color);
                error = 2 * (delta + y) - 1;
                if ((delta < 0) && (error <= 0))
                {
                    delta += 2 * ++x + 1;
                    continue;
                }
                if ((delta > 0) && (error > 0))
                {
                    delta -= 2 * --y + 1;
                    continue;
                }
                delta += 2 * (++x - --y);
             }
        }
        public void DrawPolygon(Color color, params Point[] points)
        {
            if (points.Length!=0)
            {
                for (int i = 0; i < points.Length - 1; i++)
                {
                    DarwLine(points[i], points[i + 1], color);
                }
                DarwLine(points[points.Length - 1], points[0], color);
            }
        }
        public void DrawPoint(Point point, Color color)
        {
            DrawPoint(point.X, point.Y, color);
        }
        public void DrawPoint(int x, int y, Color color)
        {
            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                    if (i >= 0 && j >= 0 && i < image.Width && j < image.Height) image.SetPixel(i, j, color);
        }
    }
}
