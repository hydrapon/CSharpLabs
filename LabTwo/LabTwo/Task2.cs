using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTwo
{
    public partial class Task2 : Form
    {
        private readonly int _sideLength = 20;
        private readonly int _countRays = 8;
        private readonly int _width = 5;
        public Task2()
        {
            InitializeComponent();
        }

        private double hypotenuse() => Math.Sqrt(Math.Pow(this._sideLength, 2) + Math.Pow(this._sideLength, 2));

        private int median(double hypotenuse) => Convert.ToInt32(Math.Round(hypotenuse, 0) / 2);

        private void paintSnowflake(Graphics g, Pen pen, Point pointStart, Point[] pointsEnd)
        {
            for(int i = 0; i < this._countRays; i++)
            {
                g.DrawLine(pen, pointStart, pointsEnd[i]);
            }
        }

        private void Task2_MouseDown(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(Color.White, this._width);
            Graphics g = this.CreateGraphics();
            int h = this.median(this.hypotenuse());
            Point[] pointsEnd = {
                new Point(e.X, e.Y + this._sideLength), new Point(e.X, e.Y - this._sideLength), new Point(e.X - this._sideLength, e.Y), new Point(e.X + this._sideLength, e.Y),
                new Point(e.X - h, e.Y + h), new Point(e.X + h, e.Y + h), new Point(e.X - h, e.Y - h), new Point(e.X + h, e.Y - h)
            };

            this.paintSnowflake(g, pen, new Point(e.X, e.Y), pointsEnd);
        }
    }
}
