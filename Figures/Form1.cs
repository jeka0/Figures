using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class Form1 : Form
    {
        private int indent = 3;
        private List<FormPoint> points;
        public Form1()
        {
            InitializeComponent();
            points = new List<FormPoint>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddPoint();
            AddPoint();
        }
        private void AddPoint()
        {
            Label label = new Label();
            label.Location = new Point(3, indent);
            label.Size = new Size(26,22);
            label.Text = "P" + (points.Count+1).ToString();
            FormPoint point = new FormPoint(label, createTextBox(43, indent), createTextBox(105, indent));
            points.Add(point);
            panel.Controls.Add(point.label);
            panel.Controls.Add(point.X);
            panel.Controls.Add(point.Y);
            indent += 25;
        }
        private TextBox createTextBox(int x, int y)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(x, y);
            textBox.Size = new Size(50, 22);
            return textBox;


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(points.Count<6)AddPoint();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(points.Count>2)
            {
                FormPoint point = points.Last();
                panel.Controls.Remove(point.label);
                panel.Controls.Remove(point.X);
                panel.Controls.Remove(point.Y);
                points.RemoveAt(points.Count - 1);
                indent -= 25;
            }
        }

        private void drawButt_Click(object sender, EventArgs e)
        {
            List<Point> nowPoints = new List<Point>();
            foreach (FormPoint point in points) if (point.tryGetPoint(out Point nowPoint)) nowPoints.Add(nowPoint); else return;
            MyDrawing drawing = new MyDrawing(new Bitmap(pictureBox1.Width, pictureBox1.Height));
            //drawing.DrawCircle(new Point(200, 200), 100, Color.Black);
            if (nowPoints.Count == 2) drawing.DarwLine(nowPoints[0], nowPoints[1], Color.Black);
            else drawing.DrawPolygon(Color.Black, nowPoints.ToArray());
            pictureBox1.Image = drawing.image;
        }
    }
}
