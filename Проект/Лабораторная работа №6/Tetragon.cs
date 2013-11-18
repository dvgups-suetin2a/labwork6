using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Лабораторная_работа__6
{
    class Tetragon:Decorator
    {
        Brush brush;
        float x, y, a;
        public Tetragon(Brush B, float X, float Y, float A)
        {
            brush = B;
            x = X;
            y = Y;
            a = A;
        }
        public override void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brush, x, y, a, a);
            base.Draw(e);
        }
    }
}
