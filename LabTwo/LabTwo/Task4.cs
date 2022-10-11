using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTwo
{
    public partial class Task4 : Form
    {
        private readonly Graphics g;
        private readonly Random r = new Random();
        private int[,] points = new int[3, 2];
        private int countClick = 0;
        private readonly int lineWidth = 3;

        public Task4()
        {
            InitializeComponent();
            this.g = this.CreateGraphics();
        }
        private Point getPoint(int i) => new Point(this.points[i, 0], this.points[i, 1]);

        private void createTriangle()
        {
            Color color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            this.g.DrawLines(new Pen(color, this.lineWidth), new[] { this.getPoint(0), this.getPoint(1), this.getPoint(2), this.getPoint(0) });
        }

        private void Task4_MouseDown(object sender, MouseEventArgs e)
        {
            this.points[countClick, 0] = e.X;
            this.points[countClick, 1] = e.Y;
            this.countClick++;

            if (countClick == 3)
            {
                this.createTriangle();
                this.countClick = 0;
            }
        }

        private void Task4_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
        }

    }
}
