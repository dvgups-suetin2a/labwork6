using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Лабораторная_работа__6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Tetragon tetragon = new Tetragon(Brushes.Red, 200, 200, 100);
            Circle circle = new Circle(Brushes.Green, 200, 200, 100);
            Tetragon tetragon1 = new Tetragon(Brushes.Yellow, 225, 225, 50); 
            circle.SetupComponent(tetragon1);
            circle.Draw(e);
            tetragon.SetupComponent(circle);
            tetragon.Draw(e);
        }
    }
}
