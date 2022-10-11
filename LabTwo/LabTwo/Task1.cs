﻿using LabTwo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTwo
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void SelectColor_Click(object sender, EventArgs e)
        {
            SelectedСolor.BackColor = (sender as Button).BackColor;
        }

        private void thicknessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
            Debug.WriteLine(number);
        }

        private void checkWidth()
        {
            try
            {
                Convert.ToInt32(thicknessTextBox.Text);
            } catch
            {
                MessageBox.Show("Некорректное значение толщины линии", "Ошибка");
                thicknessTextBox.Text = 1.ToString();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e) => panelForPaint.Invalidate();

        private void panelForPaint_MouseDown(object sender, MouseEventArgs e)
        {
            SingletonPoints startPoint = SingletonPoints.getInstance();
            startPoint.X = e.X;
            startPoint.Y = e.Y;
        }

        private void panelForPaint_MouseUp(object sender, MouseEventArgs e)
        {
            this.checkWidth();

            float[] dashValues = { 5, 2, 15, 4 };
            SingletonPoints startPoint = SingletonPoints.getInstance();
            Pen pen = new Pen(SelectedСolor.BackColor, Convert.ToInt32(thicknessTextBox.Text));
            pen.DashPattern = dashValues;
            Graphics g = this.panelForPaint.CreateGraphics();
            g.DrawLine(pen, new Point(startPoint.X, startPoint.Y), new Point(e.X, e.Y));
        }
    }
}
