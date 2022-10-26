using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Figures
{
    public class FormPoint
    {
        public Label label { get; }
        public TextBox X { get; }
        public TextBox Y { get; }
        public FormPoint(Label label, TextBox X, TextBox Y)
        {
            this.label = label;
            this.X = X;
            this.Y = Y;
        }
        public bool tryGetPoint(out Point value)
        {
            if(Int32.TryParse(X.Text, out int valueX) && Int32.TryParse(Y.Text, out int valueY))
            {
                value = new Point(valueX, valueY);
                return true;
            }
            value = default(Point);
            return false;
        }
    }
}
