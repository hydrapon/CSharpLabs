using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTwo
{
    public partial class Task5 : Form
    {
        private int x, y;
        private readonly Graphics g;
        private bool draw = false;
        private readonly Pen pen;
        private readonly int[] startPoint = { 0, 0 };
        private readonly Random r = new Random();

        public Task5()
        {
            InitializeComponent();
            this.g = this.CreateGraphics();
            this.pen = new Pen(Color.Red, 3);
        }

        private void Task5_MouseDown(object sender, MouseEventArgs e)
        {
            if (draw) g.DrawLine(this.pen, this.x, this.y, e.X, e.Y);
            this.x = e.X;
            this.y = e.Y;

        }

        private void Task5_FormClosing(object sender, FormClosingEventArgs e)
        {
            pen.Dispose();
            g.Dispose();
        }

        private void Task5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Color fillColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                g.DrawLine(pen, this.startPoint[0], this.startPoint[1], e.X, e.Y);
                pen.Color = fillColor;
            }
            this.startPoint[0] = e.X;
            this.startPoint[1] = e.Y;
            this.draw = !draw;
        }


    }
}
