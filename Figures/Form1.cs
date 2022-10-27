using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Figures
{
    public partial class Form1 : Form
    {
        private int indent = 3;
        private List<FormPoint> points;
        private Color color;
        private Bitmap image;
        private Thread thread;
        public void setImage(Bitmap image)
        {
            pictureBox1.Invoke(new Action(() => pictureBox1.Image = image));
        }
        public Form1()
        {
            InitializeComponent();
            points = new List<FormPoint>();
            color = Color.Black;
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            thread = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.BackColor = color;
            AddPoint();
            AddPoint();
        }
        private void AddPoint()
        {
            Label label = new Label();
            label.Location = new Point(3, indent);
            label.Size = new Size(26,22);
            label.Text = "P" + (points.Count+1).ToString();
            FormPoint point = new FormPoint(label, createTextBox(33, indent), createTextBox(80, indent));
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
            textBox.Size = new Size(33, 22);
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
            if (thread == null)
            {
                MyDrawing drawing = new MyDrawing(new Bitmap(pictureBox1.Width, pictureBox1.Height));
                if (tabControl1.SelectedTab == tabPage1)
                {
                    List<Point> nowPoints = new List<Point>();
                    foreach (FormPoint point in points) if (point.tryGetPoint(out Point nowPoint)) nowPoints.Add(nowPoint); else return;
                    if (nowPoints.Count == 2) drawing.DarwLine(nowPoints[0], nowPoints[1], color);
                    else drawing.DrawPolygon(color, nowPoints.ToArray());
                }
                else if (tabControl1.SelectedTab == tabPage2)
                {
                    FormPoint point = new FormPoint(null, textCircleX, textCircleY);
                    if (point.tryGetPoint(out Point newPoint) && int.TryParse(textCircleRadius.Text, out int R))
                    {
                        drawing.DrawCircle(newPoint, R, color);
                    }
                }
                else if (tabControl1.SelectedTab == tabPage3)
                {
                    FormPoint point = new FormPoint(null, textEllipsX, textEllipsY);
                    if (point.tryGetPoint(out Point newPoint) && int.TryParse(textEllipsB.Text, out int B) && int.TryParse(textEllipsM.Text, out int M))
                    {
                        drawing.DrawEllipse(newPoint, B, M, color);
                    }
                }
                else if (tabControl1.SelectedTab == tabPage4)
                {
                    FormPoint point = new FormPoint(null, textModelX, textModelY);
                    if (point.tryGetPoint(out Point newPoint) && int.TryParse(textModelL1.Text, out int L1) && L1>0 && int.TryParse(textOffsetL1.Text, out int OffsetL1)
                        && OffsetL1>=0&& OffsetL1 < L1 && int.TryParse(textSpeedL1.Text, out int SpeedL1) && SpeedL1>0 && SpeedL1<=100 && int.TryParse(textModelL2.Text, out int L2) 
                        && L2 >0 && int.TryParse(textSpeedL2.Text, out int SpeedL2) && SpeedL2 > 0 && SpeedL2 <= 100 && int.TryParse(textOffsetL2.Text, out int OffsetL2)&&
                        OffsetL1 >=-L2/2 && OffsetL1 <= L2/2 )
                    {
                        Model model = new Model(this, drawing, newPoint, L1, radioButtonRight.Checked, OffsetL1, SpeedL1,
                            L2, radioButtonRight2.Checked, OffsetL2, SpeedL2);
                        model.color = color;
                        thread = new Thread(model.run);
                        thread.Start();
                    }
                }

                this.image = drawing.image;
                pictureBox1.Image = drawing.image;
            }
            else { thread.Abort(); thread = null; }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                pictureBox2.BackColor = color;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(radioButton2.Checked && e.Button == MouseButtons.Right)
            {
                MyDrawing drawing = new MyDrawing(image);
                drawing.Fill(new Point(e.X,e.Y),color);
                this.image = drawing.image;
                pictureBox1.Image = drawing.image;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(thread!=null) thread.Abort();
        }
    }
}
