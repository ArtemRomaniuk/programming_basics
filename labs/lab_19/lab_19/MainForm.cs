using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_19
{
    public partial class MainForm : Form
    {
        private bool isPainting = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (isPainting)
            {
                g.DrawString("\"Пейзажик)))\"", new Font("Lobster", 18, FontStyle.Italic), Brushes.Magenta, 400, 60);
                g.DrawCurve(new Pen(Color.LightGreen, 8), [new Point(700, 660), new Point(690, 625), new Point(695, 600), new Point(695, 585)]);
                g.FillClosedCurve(Brushes.Green, [new Point(0, 600), new Point(300, 550), new Point(700, 650), new Point(1006, 600), new Point(1006, 793), new Point(0, 793)]);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPainting = true;
            Invalidate();
        }

        private void clearImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPainting = false;
            Invalidate();
        }
    }
}