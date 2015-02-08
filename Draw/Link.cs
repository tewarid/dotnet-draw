using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Link : Shape
    {
        public Link()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);
            if (Selected)
            {
                p.Width = 2F;
            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(p, 2, 2, this.Width - 3, this.Height - 3);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Limit region to draw/clip
            this.BackColor = Color.Transparent;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            Point[] clipPolygon = new Point[] { new Point(4, 0), new Point(Width - 1, Height - 5), new Point(Width - 5, Height - 1), new Point(0, 4) };
            path.AddPolygon(clipPolygon);
            this.Region = new System.Drawing.Region(path);
        }
    }
}
