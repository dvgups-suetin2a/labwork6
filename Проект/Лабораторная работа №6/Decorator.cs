using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Лабораторная_работа__6
{
    public class Decorator:Shape
    {
        protected Shape actualShape = null;
        public void SetupComponent(Shape shape)
        {
            actualShape = shape;
        }
        public override void Draw(PaintEventArgs e)
        {
            if (actualShape != null)
                actualShape.Draw(e);
        } 
    }
}
