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
    public partial class Task3 : Form
    {
        private readonly Random r = new Random();
        private readonly Graphics Graph;

        public Task3()
        {
            InitializeComponent();
            this.Graph = CreateGraphics();
        }

        private void Task3_MouseDown(object sender, MouseEventArgs e)
        {
            int borderWith = r.Next(15) + 1;
            int radius = r.Next(100) + 10;
            Color borderColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            Color fillColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            Pen pen = new Pen(borderColor, borderWith);

            Graph.DrawEllipse(pen, e.X - radius / 2, e.Y - radius / 2, radius, radius);
            Graph.FillEllipse(new SolidBrush(fillColor), e.X - radius / 2, e.Y - radius / 2, radius, radius);
        }
    }
}
