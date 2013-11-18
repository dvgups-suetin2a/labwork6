using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Лабораторная_работа__6
{
    class Circle:Decorator
    {
        Brush brush;
        float x, y, d;
        public Circle(Brush B, float X, float Y, float D)
        {
            brush = B;
            x = X;
            y = Y;
            d = D;
        }
        public override void Draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(brush, x, y, d, d);
            base.Draw(e);
        }
    }
}
