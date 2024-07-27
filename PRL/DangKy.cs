﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class DangKy : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);

        public DangKy()
        {
            InitializeComponent();

        }

        private void ptnDK_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void ptnDK_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y -start_point.Y);
            }
        }

        private void ptnDK_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}