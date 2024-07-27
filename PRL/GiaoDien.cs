using System;
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
    public partial class GiaoDien : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public GiaoDien()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        private void menuFEFA_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuFeFaSanPham.Height += 10;
                if (menuFeFaSanPham.Height >= 317)
                {
                    menuFEFA.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuFeFaSanPham.Height -= 10;
                if (menuFeFaSanPham.Height <= 58)
                {
                    menuFEFA.Stop();
                    menuExpand = false;
                }
            }
        }

        private void sanpham_Click(object sender, EventArgs e)
        {
            menuFEFA.Start();
        }

        private void menuNhanVien_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuFeFaNhanVien.Height += 10;
                if (menuFeFaNhanVien.Height >= 194)
                {
                    menuNhanVien.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuFeFaNhanVien.Height -= 10;
                if (menuFeFaNhanVien.Height <= 58)
                {
                    menuNhanVien.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menuNhanVienFeFa_Click(object sender, EventArgs e)
        {
            menuNhanVien.Start();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void menuHoaDon_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuFeFaHoaDon.Height += 10;
                if (menuFeFaHoaDon.Height >= 317)
                {
                    menuHoaDon.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuFeFaHoaDon.Height -= 10;
                if (menuFeFaHoaDon.Height <= 58)
                {
                    menuHoaDon.Stop();
                    menuExpand = false;
                }
            }
        }

        private void FEFAHoaDon_Click(object sender, EventArgs e)
        {
            menuHoaDon.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
